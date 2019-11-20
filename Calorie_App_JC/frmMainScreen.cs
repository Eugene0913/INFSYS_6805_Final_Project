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
            // Create new database object
            DatabaseMethods dbMethods = new DatabaseMethods();

            // Assign datatset to chart's datasource
            chrtTrending.DataSource = dbMethods.GetChartDataOverall(userID).Tables[0];

            
        }

        private void LoadMenuTrending(int userID)
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
            // Create new database object
            DatabaseMethods dbMethods = new DatabaseMethods();

            dgvConsumptionData.DataSource = dbMethods.GetTableData(userID).Tables[0];
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var frmAddItem = new frmAddItem();
            frmAddItem.Show();
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

        private void cbTrending_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTrending.SelectedIndex)
            {
                case 0:
                    LoadOverallTrending(frmLogin.UserID);
                    break;
                case 1:
                    LoadMenuTrending(frmLogin.UserID);
                    break;
            }
        }
    }
}
