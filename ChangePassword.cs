using Lab1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class ChangePassword : Form
    {
        private ActionsForm af;
        private User user;
        private Memory mem;

        public ChangePassword(ActionsForm af, User user, Memory mem)
        {
            InitializeComponent();
            this.af = af;
            this.user = user;
            this.mem = mem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            af.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pass = tbCurr.Text;

            if (user.Password.Equals(pass))
            {
                user.ChangePassword(tbNew.Text);
                mem.Update(user.Save());
                mem.WriteToFile();


                af.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Wrong Password", "ERR01");
            }
        }
    }
}
