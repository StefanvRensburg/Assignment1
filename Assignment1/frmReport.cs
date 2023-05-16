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

namespace Assignment1
{
    public partial class frmReport : Form
    {

        SqlConnection conn;
        SqlCommand command;
        SqlDataReader dataReader;

        private string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OneDrive\OneDrive - North-West University\2023\CMPG212\Assignments\Assignment1\Assignment1\BeetleCaf.mdf;Integrated Security=True";
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            decimal Total = 0;
            string sql = "SELECT Category,Name,Sales FROM Sales";

            

            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();

                lbxReports.Items.Add("Category \t\t Name \t\t Sales");
                lbxReports.Items.Add("=====================================================================================");

                while(dataReader.Read())
                {
                    lbxReports.Items.Add(dataReader.GetValue(1) + "\t\t" + dataReader.GetValue(2) + "\t\t" + dataReader.GetValue(3).ToString());
                    Total = Total + Convert.ToDecimal(dataReader.GetValue(5));
                }
                lbxReports.Items.Add("\n\nTotal Profit: " + Total.ToString());

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
                conn.Close();
            }
            

        }
    }
}
