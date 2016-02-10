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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void Login_Button_Click(object sender, EventArgs e)
        {
            MainClass mc = new MainClass();
            mc.OpenConnection();
            mc.AppLogin(UserNameTBox.Text, PasswordTBox.Text);
            try
            {
                if (MainClass.Flag == 1)
                {
                    new SignIn().Show();
                    mc.CloseConnection();
                    MainClass.Flag = 0;
                    this.Hide();
                }
                else if (MainClass.Flag == 2)
                {
                    new LoginChange().Show();
                    mc.CloseConnection();
                    MainClass.Flag = 0;
                    this.Hide();
                }
                else if (MainClass.Flag == 0)
                {
                    mc.CloseConnection();
                    MessageBox.Show("Please Check Your Login Details !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                mc.CloseConnection();
                MessageBox.Show(ex.Message);
            }
        }

    }
}
