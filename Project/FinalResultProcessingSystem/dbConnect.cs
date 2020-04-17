using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FinalResultProcessingSystem.Database
{
    class dbConnect
    {

        List<string> a = new List<string>();

        MySqlConnection connection = Initialize();
        //For initialize
        public static MySqlConnection Initialize()
        {
            MySqlConnection connection;
            string connectionString;

            string server = "localhost";
            string database = "final_result_processing_system";
            string uid = "root";
            string password = "";

            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);

            return connection;
        }


        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        //start of insert update delete function

        public void inupdel(string query, string success_message, string failed_Message)
        {

            connection.Open();
            try
            {
                DialogResult d = MessageBox.Show("Are you sure to do this action?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(success_message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message:" + ex.Message + failed_Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connection.Close();

            }

        }
        public void inupdel(String query, String message)
        {

            inupdel(query, message, "");

        }
        //end of insert update delete function


        public void Insert(string query)
        {

            inupdel(query, "Insertion is Complete.");
        }
        public void Insert(string query, string msg)
        {

            inupdel(query, msg);

        }

        //Update statement
        public void Update(string query)
        {
            inupdel(query, "Update is Successful.");
        }

        //Delete statement
        public void Delete(string query)
        {
            inupdel(query, "Deletion is complete.");
        }




        //For select from database
        public List<string> multi_select(String query)
        {

            a.Clear();

            connection.Open();

            try
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                //kreirati čitač podataka
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int col = dataReader.FieldCount;
                // MessageBox.Show(col.ToString());
                if (dataReader.Read())
                {
                    int i = 0;
                    while (i < col)
                    {

                        a.Add(dataReader.GetString(i));
                        i++;
                    }
                }
                dataReader.Close();

                connection.Close();
                return a;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message:" + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connection.Close();
                return a;
            }


        }
        //End select from database
    }
}
