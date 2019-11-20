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
        // Methods to construct queries
        // Expose connection string to other methods
        public string DBConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Mac\Home\Documents\UMSL\INFSYS_6805_C_Sharp\Projects\CalorieCounter\CalorieCounter.mdf;Integrated Security=True";
        }

        ///// Methods for user sign up /////
        public bool CheckExistingUser(string email)
        {
            // Boolean return variable
            bool userExists = false;

            // Setup connection to CalorieCounter DB
            SqlConnection conn = new SqlConnection(DBConnectionString());

            // Setup SQL commands to check if user already exists
            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "SELECT email from users WHERE email ='" + email + "'",
                Connection = conn
            };
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

        public void InsertNewUser(string first_name, string last_name, string email, string password)
        {
            // Setup connection to CalorieCounter DB
            SqlConnection conn = new SqlConnection(DBConnectionString());

            // Setup SQL commands to check if user already exists
            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "INSERT INTO users (first_name, last_name, email, password) VALUES ('" +
                                   first_name + "','" + last_name + "','" + email + "','" + password + "')",
                Connection = conn
            };

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
        public Tuple<bool, int> AuthenticateUser(string email, string password)
        {
            // Return variables
            bool userAuth = false;
            int userID = -1;

            // Setup connection to CalorieCounter DB
            SqlConnection conn = new SqlConnection(DBConnectionString());

            // Setup SQL commands and query
            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "SELECT id, email, password FROM users WHERE email = '" + email + "'",
                Connection = conn
            };
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

        ///// Methods for processing data for data visuals /////
        public DataSet GetChartDataOverall(int userID)
        {
            // Setup connection to CalorieCounter DB
            SqlConnection conn = new SqlConnection(DBConnectionString());

            // Setup SQL commands and query
            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = @"SELECT
                                CAST(meals_ref.created_at AS DATE) AS meal_date
                                ,SUM(foods.calories * meals_ref.quantity) AS total_calories
                                FROM
                                meals_ref
                                LEFT JOIN foods ON (foods.id = meals_ref.food_id)
                                WHERE
                                user_id = " + userID +
                                " GROUP BY CAST(meals_ref.created_at AS DATE)",
                Connection = conn
            };
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            // Define dataset
            DataSet ds = new DataSet();

            // Fill dataset with query results
            dAdapter.Fill(ds);

            return ds;
        }

        public void GetChartDataByMeal()
        {

        }

        public string GetDailyCalorieData(int userID)
        {
            // Setup connection to CalorieCounter DB
            SqlConnection conn = new SqlConnection(DBConnectionString());

            // Setup SQL commands and query
            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = @"SELECT
                                CAST(SUM(foods.calories * meals_ref.quantity) AS VARCHAR(10)) AS total_calories
                                FROM
                                meals_ref
                                LEFT JOIN foods ON(foods.id = meals_ref.food_id)
                                WHERE
                                user_id = " + userID +
                                " AND CAST(meals_ref.created_at AS DATE) = CAST(GETDATE() AS DATE)",
                Connection = conn
            };
            SqlDataReader reader;

            // Open connection
            conn.Open();

            // Execute insert
            reader = cmd.ExecuteReader();

            // Read data that was returned
            if (reader.Read() && !reader.IsDBNull(0))
            {
                return reader.GetString(reader.GetOrdinal("total_calories"));
            }
            else
            {
                return "0";
            }
        }

        public DataSet GetTableData(int userID)
        {
            // Setup connection to CalorieCounter DB
            SqlConnection conn = new SqlConnection(DBConnectionString());

            // Setup SQL commands and query
            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = @"SELECT
                                CAST(meals_ref.created_at AS DATE) AS meal_date
                                ,meal_type.meal_type
                                ,foods.category
                                ,foods.name
                                ,foods.calories
                                ,meals_ref.quantity
                                ,foods.calories * meals_ref.quantity AS total_calories
                                FROM
                                meals_ref
                                LEFT JOIN foods ON (foods.id = meals_ref.food_id)
                                LEFT JOIN meal_type ON (meal_type.id = meals_ref.meal_type_id)
                                WHERE
                                user_id = " + userID + 
                                @" ORDER BY
                                meals_ref.created_at,
                                CASE
                                WHEN meal_type.meal_type = 'Breakfast' THEN 1
                                WHEN meal_type.meal_type = 'Lunch' THEN 2
                                ELSE 3 END",
                Connection = conn
            };
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            // Define dataset
            DataSet ds = new DataSet();

            // Fill dataset with query results
            dAdapter.Fill(ds);

            return ds;
        }

        ///// Methods for Adding / Removing Food Items /////
        public string LoadFoodItems()
        {
            return "A";
        }

        public void AddFoodItem(string foodCategory, string FoodItem)
        {

        }

        public void deleteFoodItem()
        {

        }
    }
}
