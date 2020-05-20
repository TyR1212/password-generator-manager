using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using Dapper;

namespace PasswordManagerLibrary
{
    public class SQLHelper
    {
        private const string DB_NAME = "Password_Manager_DB";

        //function that uses Dapper to fetch data from the database
        private static List<T> Fetch<T>(string query, out bool fetchSuccessful)
        {
            try
            {
                IDbConnection connection = new System.Data.OleDb.OleDbConnection(ConfigurationManager.ConnectionStrings[DB_NAME].ConnectionString);
                List<T> results = new List<T>();

                using (connection)
                {
                    results = connection.Query<T>(query).ToList();
                }

                fetchSuccessful = true;
                return results;
            }
            catch
            {
                fetchSuccessful = false;
                return null;
            }
        }

        //function that uses Dapper to send data to the database
        private static bool Send(string query)
        {
            try
            {
                IDbConnection connection = new System.Data.OleDb.OleDbConnection(ConfigurationManager.ConnectionStrings[DB_NAME].ConnectionString);

                using (connection)
                {
                    connection.Execute(query);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool CreateUser(string password, out bool DBErrorOccured)
        {
            if (Send($"DELETE * FROM Account WHERE ID = 0") && Send($"INSERT INTO Account (ID, [Password]) VALUES (0, '{password}');"))
            {
                DBErrorOccured = false;
                return true;
            }

            DBErrorOccured = true;
            return false;   //DB error
        }

        public static string GetAcountPassword(out bool DBErrorOccured)
        {
            List<Account> acc = Fetch<Account>($"SELECT * FROM Account WHERE ID = 0;", out bool fetchSuccessful);

            DBErrorOccured = !fetchSuccessful;

            if (DBErrorOccured || acc.Count() == 0)
                return null;
            else
                return acc[0].Password;
        }

        public static bool IsValidPassword(string password)
        {
            return (password.Length >= 8 && password.Length <= 50 && !ConatinsIllegalChars(password));
        }

        public static bool ConatinsIllegalChars(string str)
        {
            return str.Contains('\'') || str.Contains(' ') || ContainsUnicode(str);
        }

        private static bool ContainsUnicode(string str)
        {
            foreach (char ch in str)
                if (ch > 127)
                    return true;

            return false;
        }

        public static bool AddPassword(string label, string password, out bool DBErrorOccured)
        {
            if (!ConatinsIllegalChars(password) && !label.Contains('\'') && !ContainsUnicode(label))
            {
                if (Send($"INSERT INTO Passwords ([Label], [Password]) VALUES ('{label}', '{password}');"))
                {
                    DBErrorOccured = false;
                    return true;
                }
                else
                {
                    DBErrorOccured = true;
                    return false;
                }
            }

            DBErrorOccured = false;
            return false;
        }

        public static bool UpdatePassword(string originalLabel, string label, string password, out bool DBErrorOccured)
        {
            if (!ConatinsIllegalChars(password) && !label.Contains('\'') && !ContainsUnicode(label))
            {
                if (Send($"UPDATE Passwords SET [Password]='{password}', [Label]='{label}' WHERE [Label]='{originalLabel}';"))
                {
                    DBErrorOccured = false;
                    return true;
                }
                else
                {
                    DBErrorOccured = true;
                    return false;
                }
            }

            DBErrorOccured = false;
            return false;
        }

        public static HashSet<string> GetLabels(out bool DBErrorOccured)
        {
            List<Record> records = Fetch<Record>("SELECT * FROM Passwords;", out bool fetchSuccessful);
            HashSet<string> labels = new HashSet<string>();

            DBErrorOccured = !fetchSuccessful;
            
            if (!DBErrorOccured)
                foreach (Record rec in records)
                    labels.Add(rec.Label);

            return labels;
        }

        public static List<Record> GetRecords(out bool DBErrorOccured)
        {
            List<Record> records = Fetch<Record>($"SELECT * FROM Passwords;", out bool fetchSuccessful);
            
            DBErrorOccured = !fetchSuccessful;

            if (DBErrorOccured)
                return null;
            else
            {
                records = records.OrderBy(rec => rec.Label).ToList(); //sort records by label

                return records;
            }
        }

        public static bool RemoveRecord(string label, out bool DBErrorOccured)
        {
            if (Send($"DELETE * FROM Passwords WHERE [Label]='{label}';"))
            {
                DBErrorOccured = false;
                return true;
            }
            else
            {
                DBErrorOccured = true;
                return false;
            }
        }

        public static bool DeleteAllRecords(out bool DBErrorOccured)
        {
            if (Send("DELETE * FROM Passwords;"))
            {
                DBErrorOccured = false;
                return true;
            }
            else
            {
                DBErrorOccured = true;
                return false;
            }
        }
    }
}
