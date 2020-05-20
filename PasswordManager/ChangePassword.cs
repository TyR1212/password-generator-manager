using PasswordManagerLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class ChangePassword : Form
    {
        private HashSet<string> labels = new HashSet<string>();
        private string originalLabel;

        public ChangePassword(Record record)
        {
            InitializeComponent();

            SetInitialValues(record);
            CheckSaveButtonEnabled();
        }

        private void SetInitialValues(Record record)
        {
            originalLabel = record.Label;
            labelTextBox.Text = record.Label;
            passwordTextBox.Text = record.Password;
        }

        private bool IsLabelNameTaken(string label)
        {
            return labels.Contains(label) && !label.Equals(originalLabel);
        }

        private void CheckSaveButtonEnabled()
        {
            if (labelTextBox.Text.Equals("") || passwordTextBox.Text.Equals("") || IsLabelNameTaken(labelTextBox.Text))
            {
                saveDisabledButton.Visible = true;
                saveEnabledButton.Visible = false;
            }
            else
            {
                saveDisabledButton.Visible = false;
                saveEnabledButton.Visible = true;
            }
        }

        private void saveEnabledButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (SQLHelper.UpdatePassword(originalLabel, labelTextBox.Text, passwordTextBox.Text, out bool DBErrorOccured))
            {
                Cursor.Current = Cursors.Default;
                Close();
            }
            else if (DBErrorOccured)
            {
                Cursor.Current = Cursors.Default;
                Messages.ShowDBErrorMsg();
            }
            else
            {
                Cursor.Current = Cursors.Default;
                Messages.ShowEntryReqMsg();
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            passwordTextBox.Text = "";
            passwordTextBox.Text = PasswordGenerator.Generate(Convert.ToInt32(lengthUpDown.Value));
            Cursor.Current = Cursors.Default;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            CheckSaveButtonEnabled();
        }

        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter) && saveEnabledButton.Visible)
            {
                saveEnabledButton_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void ChangePassword_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            labels = SQLHelper.GetLabels(out bool DBErrorOccured);
            Cursor.Current = Cursors.Default;

            if (DBErrorOccured)
            {
                Messages.ShowDBErrorMsg();
                Close();
            }

            CheckSaveButtonEnabled();
        }

        private void backLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
