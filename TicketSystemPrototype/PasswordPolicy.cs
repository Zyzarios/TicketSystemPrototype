using System;
using System.Text.RegularExpressions;

namespace TicketSystemPrototype.model.Model
{
    public class PasswordPolicy
    {
        public static bool StrongRegex(string Password)
        {
            int count = Regex.Matches(Password, "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#/$%/^&/*])(?=.{8,12})").Count;

            if (count == 0) return false;
            else return true;
            //return bool(count);
        }
    }

}