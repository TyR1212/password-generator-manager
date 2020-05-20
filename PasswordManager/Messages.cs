using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PasswordManager
{
    class Messages
    {
        private const string DB_ERROR = "ERROR: An error occured when connecting to the database.\n\nHave you installed the Access Database Engine (32-bit)?";
        private const string PASS_REM = "Are you sure you want to remove your";
        private const string CONT_MSG = "Creating a new account will erase all saved passwords. Do you wish to continue?";
        private const string WARN_MSG = "Use this program at your own risk. This is meant to be an example program. Passwords that are stored are unencrypted and " +
                        "stored in the database file: ~\\PasswordManager\\bin\\Debug\\PasswordDB.accdb as plain text.";
        private const string PASS_REQ = "-Password must be at least 8 characters long (50 characters max).\n-Letters, numbers and symbols only.\n-Spaces and single quotes not allowed.";
        private const string ENTRY_REQ = "-Entries must be letters, numbers and symbols only.\n-Single quotes not allowed.\n-Spaces not allowed in passwords";

        public static void ShowDBErrorMsg()
        {
            MessageBox.Show(DB_ERROR, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowPasswordRemoveMsg(string label)
        {
            return MessageBox.Show($"{PASS_REM} \"{label}\" password?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static DialogResult ShowContinueMsg()
        {
            return MessageBox.Show(CONT_MSG, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void ShowWarningMsg()
        {
            MessageBox.Show(WARN_MSG, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        public static void ShowPasswordReqMsg()
        {
            MessageBox.Show(PASS_REQ, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowEntryReqMsg()
        {
            MessageBox.Show(ENTRY_REQ, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
