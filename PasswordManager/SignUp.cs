using System;
using System.Windows.Forms;
using PasswordManagerLibrary;

namespace PasswordManager
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void backLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShower.ShowLoginForm();
            Hide();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (SQLHelper.IsValidPassword(passwordTextBox.Text))
            {
                if (SQLHelper.CreateUser(passwordTextBox.Text, out bool DBErrorOccurred) && !DBErrorOccurred)
                {
                    Cursor.Current = Cursors.Default;

                    DialogResult answer = Messages.ShowContinueMsg();

                    if (answer == DialogResult.Yes)
                    {

                        Cursor.Current = Cursors.WaitCursor;
                        SQLHelper.DeleteAllRecords(out bool DBErrorOccured);
                        Cursor.Current = Cursors.Default;

                        if (DBErrorOccured)
                            Messages.ShowDBErrorMsg();
                        else
                        {
                            Messages.ShowWarningMsg();
                            FormShower.ShowDashboardForm();
                            Hide();
                        }
                    }
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    Messages.ShowDBErrorMsg();
                }
            }
            else
            {
                Cursor.Current = Cursors.Default;
                Messages.ShowPasswordReqMsg();
            }
        }

        private void showCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showCheckBox.Checked;
        }

        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                createButton_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
