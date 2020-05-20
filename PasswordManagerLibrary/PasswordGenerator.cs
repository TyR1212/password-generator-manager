using System;

namespace PasswordManagerLibrary
{
    public class PasswordGenerator
    {
        const int SINGLE_QUOTE = 39;

        public static string Generate(int length)
        {
            string password = GenerateRandom(length);

            while (!IsValidPassword(password))
                password = GenerateRandom(length);

            return password;
        }

        private static string GenerateRandom(int length)
        {
            string password = "";
            Random rand = new Random();
            int ascii;

            for (int i = 0; i < length; i++)
            {
                ascii = rand.Next(33, 127);
                if (ascii != SINGLE_QUOTE)
                    password += (char)ascii;
                else
                    i--;
            }

            return password;
        }

        private static bool IsValidPassword(string password)
        {
            double numLetters = 0, numSpecials = 0, numDigits = 0;

            foreach (char ch in password)
            {
                if (Char.IsLetter(ch))
                    numLetters++;
                else if (Char.IsDigit(ch))
                    numDigits++;
                else
                    numSpecials++;
            }

            if (numLetters < 4 || numDigits < 2 || numSpecials < 2)
                return false;

            if (numSpecials / password.Length <= 0.35 && numSpecials / password.Length >= 0.25)   //if 25% to 35% of password is special chars...
                return true;
            else
                return false;
        }
    }
}
