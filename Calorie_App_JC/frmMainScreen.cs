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
            LoadOverallTrending(frmLogin.UserID);
            LoadDailyCalories(frmLogin.UserID);
            LoadTableData(frmLogin.UserID);
        }

        private void LoadOverallTrending(int userID)
        {

        }

        private void LoadDailyCalories(int userID)
        {
            // Create new database object
            DatabaseMethods dbMethods = new DatabaseMethods();

            /// Returned valued to tbDailyCals
            tbDailyCals.Text = dbMethods.GetDailyCalorieData(userID);
        }

        private void LoadTableData(int userID)
        {

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
