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
    public partial class Invoice : Form
    {
        MainClass mc = new MainClass();
        public Invoice()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            mc.OpenConnection();
            try
            {
                mc.SqlQuery("SELECT * FROM [Customer].[Temp_Invoice]");
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(mc.DbCommand);
                adp.Fill(dt);
                SelectedItemGridVeiw.DataSource = dt;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            mc.CloseConnection();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            mc.OpenConnection();
            try
            {
                string delTempTable = "DELETE Customer.Temp_Invoice";
                mc.SqlQuery(delTempTable);
                mc.NonQueryExe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mc.CloseConnection();
            this.Hide();
            new POS().Show();
            
        }
    }
}
