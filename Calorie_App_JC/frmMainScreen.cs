using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCounter
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var frmAddItem = new frmAddItem();
            frmAddItem.Show();
        }

        private void btDeleteItem_Click(object sender, EventArgs e)
        {
            var frmDeleteItem = new frmDeleteItem();
            frmDeleteItem.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Program.runProgram = false;
            Application.Exit();
        }
    }
}
