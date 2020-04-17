using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinalResultProcessingSystem
{
    public partial class newuserF : Form
    {
        public newuserF()
        {
            InitializeComponent();
        }

        private void submitB_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Database.dbConnect.Initialize();
            con.Open();
            if (tnameTB.Text == "" || deptCB.Text == "" || desigCB.Text == "" || usernameTB.Text == "" || passwordTB.Text == "")
            {
                MessageBox.Show("Empty field is not allow. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    AdminF AdminObj = new AdminF();
                    try
                    {
                        String selectQuery1 = "select password from master";
                        MySqlCommand command1 = new MySqlCommand(selectQuery1, con);
                        MySqlDataReader reader1 = command1.ExecuteReader();
                        reader1.Read();
                        AdminObj.masterPassword = Convert.ToString(reader1[0]);
                        con.Close();                        
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("Error in Database." + exp, "Database Error");
                    }
                    if (mpasswordTB.Text == AdminObj.masterPassword)
                    {
                        con.Open();
                        String insertQuery = "INSERT into teacher (t_name,department,designation,username,password) values('" + tnameTB.Text + "','" + deptCB.Text + "','" + desigCB.Text + "','" + usernameTB.Text + "','" + passwordTB.Text + "')";
                        MySqlCommand commandObj = new MySqlCommand(insertQuery, con);
                        commandObj.ExecuteNonQuery();
                        con.Close();
                        tnameTB.Text = "";
                        deptCB.Text = "";
                        desigCB.Text = "";   
                        usernameTB.Text = "";
                        passwordTB.Text = "";
                        mpasswordTB.Text = "";
                        MessageBox.Show("Id Creation Successful.");
                    }
                    else
                    {
                        mpasswordTB.Text = "";
                        mpasswordTB.Focus();
                        errorLabel.Show();
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Error: " + exp);
                }
            }
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            tnameTB.Text = "";
            deptCB.Text = "";
            desigCB.Text = "";
            usernameTB.Text = "";
            passwordTB.Text = "";
            mpasswordTB.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogInF aa = new LogInF();
            aa.Show();
            this.Hide();
        }

        private void exit1B_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToLower(e.KeyChar);
        }

        private void usernameTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void usernameTB_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            if (key == Keys.Space)
            {
                e.Handled = true;
            }
            base.OnKeyDown(e);
        }

        private void usernameTB_Leave(object sender, EventArgs e)
        {
            if (this.Text.Contains(" "))
            {
                MessageBox.Show("Don't accept Space in username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Focus();
            }
        }
    }
}
