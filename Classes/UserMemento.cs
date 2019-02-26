using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes
{
    public class UserMemento
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public bool isAdmin { get; private set; }
        public bool isLocked { get; private set; }
        public bool isPassLimited { get; private set; }

        public UserMemento(string login, string password, bool isadmin, bool islocked, bool ispasslimited)
        {
            Login = login;
            Password = password;
            isAdmin = isadmin;
            isLocked = islocked;
            isPassLimited = ispasslimited;
        }
        public UserMemento() { }

        public override string ToString()
        {
            return String.Format("{0}|{1}|{2}|{3}|{4}", Login, Password, isAdmin, isLocked, isPassLimited);
        }

        public static UserMemento Parse(String obj)
        {
            UserMemento um = new UserMemento();

            um.Login = obj.Substring(0, obj.IndexOf('|'));
            String str = obj.Substring(obj.IndexOf('|') + 1);

            int i = str.IndexOf('|');
            um.Password = str.Substring(0, i);
            str = str.Substring(i + 1);

            i = str.IndexOf('|');
            um.isAdmin = Boolean.Parse(str.Substring(0, i));
            str = str.Substring(i + 1);

            i = str.IndexOf('|');
            um.isLocked = Boolean.Parse(str.Substring(0, i));
            str = str.Substring(i + 1);

            um.isPassLimited = Boolean.Parse(str.Substring(0, str.Length));

            return um;
        }

    }
}
