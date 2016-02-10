using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace JSMS
{
    class MainClass
    {
        public DataTable SqlTable = new System.Data.DataTable();
        public static int Flag = 0, Item, Quantity, checkForPOS = 0;
        public static string Type, Material, Colour;
        public static decimal Weight, Size, Price;
        public static byte[] Img;
        public static List<Int32> item = new List<Int32>();
        public static List<Int32> quantity = new List<Int32>();
        public static List<string> type = new List<string>();
        public static List<string> material = new List<string>();
        public static List<string> colour = new List<string>();
        public static List<decimal> weight = new List<decimal>();
        public static List<decimal> size = new List<decimal>();
        public static List<decimal> price = new List<decimal>();
        public static List<object> Images = new List<object>();
        private SqlConnection Connection = new SqlConnection();
        public static string ConnectionString = "data source = ZEESHAN; initial catalog = TheJeweller;Integrated Security = true";
        public SqlCommand DbCommand = new SqlCommand();
        public SqlDataAdapter DtAdapter = new SqlDataAdapter();
        private DataSet SqlDataSet = new DataSet();


        public bool OpenConnection()                                                    //Open Connection Function
        {
            try
            {
                if (Connection.State == ConnectionState.Open) return true;
                Connection = new SqlConnection();
                Connection.ConnectionString = ConnectionString;
                Connection.Open();
                if (DbCommand == null)
                {
                    DbCommand = new SqlCommand();
                }
                if (Connection.State == ConnectionState.Open)
                {
                    DbCommand.Connection = Connection;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.Exception ee)
            {
                throw new System.Exception("Database:OpenConnection:" + ee.Message);
            }
        }

        public void CloseConnection()                                                   //Close Connection Function
        {
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
                DbCommand = null;
                DtAdapter = null;
                SqlDataSet = null;
                SqlTable = null;
            }
        }

        public void AppLogin(string UserName, String Password)                           //App Login Function
        {
            string Query = "Select User_Name,Password from Users.AppUsers";
            DbCommand = new SqlCommand(Query, Connection);
            DtAdapter = new SqlDataAdapter(DbCommand);
            SqlTable = new DataTable();
            DtAdapter.Fill(SqlTable);
            if (SqlTable.Rows.Count > 0)
            {
                if (UserName == SqlTable.Rows[0]["User_Name"].ToString() && Password == SqlTable.Rows[0]["Password"].ToString())
                {
                    MainClass.Flag = 1;
                }
                else if (UserName == SqlTable.Rows[1]["User_Name"].ToString() && Password == SqlTable.Rows[1]["Password"].ToString())
                {
                    MainClass.Flag = 2;
                }
            }
        }

        public void UpdateLoginDetails(String UserName, String Password)                 //App UpdateLoginDeatils Function
        {
            if (MainClass.Flag == 1)
            {
                string Query = "update Users.AppUsers set User_Name = '" + UserName + "', Password = '" + Password + "' where ID = 1";
                DbCommand = new SqlCommand(Query, Connection);
                DbCommand.ExecuteNonQuery();
                MainClass.Flag = 4;
            }
            else if (MainClass.Flag == 2)
            {
                string Query = "update Users.AppUsers set User_Name = '" + UserName + "' where ID = 1";
                DbCommand = new SqlCommand(Query, Connection);
                DbCommand.ExecuteNonQuery();
                MainClass.Flag = 5;
            }
            else if (MainClass.Flag == 3)
            {
                string Query = "update Users.AppUsers set Password = '" + Password + "' where ID = 1";
                DbCommand = new SqlCommand(Query, Connection);
                DbCommand.ExecuteNonQuery();
                MainClass.Flag = 6;
            }
        }

        public void SqlQuery(string query)                                              //SQL COMMAND TO RUN QUERY AND CONNECTION!!
        {
            DbCommand = new SqlCommand(query, Connection);
        }

        public void NonQueryExe()                                                       //tO EXECUTE NONQUERY  LIKE iNSERT, UPDATE , DELETE
        {
            DbCommand.ExecuteNonQuery();

        }
    }
}
