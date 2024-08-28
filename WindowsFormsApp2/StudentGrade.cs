using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class StudentGrade : Form
    {
        private string connectionString = @"Data Source=HoangHuy\SQLEXPRESS;Initial Catalog=ENG;Integrated Security=True";
        public StudentGrade()
        {
            InitializeComponent();
        }

        private void StudentGrade_Load(object sender, EventArgs e)
        {
            LoadGrades();
        }

        private void LoadGrades()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID, MaHS, MaLopHoc, Diem, Nhanxet FROM Grade";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                textBox1.Text = selectedRow.Cells["ID"].Value.ToString();
                textBox2.Text = selectedRow.Cells["MaHS"].Value.ToString();
                textBox3.Text = selectedRow.Cells["MaLopHoc"].Value.ToString();
                textBox4.Text = selectedRow.Cells["Diem"].Value.ToString();
                textBox5.Text = selectedRow.Cells["Nhanxet"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string nhanXet = textBox5.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE Grade SET Nhanxet = @nhanXet WHERE ID = @id";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@nhanXet", nhanXet);
                        command.Parameters.AddWithValue("@id", id);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thành công!");
                            selectedRow.Cells["Nhanxet"].Value = nhanXet; 
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.");
            }
        }
    }
}