using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes
{
    public class Memory
    {
        private List<UserMemento> memory;
        private string filename = "users.txt";

        public Memory()
        {
            memory = new List<UserMemento>();

            try
            {
                String text;
                using (StreamReader sr = new StreamReader(filename))
                {
                    text = sr.ReadToEnd();
                }

                while (text.Length > 2)
                {
                    Add(UserMemento.Parse(text.Substring(0, text.IndexOf('\r'))));
                    text = text.Substring(text.IndexOf('\r') + 2);
                }

            }
            catch (IOException e)
            {

            }

        }

        public void Add(UserMemento userMemento)
        {
            memory.Add(userMemento);
        }

        public UserMemento GetByLogin(String login)
        {
            for (int i = 0; i < memory.Count; i++)
                if (memory[i].Login.ToUpper().Equals(login.ToUpper()))
                {
                    UserMemento um = memory[i];
                    //memory.Remove(um);
                    return um;
                }

            return null;
        }

        public void Delete(UserMemento um)
        {
            for (int i = 0; i < memory.Count; i++)
                if (memory[i].Login.ToUpper().Equals(um.Login.ToUpper()))
                {
                    UserMemento lum = memory[i];
                    memory.Remove(memory[i]);
                }
        }
        public void Update(UserMemento um)
        {
            Delete(um);
            Add(um);
        }

        public void WriteToFile()
        {
            File.Delete(filename);
            using (StreamWriter sw = new StreamWriter(filename, false))
            {
                foreach (var um in memory)
                    sw.WriteLine(um.ToString());
            }
        }

        public void readFromFile()
        {
            try
            {
                String text;
                using (StreamReader sr = new StreamReader(filename))
                {
                    text = sr.ReadToEnd();
                }

                while (text.Length > 4)
                {
                    Add(UserMemento.Parse(text.Substring(0, text.IndexOf('\r'))));
                    text = text.Substring(text.IndexOf('\n') + 1);
                }

            }
            catch (IOException e)
            {

            }
        }
    }
}
