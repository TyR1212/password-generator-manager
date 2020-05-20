using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PasswordManagerLibrary;

namespace PasswordManager
{
    public partial class NewPassword : Form
    {
        private HashSet<string> labels = new HashSet<string>();

        public NewPassword()
        {
            InitializeComponent();
            CheckAcceptButtonEnabled();
        }

        private bool IsLabelNameTaken(string label)
        {
            return labels.Contains(label);
        }

        private void CheckAcceptButtonEnabled()
        {
            if (labelTextBox.Text.Equals("") || passwordTextBox.Text.Equals("") || IsLabelNameTaken(labelTextBox.Text))
            {
                acceptDisabledButton.Visible = true;
                acceptEnabledButton.Visible = false;
            }
            else
            {
                acceptDisabledButton.Visible = false;
                acceptEnabledButton.Visible = true;
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
            CheckAcceptButtonEnabled();
        }

        private void acceptEnabledButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (SQLHelper.AddPassword(labelTextBox.Text, passwordTextBox.Text, out bool DBErrorOccured))
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

        private void NewPassword_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            labels = SQLHelper.GetLabels(out bool DBErrorOccured);
            Cursor.Current = Cursors.Default;

            if (DBErrorOccured)
            {
                Messages.ShowDBErrorMsg();
                Close();
            }
        }

        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter) && acceptEnabledButton.Visible)
            {
                acceptEnabledButton_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void backLinkLabel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
