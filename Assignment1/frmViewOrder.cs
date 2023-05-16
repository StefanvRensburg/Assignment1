using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class frmViewOrder : Form
    {
        public frmViewOrder()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {

            frmNewOrder No = new frmNewOrder();
            
            this.Close();

           
            
        }
    }
}
