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
    public partial class frmLogin : Form
    {
        // Setup boolean for user sign up if they are new
        public static bool UserRequiresSignUp {get; set; }
        
        // Setup boolean for successful authentication
        public static bool UserSuccessfullyAuthenticated { get; set; }

        // Setup UserID variable to pass back through 
        public static int UserID { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UserRequiresSignUp = true;
            this.Close();
        }
        private void tbLoginEmail_Click(object sender, EventArgs e)
        {
            tbLoginEmail.Text = "";
        }
        private void tbLoginEmail_Leave(object sender, EventArgs e)
        {
            // Ensure valid email
            if (!System.Text.RegularExpressions.Regex.IsMatch(tbLoginEmail.Text, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                                                                 + "@"
                                                                                 + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$"))
            {
                MessageBox.Show("Please enter a valid email.");
                tbLoginEmail.Text = "";
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Create new database object
            DatabaseMethods dbMethods = new DatabaseMethods();

            // Capture login credentials
            string loginEmail = tbLoginEmail.Text;
            string loginPassword = tbLoginPassword.Text;

            Tuple<bool, int> userAuthReturns = dbMethods.AuthenticateUser(loginEmail, loginPassword);

            // Authenticate user
            if (userAuthReturns.Item1)
            {
                // Update global variable
                UserSuccessfullyAuthenticated = true;

                // Capture user id for loading main screen
                UserID = userAuthReturns.Item2;

                this.Close();
            }
            else
            {
                MessageBox.Show("Username or Password is wrong. Try Again.");
                tbLoginEmail.Text = "";
                tbLoginPassword.Text = "";
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Program.runProgram = false;
            Application.Exit();
        }
    }
}