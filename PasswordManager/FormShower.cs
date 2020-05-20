using PasswordManagerLibrary;

namespace PasswordManager
{
    class FormShower
    {
        public static void ShowSignUpForm()
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
        }

        public static void ShowDashboardForm()
        {
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.Show();
        }

        public static void ShowLoginForm()
        {
            Login loginForm = new Login();
            loginForm.Show();
            loginForm.FormClosed += loginForm.Login_FormClosed;
        }

        public static void ShowNewPasswordForm()
        {
            NewPassword newPassForm = new NewPassword();
            newPassForm.ShowDialog();
        }

        public static void ShowChangePasswordForm(Record record)
        {
            ChangePassword changePassForm = new ChangePassword(record);
            changePassForm.ShowDialog();
        }
    }
}
