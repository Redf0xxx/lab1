using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes
{
    public class User
    {
        private static string punctuationmarks = ".,-;:/\\?!";

        private String login;
        private String password;
        public bool isAdmin { get;  set; }
        public bool isLocked { get;  set; }
        public bool isPassLimited { get;  set; }

        public String Login
        {
            get
            {
                return login;
            }
            set
            {
                //if (!(login.ToUpper().Equals("ADMIN") || isAdmin))
                    login = value;
            }
        }

        public String Password
        {
            get
            {
                return password;
            }
        }

        public User()
        {

        }

        public User(string login)
        {
            Login = login;
            password = "";
            isAdmin = false;
            isLocked = false;
            isPassLimited = false;
        }

        public void ChangePassword(string pass)
        {
            if (!isPassLimited)
                password = pass;
            else
            {
                bool isLatin = false;
                foreach (char c in pass)
                    if (((c >= '\u0041' && c <= '\u005a') || (c >= '\u0061' && c <= '\u007a')))
                        isLatin = true;
                bool isCyrillic = false;
                foreach (char c in pass)
                    if (((c >= '\u0410' && c <= '\u044F')))
                        isCyrillic = true;
                bool isPM = false;
                foreach (char c in pass)
                    foreach (char pm in punctuationmarks)
                        if (c == pm)
                            isPM = true;

                bool isValid = isPM && isCyrillic && isLatin;

                password = isValid ? pass : password;
            }
        }

        public UserMemento Save()
        {
            return new UserMemento(Login, password, isAdmin, isLocked, isPassLimited);
        }

        public void Load(UserMemento userMemento)
        {
            Login = userMemento.Login;
            password = userMemento.Password;
            isAdmin = userMemento.isAdmin;
            isLocked = userMemento.isLocked;
            isPassLimited = userMemento.isPassLimited;
        }

    }
}
