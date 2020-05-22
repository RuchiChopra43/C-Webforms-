using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bulletin.Models;

namespace Bulletin
{
    public class Utility
    {
        public string CheckUsername(string username, string action)
        {
            User user = new User();

            if (username.Length == 0)
                return "Need a username!";
            else if (user.GetUsernames().Contains(username))
                if (action == "register")
                    return "username is already taken !";
                else
                    return "OK";
            else
                return "OK";

        }
        public string CheckPassword(string password)
        {
            if (password.Length == 0)
                return "Need a password !";
            else
                return "OK";
        }
        public string CheckName(string name)

        {
            if (name.Length == 0)
                return "Need a Name !";
            else
                return "OK";

        }

        public string CheckPassword(string password1, string password2)
        {
            if ((password1.Length == 0 && password2.Length == 0) ||
                (password1.Length == 0 && password2.Length != 0))
                return "pass1error";
            else if
                (password1.Length != 0 && password2.Length == 0)
                return "pass2error";
            else if
                (password1.Length != 0 && password2.Length != 0)
                if (password1 != password2)
                    return "pass1notpass2";
                else
                    return "OK";
            return "OK";
        }



    }

}
