using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net;
using System.Runtime.Remoting.Messaging;

namespace Validation
{
    namespace Public
    {
        public enum MobileOptional
        {
            WithZero,
            WithOutZero,
            Both
        }
        public static class PublicValidation
        {
            public static bool CheckNumeric(this string number)
            {
                try
                {
                    number = number.Trim();
                    if (number.Trim().Length > 18) return false;
                    var isNumeric = long.TryParse(number, out _);
                    return isNumeric;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            public static bool CheckLetter(this string input)
            {
                if (input.CheckEmpty()) return false;
                try
                {
                    bool result = true;
                    foreach (var charachteritem in input.Trim().ToCharArray())
                    {
                        if (!Regex.IsMatch(charachteritem.ToString(), @"[a-zA-Z]"))
                        {
                            result = false;
                            break;
                        }
                    }

                    return result;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            public static bool CheckNationalCode(this String nationalCode)
            {
                if (String.IsNullOrEmpty(nationalCode))
                    return false;

                if (nationalCode.Length != 10)
                    return false;

                var regex = new Regex(@"\d{10}");
                if (!regex.IsMatch(nationalCode))
                    return false;

                var allDigitEqual = new[] { "0000000000", "1111111111", "2222222222", "3333333333", "4444444444", "5555555555", "6666666666", "7777777777", "8888888888", "9999999999" };
                if (allDigitEqual.Contains(nationalCode)) return false;


                var chArray = nationalCode.ToCharArray();
                var num0 = Convert.ToInt32(chArray[0].ToString()) * 10;
                var num2 = Convert.ToInt32(chArray[1].ToString()) * 9;
                var num3 = Convert.ToInt32(chArray[2].ToString()) * 8;
                var num4 = Convert.ToInt32(chArray[3].ToString()) * 7;
                var num5 = Convert.ToInt32(chArray[4].ToString()) * 6;
                var num6 = Convert.ToInt32(chArray[5].ToString()) * 5;
                var num7 = Convert.ToInt32(chArray[6].ToString()) * 4;
                var num8 = Convert.ToInt32(chArray[7].ToString()) * 3;
                var num9 = Convert.ToInt32(chArray[8].ToString()) * 2;
                var a = Convert.ToInt32(chArray[9].ToString());

                var b = (((((((num0 + num2) + num3) + num4) + num5) + num6) + num7) + num8) + num9;
                var c = b % 11;
                return (((c < 2) && (a == c)) || ((c >= 2) && ((11 - c) == a)));
            }
            public static bool CheckEmpty(this string input)
            {
                try
                {
                    return input.Trim() == string.Empty;
                }
                catch (NullReferenceException)
                {
                    return false;
                }
            }
            public static bool CheckMobile(this string input, MobileOptional mobileOptional)
            {
                if (input.CheckEmpty()) return false;
                if (input.CheckNumeric() == false) return false;
                if (mobileOptional == MobileOptional.WithZero)
                {
                    if (input.StartsWith("0") == false || input.Length != 11)
                        return false;
                }
                if (mobileOptional == MobileOptional.WithOutZero)
                {
                    if (input.StartsWith("0") || input.Length != 10)
                        return false;
                }
                if (mobileOptional == MobileOptional.Both)
                {
                    if (input.Length < 10 || input.Length > 11)
                        return false;
                }
                return true;
            }


        }
    }

}
