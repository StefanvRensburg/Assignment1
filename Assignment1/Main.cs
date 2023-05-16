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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // sets the parent for the forms and displays the forms
            label1.SendToBack();
            pictureBox1.SendToBack();
            frmNewOrder No = new frmNewOrder();
            No.MdiParent = Main.ActiveForm;
            No.StartPosition = FormStartPosition.Manual;
            No.Location = new Point(0, 30);

            No.Show();
            

            frmViewOrder Vo = new frmViewOrder();
            Vo.MdiParent = Main.ActiveForm;
            Vo.StartPosition = FormStartPosition.Manual;
            Vo.Location = new Point(394,36);

            Vo.Show();
            
            
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SendToBack();
            label1.SendToBack();
            frmLogin Login = new frmLogin();
            Login.MdiParent = Main.ActiveForm;
            Login.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
