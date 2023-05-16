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
    public partial class frmLogin : Form
    {

        SqlConnection conn;
        SqlCommand command;
        
        SqlDataReader dataReader;
        

        


        public string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OneDrive\OneDrive - North-West University\2023\CMPG212\Assignments\Assignment1\Assignment1\BeetleCaf.mdf;Integrated Security=True";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           tbxPassword.UseSystemPasswordChar = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

              string Un, Pw;

              Un = tbxUsername.Text;
              Pw = tbxPassword.Text;

              conn = new SqlConnection(connectionstring);
              string sql = "SELECT * FROM Login WHERE  Username = '" + Un + " ' " + "AND Password = '" + Pw + "'";

            try
            {
                conn.Open();

                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();



                while (dataReader.Read())
                {
                    if (dataReader.GetValue(1).ToString() == "")
                    {
                        MessageBox.Show("invalid username or password");
                    }
                    else
                    {
                        this.Close();
                        frmStaff S = new frmStaff();
                        S.MdiParent = Main.ActiveForm;
                        S.Show();
                    }
                }


                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
                conn.Close();
            }











        }
    }
}
