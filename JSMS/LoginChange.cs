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
    public partial class LoginChange : Form
    {
        public LoginChange()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            MainClass mc = new MainClass();
            mc.OpenConnection();
            try
            {
                if (UserNameCheckBox.Checked && PasswordCheckBox.Checked)
                {
                    MainClass.Flag = 1;
                    mc.UpdateLoginDetails(UserNameBox.Text, PasswordBox.Text);
                }
                else if (UserNameCheckBox.Checked)
                {
                    MainClass.Flag = 2;
                    mc.UpdateLoginDetails(UserNameBox.Text, PasswordBox.Text = null);
                }
                else if (PasswordCheckBox.Checked)
                {
                    MainClass.Flag = 3;
                    mc.UpdateLoginDetails(UserNameBox.Text = null, PasswordBox.Text);
                }

                if (MainClass.Flag == 4)
                {
                    MessageBox.Show("UserName And Password Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mc.CloseConnection();
                    new LoginForm().Show();
                    MainClass.Flag = 0;
                    this.Hide();
                }
                else if (MainClass.Flag == 5)
                {
                    MessageBox.Show("UserName Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mc.CloseConnection();
                    new LoginForm().Show();
                    MainClass.Flag = 0;
                    this.Hide();
                }
                else if (MainClass.Flag == 6)
                {
                    MessageBox.Show("Password Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mc.CloseConnection();
                    new LoginForm().Show();
                    MainClass.Flag = 0;
                    this.Hide();
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

