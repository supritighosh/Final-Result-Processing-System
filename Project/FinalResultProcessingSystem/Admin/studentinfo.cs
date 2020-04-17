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
    public partial class studentinfoF : Form
    {
        public studentinfoF()
        {
            InitializeComponent();
        }

        private void updatestudent_Load(object sender, EventArgs e)
        {
            MySqlConnection con = Database.dbConnect.Initialize();
            Database.info il = new Database.info();
            il.datagridview_load("SELECT class_roll as 'Class Roll', exam_roll as 'Exam Roll', name as 'Name', session as 'Session', gender as 'Gender', hall as 'Hall', email as 'Email', phone as 'Phone' FROM student", stuDGV);
            con.Open();
            string Sql = "select * from session";
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
            if (searchrollTB.Text == "" || session2CB.Text == "")
            {
                MessageBox.Show("Enter class roll ");
                return;
            }
            con.Open();
            String sql = "";
            sql = "SELECT * FROM student WHERE session = '"+session2CB.Text +"' and class_roll='" + searchrollTB.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                crTB.Text = reader.GetValue(0).ToString();
                erTB.Text = reader.GetValue(1).ToString();
                nameTB.Text = reader.GetValue(2).ToString();
                sessionCB.Text = reader.GetValue(3).ToString();
                genderCB.Text = reader.GetValue(4).ToString();
                hallTB.Text = reader.GetValue(5).ToString();
                mailTB.Text = reader.GetValue(6).ToString();
                phoneTB.Text = reader.GetValue(7).ToString();
                searchB.Enabled = true;
            }
            else
            {
                MessageBox.Show("No class roll find ");
            }
            con.Close();
            session2CB.Text = "";
            searchrollTB.Text = "";
        }

        private void addB_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Database.dbConnect.Initialize();
            if (crTB.Text == "" || erTB.Text == "" || nameTB.Text == "" || sessionCB.Text == "" || genderCB.Text == "" || hallTB.Text == "" || mailTB.Text == "" || phoneTB.Text == "")
            {
                MessageBox.Show("Empty field is not allow. Please try again.");
                return;
            }
            con.Open();
            this.testDatabaseExists();
            String sql = "INSERT into student (class_roll, exam_roll, name, session, gender, hall, email, phone) values('" + crTB.Text + "','" + erTB.Text + "','" + nameTB.Text + "','" + sessionCB.Text + "','" + genderCB.Text + "', '" + hallTB.Text + "', '" + mailTB.Text + "', '" + phoneTB.Text + "')";
            try
            {
                DialogResult d = MessageBox.Show("Are you sure to insert data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message:" + ex.Message);
                con.Close();
            }
            

            Database.info il = new Database.info();
            il.datagridview_load("SELECT class_roll as 'Class Roll', exam_roll as 'Exam Roll', name as 'Name', session as 'Session', gender as 'Gender' FROM student, hall as 'Hall', email as 'Email', phone as 'Phone' from student", stuDGV);
            crTB.Text = "";
            erTB.Text = "";
            nameTB.Text = "";
            sessionCB.Text = "";
            genderCB.Text = "";
            hallTB.Text = "";
            mailTB.Text = "";
            phoneTB.Text = "";
        }

        private void updateB_Click(object sender, EventArgs e)
        {
            String classroll = crTB.Text;
            String examroll = erTB.Text;
            String name = nameTB.Text;
            String ses = sessionCB.Text;
            String gender = genderCB.Text;
            
            MySqlConnection con = Database.dbConnect.Initialize();
            con.Open();
            String sql = "";
            sql = "UPDATE student SET class_roll='" + classroll + "', exam_roll='" + examroll + "', name='" + name + "', session='" + ses + "', gender='" + gender + "', hall = '" + hallTB.Text + "', email = '" + mailTB.Text + "', phone = '" + phoneTB.Text + "' WHERE `class_roll`='" + classroll + "' and session = '" + ses + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            try
            {
                DialogResult d = MessageBox.Show("Are you sure to update data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            il.datagridview_load("SELECT class_roll as 'Class Roll', exam_roll as 'Exam Roll', name as 'Name', session as 'Session', gender as 'Gender', hall as 'Hall', email as 'Email', phone as 'Phone' FROM student", stuDGV);
            crTB.Text = "";
            erTB.Text = "";
            nameTB.Text = "";
            sessionCB.Text = "";
            genderCB.Text = "";
            hallTB.Text = "";
            mailTB.Text = "";
            phoneTB.Text = "";
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Database.dbConnect.Initialize();
            con.Open();
            String sql = "";
            sql = "delete from student WHERE `class_roll`='" + crTB.Text + "' and session = '"+sessionCB.Text+"'" ;
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
            il.datagridview_load("SELECT class_roll as 'Class Roll', exam_roll as 'Exam Roll', name as 'Name', session as 'Session', gender as 'Gender', hall as 'Hall', email as 'Email', phone as 'Phone' FROM student", stuDGV);
            crTB.Text = "";
            erTB.Text = "";
            nameTB.Text = "";
            sessionCB.Text = "";
            genderCB.Text = "";
            hallTB.Text = "";
            mailTB.Text = "";
            phoneTB.Text = "";
        }

        private void backB_Click(object sender, EventArgs e)
        {
            AdminF aa = new AdminF();
            aa.Show();
            this.Hide();
        }      

        private void clearB_Click(object sender, EventArgs e)
        {
            crTB.Text = "";
            erTB.Text = "";
            nameTB.Text = "";
            sessionCB.Text = "";
            genderCB.Text = "";
            hallTB.Text = "";
            mailTB.Text = "";
            phoneTB.Text = "";
        }
        
        private void testDatabaseExists()
        {
            MySqlConnection con = Database.dbConnect.Initialize();
            String sql = "select * from student where class_roll = '" + crTB.Text + "' and session = '" + sessionCB.Text + "'";
            Boolean bRet;
            MySqlCommand cmd = new MySqlCommand(sql, con);
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
           
            } //END OF IF


        } //END FUNCTION

        private void stuDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void session2CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
