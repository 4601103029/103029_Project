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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class TeacherAcc : Form
    {
        private string connectionString = @"Data Source=HoangHuy\SQLEXPRESS;Initial Catalog=ENG;Integrated Security=True";
        public TeacherAcc()
        {
            InitializeComponent();
        }

        private void TeacherAcc_Load(object sender, EventArgs e)
        {
            LoadTeacher();
        }
        private void LoadTeacher()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MaGV,Ten,email, Username, Password FROM Teacher";
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
                textBox1.Text = selectedRow.Cells["MaHS"].Value.ToString();
                textBox2.Text = selectedRow.Cells["Ten"].Value.ToString();
                textBox3.Text = selectedRow.Cells["email"].Value.ToString();
                textBox4.Text = selectedRow.Cells["Username"].Value.ToString();
                textBox5.Text = selectedRow.Cells["Password"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maGV = textBox1.Text;
            string ten = textBox2.Text;
            string email = textBox3.Text;
            string username = textBox4.Text;
            string password = textBox5.Text;
            string query = "INSERT INTO Teacher (MaGV, Ten, email, Username, Password) VALUES (@MaHS, @Ten, @email, @Username, @Password)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHS", maGV);
                command.Parameters.AddWithValue("@Ten", ten);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm dữ liệu mới thành công!");
                    LoadTeacher();
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu mới thất bại.");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maGV = textBox1.Text;
                string ten = textBox2.Text;
                string email = textBox3.Text;
                string username = textBox4.Text;
                string password = textBox5.Text;
                string query = "UPDATE Teacher SET Ten = @Ten, email = @email, Username = @Username, Password = @Password WHERE MaGV = @MaGV";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaGV", maGV);
                    command.Parameters.AddWithValue("@Ten", ten);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                        LoadTeacher();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật dữ liệu thất bại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu để cập nhật.");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maGV = selectedRow.Cells["MaGV"].Value.ToString();
                string query = "DELETE FROM Teacher WHERE MaGV = @MaGV";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaGV", maGV);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!");
                        LoadTeacher(); 
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thất bại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu để xóa.");
            }
        }
    }
}
