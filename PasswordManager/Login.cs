using System;
using System.Drawing;
using System.Windows.Forms;
using PasswordManagerLibrary;

namespace PasswordManager
{
    public partial class Login : Form
    {
        private string accountPassword;

        public Login()
        {
            InitializeComponent();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            if (accountPassword == null)
            {
                Cursor.Current = Cursors.WaitCursor;
                accountPassword = SQLHelper.GetAcountPassword(out bool DBErrorOccured);
                Cursor.Current = Cursors.Default;

                if (DBErrorOccured)
                {
                    Messages.ShowDBErrorMsg();
                    return;
                }
            }

            if (passwordTextBox.Text != accountPassword)
            {
                if (!passwordTextBox.Text.Equals(""))
                {
                    passwordTextBox.BackColor = Color.LightCoral;
                    incorrectLabel.Visible = true;
                }
            }
            else
            {
                FormShower.ShowDashboardForm();
                Hide();
            }
        }

        private void createLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShower.ShowSignUpForm();
            Hide();
        }

        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                signinButton_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.BackColor = Color.White;
            incorrectLabel.Visible = false;
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            accountPassword = SQLHelper.GetAcountPassword(out bool DBErrorOccured);
            Cursor.Current = Cursors.Default;

            if (DBErrorOccured)
                Messages.ShowDBErrorMsg();
            else if (accountPassword == null)
            {
                FormShower.ShowSignUpForm();
                Hide();
            }
        }

        public void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
