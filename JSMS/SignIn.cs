using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSMS
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void Main_Timer_Tick(object sender, EventArgs e)
        {
            if (Program.con == 16)
            {
                SigningInLabel.Text = "Signing in.";
                Program.con = 2;
            }
            else if (Program.con == 2)
            {
                SigningInLabel.Text = "Signing in..";
                Program.con++;
            }
            else if (Program.con == 3)
                {
                    SigningInLabel.Text = "Signing in...";
                    Program.con++;
                }
            else if (Program.con == 4)
                {
                    SigningInLabel.Text = "Signing in.";
                    Program.con++;
                }
             else if (Program.con == 5)
                {
                    SigningInLabel.Text = "Signing in..";
                    Program.con++;
                }
             else if (Program.con == 6)
                {
                    SigningInLabel.Text = "Signing in...";
                    Program.con++;
                }
            else if (Program.con == 7)
            {
                SigningInLabel.Text = "Signing in.";
                Program.con++;
            }
            else if (Program.con == 8)
            {
                SigningInLabel.Text = "Signing in..";
                Program.con++;
            }
            else if (Program.con == 9)
            {
                SigningInLabel.Text = "Signing in...";
                Program.con++;
            }
              else if (Program.con == 10)
                {
                    Main_Timer.Stop();
                    this.Hide();
                    new POS().Show();
                }
            }

        private void SigningInLabel_Click(object sender, EventArgs e)
        {

        }
        }
    }

