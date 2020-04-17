using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinalResultProcessingSystem.Admin
{
    public partial class courseinfoF : Form
    {
        public courseinfoF()
        {
            InitializeComponent();
        }

        private void courseinfo_Load(object sender, EventArgs e)
        {
            MySqlConnection con = Database.dbConnect.Initialize();
            Database.info il = new Database.info();
            il.datagridview_load("SELECT course_code as 'Course Code', course_title as 'Course Title', course_credit as 'Course Credit', course as 'Course Type', session as 'Session', year as 'Year', semester as 'semester' FROM course", courseDGV);
            con.Open();
            string Sql = "select session from session";
            MySqlCommand cmd = new MySqlCommand(Sql, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sessionCB.Items.Add(dr[0]);
                session2CB.Items.Add(dr[0]);
            }    
        }

        private void searchB_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Database.dbConnect.Initialize();
            if (searchccodeTB.Text == "" || session2CB.Text == "")
            {
                //MessageBox.Show("Enter Course Code.");
                return;
            }
            con.Open();
            String sql = "";
            sql = "select * from course where session = '" + session2CB.Text + "' and course_code='" + searchccodeTB.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                ccodeTB.Text = reader.GetValue(0).ToString();
                ctitleTB.Text = reader.GetValue(1).ToString();
                ccreditCB.Text = reader.GetValue(2).ToString();
                cTB.Text = reader.GetValue(3).ToString();
                sessionCB.Text = reader.GetValue(4).ToString();
                yearCB.Text = reader.GetValue(5).ToString();
                semCB.Text = reader.GetValue(6).ToString();
                searchB.Enabled = true;
            }
            else
            {
                MessageBox.Show("No course code fine.");
            }
            con.Close();
            session2CB.Text = "";
            searchccodeTB.Text = "";
        }

        private void addB_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Database.dbConnect.Initialize();
            if (ccodeTB.Text == "" || ctitleTB.Text == "" || ccreditCB.Text == "" || cTB.Text == "" || sessionCB.Text == "" || yearCB.Text == "" || semCB.Text == "")
            {
                MessageBox.Show("Empty field is not allow,Please try again.");
                return;
            }
            con.Open();
            this.testDatabaseExists();
            String sql = "insert into course (course_code, course_title, course_credit, course, session, year, semester) values('" + ccodeTB.Text + "','" + ctitleTB.Text + "','" + ccreditCB.Text + "', '" + cTB.Text + "','" + sessionCB.Text + "','" + yearCB.Text + "', '" + semCB.Text + "')";
            try
            {
                DialogResult d = MessageBox.Show("Are you sure to insert data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully data inserted.", "Success");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message:" + ex.Message);
                con.Close();
            }
            Database.info il = new Database.info();
            il.datagridview_load("SELECT course_code as 'Course Code', course_title as 'Course Title', course_credit as 'Course Credit', course as 'Course Type', session as 'Session', year as 'Year', semester as 'Semester' FROM course", courseDGV);
            ccodeTB.Text = "";
            ctitleTB.Text = "";
            ccreditCB.Text = "";
            cTB.Text = "";
            sessionCB.Text = "";
            yearCB.Text = "";
            semCB.Text = "";
        }

        private void updateB_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Database.dbConnect.Initialize();
            con.Open();
            String sql = "";
            sql = "UPDATE course SET course_code='" + ccodeTB.Text + "', course_title='" + ctitleTB.Text + "', course_credit='" + ccreditCB.Text + "', course='" + cTB.Text + "', session='" + sessionCB.Text + "', year='" + yearCB.Text + "', semester = '" + semCB.Text + "' WHERE course_code='" + ccodeTB.Text + "' and session = '" + sessionCB.Text + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            try
            {
                DialogResult d = MessageBox.Show("Are you sure to upadte data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    MySqlCommand comd = new MySqlCommand(sql, con);
                    comd.ExecuteNonQuery();
                    MessageBox.Show("Successfully data updated.", "Success");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message:" + ex.Message);
                con.Close();
            }
            Database.info il = new Database.info();
            il.datagridview_load("SELECT course_code as 'Course Code', course_title as 'Course Title', course_credit as 'Course Credit', course as 'Course Type', session as 'Session', year as 'Year', semester as 'Semester' FROM course", courseDGV);
            ccodeTB.Text = "";
            ctitleTB.Text = "";
            ccreditCB.Text = "";
            cTB.Text = "";
            sessionCB.Text = "";
            yearCB.Text = "";
            semCB.Text = "";
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            String ccode = ccodeTB.Text;
            String ctitle = ctitleTB.Text;
            String ccredit = ccreditCB.Text;
            String c = cTB.Text;
            String session = sessionCB.Text;
            String sem = yearCB.Text;
            String search_code_str = searchccodeTB.Text;
            MySqlConnection con = Database.dbConnect.Initialize();
            con.Open();
            String sql = "";
            sql = "delete from course WHERE `course_code`='" + ccode + "' and session = '"+session+"'"; ;
            MySqlCommand cmd = new MySqlCommand(sql, con);
            try
            {
                DialogResult d = MessageBox.Show("Are you sure to delete data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    MySqlCommand comd = new MySqlCommand(sql, con);
                    comd.ExecuteNonQuery();
                    MessageBox.Show("Successfully data deleted.", "Success");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message:" + ex.Message);
                con.Close();
            }
            Database.info il = new Database.info();
            il.datagridview_load("SELECT course_code as 'Course Code', course_title as 'Course Title', course_credit as 'Course Credit', course as 'Course Type', session as 'Session', year as 'Year', semester as 'Semester' FROM course", courseDGV);
            ccodeTB.Text = "";
            ctitleTB.Text = "";
            ccreditCB.Text = "";
            cTB.Text = "";
            sessionCB.Text = "";
            yearCB.Text = "";
            semCB.Text = "";
        }

        private void backB_Click(object sender, EventArgs e)
        {
            AdminF aa = new AdminF();
            aa.Show();
            this.Hide();
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            ccodeTB.Text = "";
            ctitleTB.Text = "";
            ccreditCB.Text = "";
            cTB.Text = "";
            sessionCB.Text = "";
            yearCB.Text = "";
            semCB.Text = "";
        }

        private void testDatabaseExists()
        {
            MySqlConnection con = Database.dbConnect.Initialize();
            String sql = "select * from course where course_code = '" + ccodeTB.Text + "' and session = '" + sessionCB.Text + "'";
            Boolean bRet;
            MySqlCommand cmd = new MySqlCommand (sql, con);
            try
            {
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                bRet = dr.HasRows;
                con.Close();
            }
            catch (Exception e) 
            {
                bRet = false;
                con.Close();
                MessageBox.Show(e.Message);
                //return false;
            } //End Try Catch Block
            if (bRet == true)
            {
                MessageBox.Show("Database exists");
                //return true;
            }
            else
            {
                //MessageBox.Show("Database exists");
                //return false;
            } //END OF IF

            
        }

        private void courseDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        } //END FUNCTION
    }
}
