using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySql
{
    public partial class Enrollment : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=;database=profile");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapt = new MySqlDataAdapter();
        public Enrollment()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("SELECT * FROM student", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void ClearData()
        {
            studId.Text = "";
            studName.Text = "";
            studCourse.Text = "";

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            String name = studName.Text;
            String course = studCourse.Text;

            MySqlCommand cmd1 = new MySqlCommand($"SELECT * FROM student WHERE studname = '{name}'", conn);
            conn.Open();
            bool isRegistered = false;
            using (var dr1 = cmd1.ExecuteReader())
                if (isRegistered = dr1.HasRows)
                    MessageBox.Show("This Student is Already Registered!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            conn.Close();
            if (!isRegistered)
            {
                if (name != "" || course != "")
                {
                    cmd = new MySqlCommand($"INSERT INTO student(studname,studprog) VALUES('{name}','{course}')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Successfully Added", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Fill out all the information needed first", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String id = studId.Text;
            String name = studName.Text;
            String course = studCourse.Text;

            if (id != "" || name != "" || course != "")
            {
                cmd = new MySqlCommand($"UPDATE student SET studname='{name}',studprog='{course}' where studid='{id}'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Successfully Updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select a Record First", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String id = studId.Text;
            String name = studName.Text;
            String course = studCourse.Text;

            if (id != "")
            {
                cmd = new MySqlCommand($"DELETE FROM student WHERE studid='{id}'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Successfully Updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select a Record First", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            studId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            studName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            studCourse.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
