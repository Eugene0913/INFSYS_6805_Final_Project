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
    public partial class frmAddItem : Form
    {
        public frmAddItem()
        {
            InitializeComponent();
            // This will load food categories on form render
            LoadFoodCategories();
        }

        // Load food categories
        private void LoadFoodCategories()
        {
            DatabaseMethods dbMethods = new DatabaseMethods();

            cbFoodCategories.DataSource = dbMethods.LoadFoodCategories().Tables["category"];
            cbFoodCategories.DisplayMember = "Food Category";
            cbFoodCategories.ValueMember = "category";
        }

        private void cbFoodCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This will load foods when a given category is selected

        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            // ^[0-9]*$
            // Check to make sure only numbers were entered
            if (!System.Text.RegularExpressions.Regex.IsMatch(tbQuantity.Text, @"^[0-9]*$"))
            {
                MessageBox.Show("Please enter valid number");
                tbQuantity.Text = "";
            }

        }

        private void btnAddFoodItem_Click(object sender, EventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
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
