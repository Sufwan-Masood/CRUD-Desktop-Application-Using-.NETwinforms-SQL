using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;

namespace CRUD_WINFORM_APP
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "ID is mandatory Field");
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "NAME is mandatory Field");
            }
            else if (string.IsNullOrEmpty(comboBox1.Text))
            {
                comboBox1.Focus();
                errorProvider1.SetError(comboBox1, "GENDER is mandatory Field");
            }
            else if (string.IsNullOrEmpty(numericUpDown1.Text))
            {
                numericUpDown1.Focus();
                errorProvider1.SetError(numericUpDown1, "AGE is mandatory Field");
            }
            else if (string.IsNullOrEmpty(comboBox2.Text))
            {
                comboBox2.Focus();
                errorProvider1.SetError(comboBox2, "DESIGNATION is mandatory Field");
            }
            else if (string.IsNullOrEmpty(textBox6.Text))
            {
                textBox6.Focus();
                errorProvider1.SetError(textBox6, "SALARY is mandatory Field");
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "insert into info values ( @id,@name,@gender,@age,@designation,@salary)";
                SqlCommand cmd = new SqlCommand(query, con);
                string query2 = "select * from info where Id = @id";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("@id", textBox1.Text);
                con.Open();
                SqlDataReader dr = cmd2.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show($"Violation of Primary Key Attribute ID {textBox1.Text} already exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
                else
                {
                    con.Close();
                    cmd.Parameters.AddWithValue("@id", textBox1.Text);
                    cmd.Parameters.AddWithValue("@name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@gender", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@age", Convert.ToInt32(numericUpDown1.Text.ToString()));
                    cmd.Parameters.AddWithValue("@designation", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@salary", textBox6.Text);
                    con.Open();
                    int nq = cmd.ExecuteNonQuery();
                    if (nq > 0)
                    {
                        MessageBox.Show("DATA INSERTED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlDataBinding();
                    }
                    else
                    {
                        MessageBox.Show("DATA INSERTION ERROR ", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    con.Close();
                }
            }



        }
        private void SqlDataBinding()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from info;";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Visible = true;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                numericUpDown1.Value = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch
            {
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataBinding();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "ID is mandatory Field");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "NAME is mandatory Field");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                comboBox1.Focus();
                errorProvider1.SetError(comboBox1, "GENDER is mandatory Field");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void numericUpDown1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numericUpDown1.Text))
            {
                numericUpDown1.Focus();
                errorProvider1.SetError(numericUpDown1, "AGE is mandatory Field");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox2.Text))
            {
                comboBox2.Focus();
                errorProvider1.SetError(comboBox2, "DESIGNATION is mandatory Field");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                textBox6.Focus();
                errorProvider1.SetError(textBox6, "SALARY is mandatory Field");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "ID is mandatory Field");
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "NAME is mandatory Field");
            }
            else if (string.IsNullOrEmpty(comboBox1.Text))
            {
                comboBox1.Focus();
                errorProvider1.SetError(comboBox1, "GENDER is mandatory Field");
            }
            else if (string.IsNullOrEmpty(numericUpDown1.Text))
            {
                numericUpDown1.Focus();
                errorProvider1.SetError(numericUpDown1, "AGE is mandatory Field");
            }
            else if (string.IsNullOrEmpty(comboBox2.Text))
            {
                comboBox2.Focus();
                errorProvider1.SetError(comboBox2, "DESIGNATION is mandatory Field");
            }
            else if (string.IsNullOrEmpty(textBox6.Text))
            {
                textBox6.Focus();
                errorProvider1.SetError(textBox6, "SALARY is mandatory Field");
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = @"update info 
                                set id = @id, _Name = @name , Gender = @gender , Age = @age , Salary = @salary , designation = @designation
                                where Id = @id;";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@gender", comboBox1.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(numericUpDown1.Text.ToString()));
                cmd.Parameters.AddWithValue("@designation", comboBox2.Text);
                cmd.Parameters.AddWithValue("@salary", textBox6.Text);
                con.Open();
                int nq = cmd.ExecuteNonQuery();
                if (nq > 0)
                {
                    MessageBox.Show($"Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SqlDataBinding();
                }
                else
                {
                    MessageBox.Show($" Error !", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "ID is mandatory Field");
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "NAME is mandatory Field");
            }
            else if (string.IsNullOrEmpty(comboBox1.Text))
            {
                comboBox1.Focus();
                errorProvider1.SetError(comboBox1, "GENDER is mandatory Field");
            }
            else if (string.IsNullOrEmpty(numericUpDown1.Text))
            {
                numericUpDown1.Focus();
                errorProvider1.SetError(numericUpDown1, "AGE is mandatory Field");
            }
            else if (string.IsNullOrEmpty(comboBox2.Text))
            {
                comboBox2.Focus();
                errorProvider1.SetError(comboBox2, "DESIGNATION is mandatory Field");
            }
            else if (string.IsNullOrEmpty(textBox6.Text))
            {
                textBox6.Focus();
                errorProvider1.SetError(textBox6, "SALARY is mandatory Field");
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "delete from  info where Id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                con.Open();
                int nq = cmd.ExecuteNonQuery();
                if (nq > 0)
                {
                    MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SqlDataBinding();
                    clearOperation();
                }
                else
                {
                    MessageBox.Show("Unsuccessful Delete Operation", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
            }

        }
        private void clearOperation()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox6.Clear();
            numericUpDown1.Value = 18;
            comboBox1.SelectedItem = null;  
            comboBox2.SelectedItem = null;
        }
    }
}