using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 33706956
// Stefan Janse van Rensburg

namespace Assignment1
{

    

    public partial class frmSpecial : Form
    {

       
        public string fSpecial { get; set; }
        public string fPrice { get; set; }

        public frmSpecial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // checks if the checkboxes are ticked and save data into public variables
            if (cbxYes.Checked)
            {
               
                fSpecial = cbxYes.Text;
                fPrice = tbxPrice.Text;
            }
            else if (cbxNo.Checked)
            {
               
                fSpecial = cbxNo.Text;
                fPrice = tbxPrice.Text;
            }
            else
            {
                MessageBox.Show("Please select if the Item is on special or not");
            }

            this.Close();
        }
    }
}
