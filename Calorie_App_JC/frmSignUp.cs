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

namespace CalorieCounter
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        // Clear text boxes when entered
        private void tbFirstName_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = "";
        }
        private void tbLastName_Click(object sender, EventArgs e)
        {
            tbLastName.Text = "";
        }
        private void tbEmail_Click(object sender, EventArgs e)
        {
            tbEmail.Text = "";
        }
        private void tbPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Text = "";
        }

        // Evaluate valid email on leave
        private void tbEmail_Leave(object sender, EventArgs e)
        {
            // Ensure valid email
            if(!System.Text.RegularExpressions.Regex.IsMatch(tbEmail.Text , @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                                                            + "@"
                                                                            + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$"))
            {
                MessageBox.Show("Please enter a valid email.");
                tbEmail.Text = "";
            }
        }

        // Capture new user data, evaluate if user already exists, and store in users table in Database 
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // Create new database object
            DatabaseMethods dbMethods = new DatabaseMethods();

            // Capture input user data
            String first_name = tbFirstName.Text;
            String last_name = tbLastName.Text;
            String email = tbEmail.Text;
            String password = tbPassword.Text;

            // Query db to check if user already exists
            if (dbMethods.checkExistingUser(email))
            {
                MessageBox.Show("Account already exists. Returning to Main Menu");
            }
            // Insert new user data if user does not exist
            else
            {
                dbMethods.insertNewUser(first_name, last_name, email, password);
                frmLogin.UserRequiresSignUp = false;
            }

            // Close form
            this.Close();
        }

        // Exit Form
        private void btnExit_Click(object sender, EventArgs e)
        {
            Program.runProgram = false;
            Application.Exit();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmLogin.UserRequiresSignUp = false;
            this.Close();
        }
    }
}