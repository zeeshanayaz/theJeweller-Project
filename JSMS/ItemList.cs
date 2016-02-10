using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace JSMS
{
    public partial class ItemList : Form
    {
        MainClass mc = new MainClass();
        public ItemList()
        {
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            new CustomerDetail().Show();
            this.Hide();
        }

        private void ItemList_Load(object sender, EventArgs e)
        {
            mc.OpenConnection();
            try
            {
                mc.SqlQuery("Select * From Customer.Temp_Invoice");
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(mc.DbCommand);
                adp.Fill(dt);
                InvoiceTable.DataSource = dt;
                mc.CloseConnection();
            }
            catch(Exception exp)
            {
                mc.CloseConnection();
                MessageBox.Show(exp.Message);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
