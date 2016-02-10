using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace JSMS
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if (Program.con == 1)
            {
                ConnectivityInfo.Text = "Gathering required information...";
                Program.con++;
            }
            else if (Program.con == 2)
            {
                ConnectivityInfo.Text = "Required information gathered successfully.";
                Program.con++;
            }
            else if (Program.con == 3)
            {
                ConnectivityInfo.Text = "Verifying the gathered information...";
                Program.con++;
            }
            else if (Program.con == 4)
            {
                ConnectivityInfo.Text = "Verified Successfully.";
                Program.con++;
            }
            else if (Program.con == 5)
            {
                ConnectivityInfo.Text = "Creating Database...";
                Program.con++;
            }
            else if (Program.con == 6)
            {
                ConnectivityInfo.Text = "Database created Successfully";
                Program.con++;
            }
            else if (Program.con == 7)
            {
                ConnectivityInfo.Text = "Checking the database for errors...";
                Program.con++;
            }
            else if (Program.con == 8)
            {
                ConnectivityInfo.Text = "No errors found";
                Program.con++;
            }
            else if (Program.con == 9)
            {
                ConnectivityInfo.Text = "Gathering required resources...";
                Program.con++;
            }
            else if (Program.con == 10)
            {
                ConnectivityInfo.Text = "Resources gathered successfully";
                Program.con++;
            }
            else if (Program.con == 11)
            {
                ConnectivityInfo.Text = "Verifying the database tables...";
                Program.con++;
            }
            else if (Program.con == 12)
            {
                ConnectivityInfo.Text = "Successfully verified";
                Program.con++;
            }
            else if (Program.con == 13)
            {
                ConnectivityInfo.Text = "Establishing connection to database...";
                Program.con++;
            }
            else if (Program.con == 14)
            {
                ConnectivityInfo.Text = "Connected successfully";
                Program.con++;
            }
            else if (Program.con == 15)
            {
                ConnectivityInfo.Text = "Please wait...";
                Program.con++;
            }
            else if (Program.con == 16)
            {
                MainTimer.Stop();
                this.Hide();
                new LoginForm().Show();
            }

        }
    }
}
