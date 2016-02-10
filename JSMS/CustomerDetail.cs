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
    public partial class CustomerDetail : Form
    {
        MainClass mc = new MainClass();
        public CustomerDetail()
        {
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            mc.OpenConnection();
            try
            {
               
            }
            catch(Exception exp)
            {
                mc.CloseConnection();
                MessageBox.Show(exp.Message);
            }
            new Invoice().Show();
            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
