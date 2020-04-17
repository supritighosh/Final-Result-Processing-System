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
    public partial class LogInF : Form
    {
        public LogInF()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logB_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Database.dbConnect.Initialize();

            if (usernameTB.Text == "" || passwordTB.Text == "")
            {
                MessageBox.Show("The username or password you entered is empty.", "Entry Error");
                return;
            }

            con.Open();

            string query = "";
            if (adminRB.Checked)
                query = "SELECT `username`, `password` FROM `admin` WHERE `username`='" + usernameTB.Text + "' and `password` = '" + passwordTB.Text + "'";

            if (teacherRB.Checked)
                query = "SELECT `username`, `password` FROM `teacher` WHERE `username`='" + usernameTB.Text + "' and `password` ='" + passwordTB.Text + "'";

            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (adminRB.Checked)
                {
                    AdminF aa = new AdminF();
                    Cursor.Current = Cursors.WaitCursor;
                    aa.Visible = true;
                    this.Hide();
                    Cursor.Current = Cursors.Default;
                }
                if (teacherRB.Checked)
                {
                    Teacher.markF tf = new Teacher.markF();
                    tf.Visible = true;
                    this.Hide();
                }
            }

            else
            {
                MessageBox.Show("The username or password you entered is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            reader.Close();
            con.Close();
        }

        private void exit1B_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameLB_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newuserF n = new newuserF();
            n.Show();
            this.Hide();
        
        }

        private void teacherRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void usernameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToLower(e.KeyChar);
        }

        
    }
}
