using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LambdaExpressionRegex
{
    class isValid
    {
        public static bool checkFirstName(string s)
        {
            string regex = "^([A-Z][a-z]{2}[a-z]*)$";
            return Regex.IsMatch(s, regex);
        }
        public static bool checkLastName(string s)
        {
            string regex = "^([A-Z][a-z]{2}[a-z]*)$";
            return Regex.IsMatch(s, regex);
        }
        public static bool checkEmail(string s)
        {
            string regex = "^([A-Za-z]+)([.])([A-Za-z]*)([@])([A-Za-z]+)([.])([A-Za-z]+)([.]*)([A-Za-z]*)$";
            return Regex.IsMatch(s, regex);
        }
        public static bool checkMobile(string s)
        {
            string regex = "^[+][9][1][7-9][0-9]{9}$";//[+][9][1][" "][7-9][0-9]{9}$-->with space
            return Regex.IsMatch(s, regex);
        }
        public static bool checkPassword(string s)
        {
            string regex = "^([0-9a-zA-Z]{8})([a-zA-Z0-9]+)$";
            return Regex.IsMatch(s, regex);
        }
        public static bool checkPassword1(string s)
        {
            string regex = "(?=.*[A-Z])^[A-Za-z0-9]{8,}$";
            return Regex.IsMatch(s, regex);
        }
        public static bool checkPassword2(string s)
        {
            string regex = "(?=.*[A-Z])(?=.*[0-9])^[A-Za-z0-9]{8,}$";
            return Regex.IsMatch(s, regex);
        }
        public static bool checkPassword3(string s)
        {
            string regex = "(?=.*[A-Z])(?=.*[0-9])(?=.*[!@?$])^[A-Za-z0-9!@?$]{8,}$";
            return Regex.IsMatch(s, regex);
        }
    }
}
