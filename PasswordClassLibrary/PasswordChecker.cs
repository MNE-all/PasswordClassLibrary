using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordClassLibrary
{
    public class PasswordChecker
    {

        public static bool ValidatePassword(string password)
        {
            var number = false;
            var simbols = false;
            var upper = false;
            var lower = false;

            if (password.Length >= 8 && password.Length <= 20)
            {
                foreach (char c in password)
                {
                    if (Char.IsNumber(c))
                    {
                        number = true;
                    }
                    if (Char.IsLower(c))
                    {
                        lower = true;
                    }
                    if (Char.IsUpper(c))
                    {
                        upper = true;
                    }
                    if (Char.IsPunctuation(c) || Char.IsSeparator(c) || Char.IsSymbol(c))
                    {
                        simbols = true;
                    }
                }
            }

            if (number && simbols && lower && upper)
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }
    }
}
