using PasswordManagerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Dashboard : Form
    {
        private List<Record> records = new List<Record>();
        private BindingSource recordsBinding = new BindingSource();
        private Timer labelTimer = new Timer();

        public Dashboard()
        {
            InitializeComponent();

            RefreshRecords();
            SetUpTimer();
        }

        private void SetUpTimer()
        {
            labelTimer.Interval = 2000;
            labelTimer.Tick += new EventHandler(CopiedLabelDisappear);
        }

        private void RefreshRecords()
        {
            Cursor.Current = Cursors.WaitCursor;
            records = SQLHelper.GetRecords(out bool DBErrorOccured);
            Cursor.Current = Cursors.Default;

            if (DBErrorOccured)
                Messages.ShowDBErrorMsg();

            BindRecords();
            CheckButtonsEnabled();
            UpdatePasswordTextBox();
        }

        private void BindRecords()
        {
            recordsBinding.DataSource = records;
            labelListBox.DataSource = recordsBinding;
            labelListBox.DisplayMember = "DisplayLabel";
            labelListBox.ValueMember = "DisplayLabel";
        }

        private void CheckButtonsEnabled()
        {
            if (labelListBox.SelectedIndex != -1)
            {
                changeDisabledButton.Visible = false;
                changeEnabledButton.Visible = true;
                removeDisabledButton.Visible = false;
                removeEnabledButton.Visible = true;
                copyDisabledButton.Visible = false;
                copyEnabledButton.Visible = true;
            }
            else
            {
                changeDisabledButton.Visible = true;
                changeEnabledButton.Visible = false;
                removeDisabledButton.Visible = true;
                removeEnabledButton.Visible = false;
                copyDisabledButton.Visible = true;
                copyEnabledButton.Visible = false;
            }
        }

        private void UpdatePasswordTextBox()
        {
            if (records != null && records.Count() > 0)
                passwordTextBox.Text = records[labelListBox.SelectedIndex].Password;
            else
                passwordTextBox.Text = "";
        }

        private void logOutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShower.ShowLoginForm();
            Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FormShower.ShowNewPasswordForm();
            RefreshRecords();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (labelListBox.SelectedIndex != -1)
            {
                FormShower.ShowChangePasswordForm(records[labelListBox.SelectedIndex]);
                RefreshRecords();
            }
        }

        private void removeEnabledButton_Click(object sender, EventArgs e)
        {
            if (labelListBox.SelectedIndex != -1)
            {
                DialogResult answer = Messages.ShowPasswordRemoveMsg(records[labelListBox.SelectedIndex].Label);

                if (answer == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    SQLHelper.RemoveRecord(records[labelListBox.SelectedIndex].Label, out bool DBErrorOccured);
                    Cursor.Current = Cursors.Default;

                    if (DBErrorOccured)
                        Messages.ShowDBErrorMsg();
                }

                RefreshRecords();
            }
        }

        private void labelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePasswordTextBox();
            CheckButtonsEnabled();
        }

        private void showCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showCheckBox.Checked;
        }

        private void copyEnabledButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordTextBox.Text);

            if (!copiedLabel.Visible)
            {
                copiedLabel.Visible = true;
                labelTimer.Start();
            }
        }

        private void CopiedLabelDisappear(object sender, EventArgs e)
        {
            copiedLabel.Visible = false;
            labelTimer.Stop();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
