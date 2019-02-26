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
    public partial class ActionsForm : Form
    {
        private User user;
        private Memory mem;
        private MainMenuForm mmf;
             
        public ActionsForm(User user, Memory mem, MainMenuForm mmf)
        {
            InitializeComponent();
            this.user = user;
            this.mem = mem;
            this.mmf = mmf;
            lbName.Text = user.Login;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            mem.WriteToFile();
            mmf.Show();
            Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (!user.isAdmin)
            {
                MessageBox.Show("No rights", "Ошибка досттупа");
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!user.isAdmin)
            {
                MessageBox.Show("No rights", "Ошибка досттупа");
                return;
            }

        }

        private void btnCHangePass_Click(object sender, EventArgs e)
        {
            ChangePassword cpf = new ChangePassword(this, user, mem);
            Hide();
            cpf.ShowDialog();
        }
    }
}
