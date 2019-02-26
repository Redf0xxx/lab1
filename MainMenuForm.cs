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
    public partial class MainMenuForm : Form
    {
        private Memory mem;
        private byte misses;

        public MainMenuForm()
        {
            InitializeComponent();
            mem = new Memory();
            misses = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            String login = tbLogin.Text;
            String password = tbPassword.Text;

            UserMemento um = mem.GetByLogin(login);
            
            if (um == null)
            {
                misses++;
                return;
            }

            if (um.Password.Equals(password))
            {
                misses = 0;
                mem.Add(um);
                User user = new User();
                user.Load(um);

                ActionsForm af = new ActionsForm(user, mem, this);
                Hide();
                af.ShowDialog();
            }
            else
            {
                misses++;
            }
        }

        private void MainMenuForm_MouseMove(object sender, MouseEventArgs e)
        {
            CheckProblem();
        }

        private void MainMenuForm_MouseDown(object sender, MouseEventArgs e)
        {
            CheckProblem();
        }

        private void btnLogIn_Paint(object sender, PaintEventArgs e)
        {
            CheckProblem();
        }


        private void CheckProblem()
        {
            if (misses >= 3)
            {
                MessageBoxButtons mbb = MessageBoxButtons.OK;
                MessageBox.Show("You are so Stupid!!!!", "Fatal Error", mbb);

                Application.Exit();
            }
        }

        private void btnLogIn_Enter(object sender, EventArgs e)
        {
            CheckProblem();
        }

        private void btnLogIn_Leave(object sender, EventArgs e)
        {
            CheckProblem();
        }
    }
}
