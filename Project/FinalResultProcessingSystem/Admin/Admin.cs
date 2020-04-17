using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinalResultProcessingSystem
{
    public partial class AdminF : Form
    {
        public AdminF()
        {
            InitializeComponent();
        }

        private void AdminF_Load(object sender, EventArgs e)
        {
            MySqlConnection con = Database.dbConnect.Initialize();
            con.Open();
            string Sql = "select session from session";
            MySqlCommand cmd = new MySqlCommand(Sql, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sessionCB.Items.Add(dr[0]);
            }
        }
        
        private void mpasswordB_Click(object sender, EventArgs e)
        {
            changemasterpasswordGB.Show();
            newsessionGB.Hide();
        }

        private void upstuB_Click(object sender, EventArgs e)
        {
            FinalResultProcessingSystem.Admin.studentinfoF aa = new FinalResultProcessingSystem.Admin.studentinfoF();
            aa.Show();
            this.Hide();
        }

        private void newsessionB_Click(object sender, EventArgs e)
        {
            changemasterpasswordGB.Hide();
            newsessionGB.Show();
        }

        private void courseinfoB_Click(object sender, EventArgs e)
        {
            FinalResultProcessingSystem.Admin.courseinfoF aa = new FinalResultProcessingSystem.Admin.courseinfoF();
            aa.Show();
            this.Hide();
        }

        private void backB_Click(object sender, EventArgs e)
        {
            LogInF nn = new LogInF();
            nn.Show();
            this.Hide();
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void submit2B_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Database.dbConnect.Initialize();
            if (sessionTB.Text == "")
            {
                MessageBox.Show("Empty field is not allow,Please try again.");
                return;
            }
            con.Open();
            String sql = "INSERT into session (session) values('" + sessionTB.Text + "')";
            try
            {
                DialogResult d = MessageBox.Show("Are you sure to do this action?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully session inserted.", "Success");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message:" + ex.Message);
                con.Close();
            }
        }

        private void cancel2B_Click(object sender, EventArgs e)
        {
            newsessionGB.Hide();
        }

        public string masterPassword;
        private void submitB_Click(object sender, EventArgs e)
        {
            //MySqlConnection con = Database.dbConnect.Initialize();
            //con.Open();
            //try
            //{
            //    String selectQuery1 = "select password from admin";
            //    MySqlCommand command1 = new MySqlCommand(selectQuery1, con);
            //    MySqlDataReader reader1 = command1.ExecuteReader();
            //    reader1.Read();
            //    masterPassword = Convert.ToString(reader1[0]);
            //    con.Close();
            //}
            //catch (Exception exp)
            //{
            //    MessageBox.Show("Error in Database." + exp, "Database Error");
            //}

            //if (oldmpasswordTB.Text == "" || newmpasswordTB.Text == "" || cnewmpasswordTB.Text == "")
            //{
            //    MessageBox.Show("Please fill up all the field first.", "Entry Error");
            //}

            //else
            //{
            //    if (newmpasswordTB.Text == cnewmpasswordTB.Text)
            //    {
            //        if (oldmpasswordTB.Text.Equals(masterPassword))
            //        {
            //            masterPassword = newmpasswordTB.Text;
            //            MessageBox.Show("Master Password Has been Reset.", "Success");
            //            oldmpasswordTB.Text = "";
            //            newmpasswordTB.Text = "";
            //            cnewmpasswordTB.Text = "";
            //            try
            //            {
            //                con.Open();
            //                String updateQuery = "update master set password='" + masterPassword + "' where username = 'admin2'";
            //                MySqlCommand commandObj3 = new MySqlCommand(updateQuery, con);
            //                commandObj3.ExecuteNonQuery();
            //                con.Close();
            //            }
            //            catch (Exception exp)
            //            {
            //                MessageBox.Show("Database Error." + exp, "Database");
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Sorry! Entered Old master password Is Incorrect.", "Entry Error");
            //            oldmpasswordTB.Text = "";
            //            newmpasswordTB.Text = "";
            //            cnewmpasswordTB.Text = "";
            //            oldmpasswordTB.Focus();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Confirm Master Password Correctly.", "Entry Error");
            //        oldmpasswordTB.Text = "";
            //        newmpasswordTB.Text = "";
            //        cnewmpasswordTB.Text = "";
            //        oldmpasswordTB.Focus();
            //    }
            MySqlConnection con = Database.dbConnect.Initialize();
            con.Open();
            String sql = "";
            sql = "UPDATE master SET password='" + newmpasswordTB.Text + "' WHERE username = 'admin2' ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            try
            {
                DialogResult d = MessageBox.Show("Are you sure to do this action?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    MySqlCommand comd = new MySqlCommand(sql, con);
                    comd.ExecuteNonQuery();
                    MessageBox.Show("Successfully password updated.", "Success");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message:" + ex.Message);
                con.Close();
            }
                    
            
        }      

        private void cancelB_Click(object sender, EventArgs e)
        {
            changemasterpasswordGB.Hide();
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinalResultProcessingSystem.newuserF opn = new newuserF();
            opn.Show();
        }

        private void addStudentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinalResultProcessingSystem.Admin.studentinfoF opn = new Admin.studentinfoF();
            opn.Show();
        }

        private void addCourseInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinalResultProcessingSystem.Admin.courseinfoF opn = new Admin.courseinfoF();
            opn.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void sessionCB_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
 
        private void sessionTB_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
