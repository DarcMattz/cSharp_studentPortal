using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;

namespace MySql
{
    public partial class Subject : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=;database=profile");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;

        public Subject()
        {
            InitializeComponent();
            DisplayData();
        }

        private void searchBy_TextChanged(object sender, EventArgs e)
        {
            search(searchBox.Text);
        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            search(searchBox.Text);
        }

        private void search(string value)
        {

            dataGridView1.Rows.Clear();

            string QUERY = "SELECT `id`, `code`, `description`, `unit` FROM `subjects`";

            /*if (searchBy.Text.Equals("ID"))
            {
                QUERY += " WHERE id LIKE '" + value + "%'";
            }*/

            if (searchBy.Text.Equals("CODE"))
            {
                QUERY += " WHERE code LIKE '%" + value + "%'";
            }
            if (searchBy.Text.Equals("DESCRIPTION"))
            {
                QUERY += " WHERE description LIKE '%" + value + "%'";
            }
            if (searchBy.Text.Equals("UNITS"))
            {
                QUERY += " WHERE unit LIKE '%" + value + "%'";
            }
            if (searchBy.Text.Equals("All"))
            {
                QUERY += " WHERE CONCAT_WS(code,description,unit) LIKE '%" + value + "%'";
            }
            conn.Open();
            cmd = new MySqlCommand(QUERY, conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            conn.Close();

        }

        private void DisplayData()
        {
            searchBy.Text = "All";
            conn.Open();
            dataGridView1.Rows.Clear();
            /*DataTable dt = new DataTable();*/
            cmd = new MySqlCommand("SELECT * FROM subjects", conn);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void ClearData()
        {
            idBox.Text = "";    
            code.Text = "";
            descript.Text = "";
            unit.Text = "0";
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnInsert.Enabled = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string id = idBox.Text;
            string cod = code.Text;
            string desc = descript.Text;
            string uni = unit.Text;

            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(cod) || string.IsNullOrWhiteSpace(desc))
            {
                MessageBox.Show("Please fill out all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (uni == "0")
            {
                MessageBox.Show("Unit value cannot be 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Check if a subject with the same code or description already exists
                conn.Open();
                using (MySqlCommand cmdCheck = new MySqlCommand("SELECT COUNT(*) FROM subjects WHERE code = @code OR description = @desc", conn))
                {
                    cmdCheck.Parameters.AddWithValue("@code", cod);
                    cmdCheck.Parameters.AddWithValue("@desc", desc);
                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("A subject with the same code or description already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Insert the new subject into the database
                        cmd = new MySqlCommand("INSERT INTO subjects (code, description, unit) VALUES (@code, @desc, @uni)", conn);
                        cmd.Parameters.AddWithValue("@code", cod);
                        cmd.Parameters.AddWithValue("@desc", desc);
                        cmd.Parameters.AddWithValue("@uni", uni);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Record Successfully Added", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayData();
                        ClearData();
                    }
                }
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String id = idBox.Text;
            String cod = code.Text;
            String desc = descript.Text;
            String uni = unit.Text;

            if (cod != "" || desc != "" || uni != "")
            {
                cmd = new MySqlCommand($"UPDATE subjects SET code='{cod}',description='{desc}',unit='{uni}' where id='{id}'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Successfully Updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select a Subject First", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String id = idBox.Text;

            if (id != "")
            {
                cmd = new MySqlCommand($"DELETE FROM subjects WHERE id='{id}'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record has been Deleted", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                idBox.Text = dataGridView1.SelectedCells[0].Value.ToString();
                code.Text = dataGridView1.SelectedCells[1].Value.ToString();
                descript.Text = dataGridView1.SelectedCells[2].Value.ToString();
                unit.Text = dataGridView1.SelectedCells[3].Value.ToString();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnInsert.Enabled = false;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearData();
        }
    }
}
