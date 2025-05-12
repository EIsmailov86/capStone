using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace JEM
{
    public static class InputValidator
    {
        //name: letters, spaces, hyphens, apostrophes; 1–50 characters.
        public static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length > 50)
                return false;
            // Unicode letters, spaces, hyphens, apostrophes
            return Regex.IsMatch(name, @"^[\p{L}\s\-']+$");
        }

        //username: alphanumeric and underscore; 2–50 characters.
        public static bool IsValidUserName(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return false;
            return Regex.IsMatch(username, @"^[A-Za-z0-9_]{2,50}$");
        }

        // email address using MailAddress parser and length check.
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || email.Length > 50)
                return false;
            try
            {
                var addr = new MailAddress(email);
                //optionally enforce domain rules here
                return true;
            }
            catch
            {
                return false;
            }
        }

        //phone number: digits, spaces, parentheses, plus, hyphens
        public static bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone) || phone.Length < 7 || phone.Length > 50)
                return false;
            return Regex.IsMatch(phone, @"^[0-9\-\+\(\)\s]+$");
        }

 
        //address: letters, numbers, spaces, comma, period, hyphen
        public static bool IsValidAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address) || address.Length > 100)
                return false;
            return Regex.IsMatch(address, @"^[\p{L}0-9\s\-,.]+$");
        }

        //bio: letters, numbers, common punctuation, whitespace, no angle brackets.
        public static bool IsValidBio(string bio)
        {
            if (bio == null)
                return true; // optional field
            if (bio.Length > 5000)
                return false;
            // disallow HTML-like angle brackets to prevent basic injection
            if (bio.Contains("<") || bio.Contains(">"))
                return false;
            return Regex.IsMatch(bio, @"^[\p{L}0-9\s\.,'""!?;:\-()]+$");
        }

        //password strength
        public static bool IsValidPasswordRequirement(string password)
        {
            // at least 6 chars, and only letters, digits, or underscore
            if (string.IsNullOrEmpty(password) || password.Length < 6)
                return false;

            return Regex.IsMatch(password, @"^[A-Za-z0-9_]+$");
        }
    }
}

