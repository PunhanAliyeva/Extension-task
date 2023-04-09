using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal static class Helper
    {
       public static bool IsOdd(this int num)
        {
            if (num % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool HasDigit(this string word,int num)
        {
            if (num>=0 && word.Contains("num"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckPassword(this string password)
        {
            if (password.Length >= 8)
            {
                bool checkIsUpper=false;
                bool checkIsLower=false;
                bool checkIsDigit=false;
                foreach (char item in password)
                {
                    if (char.IsUpper(item))
                    {
                        checkIsUpper = true;
                    }
                    else if (char.IsLower(item))
                    {
                        checkIsLower = true;
                    }
                    else if (char.IsDigit(item))
                    {
                        checkIsDigit = true;
                    }   
                    }
                return checkIsUpper && checkIsLower && checkIsDigit;
                }
            return false;
            }
        }
    //public static string Capitalize(this string word)
    //    {
    //        return word.ToUpper();
    //    }
    }

