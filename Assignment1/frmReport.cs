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
            decimal Total;
            string sql = "SELECT Category,Name,Sales FROM Sales";

            command = new SqlCommand(sql, conn);

           
            

        }
    }
}
