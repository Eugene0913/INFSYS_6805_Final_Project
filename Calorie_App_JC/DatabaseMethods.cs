// Single class to handle database activities
// Will reduce need to reload connection details multiple times
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CalorieCounter
{
    class DatabaseMethods
    {

        // Expose connection string to other methods
        public string dbConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Mac\Home\Documents\UMSL\INFSYS_6805_C_Sharp\Projects\CalorieCounter\CalorieCounter.mdf;Integrated Security=True";
        }

        ///// Methods for user sign up /////
        public bool checkExistingUser(string email)
        {
            // Boolean return variable
            bool userExists = false;

            // Setup connection to CalorieCounter DB
            SqlConnection conn = new SqlConnection(dbConnectionString());

            // Setup SQL commands to check if user already exists
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT email from users WHERE email ='" + email + "'";
            cmd.Connection = conn;
            SqlDataReader reader;

            // Open connection
            conn.Open();

            // Query users table
            reader = cmd.ExecuteReader();

            // Read data returned - If user does not exist then insert data
            if (reader.Read())
            {
                if (email == reader.GetString(reader.GetOrdinal("email")))
                {
                    userExists = true;
                }
            }

            // Close connections
            reader.Close();
            cmd.Dispose();
            conn.Close();

            return userExists;
        }

        public void insertNewUser(string first_name, string last_name, string email, string password)
        {
            // Setup connection to CalorieCounter DB
            SqlConnection conn = new SqlConnection(dbConnectionString());

            // Setup SQL commands to check if user already exists
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO users (first_name, last_name, email, password) VALUES ('" +
                                   first_name + "','" + last_name + "','" + email + "','" + password + "')";
            cmd.Connection = conn;

            // Open connection
            conn.Open();

            // Execute insert
            cmd.ExecuteNonQuery();

            // Close connections
            cmd.Dispose();
            conn.Close();
        }
        ///// Methods for user sign up /////

        ///// Methods for user authentication /////
        public Tuple<bool, int> authenticateUser(string email, string password)
        {
            // Return variables
            bool userAuth = false;
            int userID = -1;

            // Setup connection to CalorieCounter DB
            SqlConnection conn = new SqlConnection(dbConnectionString());

            // Setup SQL commands and query
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT id, email, password FROM users WHERE email = '" + email + "'";
            cmd.Connection = conn;
            SqlDataReader reader;

            // Open connection
            conn.Open();

            // Execute insert
            reader = cmd.ExecuteReader();

            // Read data that was returned
            if (reader.Read())
            {
                // Evaluate Credentials again database values
                if (email == reader.GetString(reader.GetOrdinal("email")) &
                    password == reader.GetString(reader.GetOrdinal("password")))
                {
                    userAuth = true;
                    userID = reader.GetInt32(reader.GetOrdinal("id"));
                }
                else
                {
                    userAuth = false;
                }
            }

            return Tuple.Create(userAuth, userID);
        }
        ///// Methods for user authentication /////
        
        ///// Methods for Adding / Removing Food Items /////
        public string LoadFoodItems()
        {
            return "A";
        }

        public void addFoodItem(string foodCategory, string FoodItem)
        {

        }

        public void deleteFoodItem()
        {

        }

        ///// Methods for processing data for data visuals /////
        public void getChartData()
        {

        }

        public void getTableData()
        {

        }
    }
}
