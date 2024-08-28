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
    public partial class StudentAcc : Form
    {
        private string connectionString = @"Data Source=HoangHuy\SQLEXPRESS;Initial Catalog=ENG;Integrated Security=True";
        public StudentAcc()
        {
            InitializeComponent();
        }
        private void StudentAcc_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }
        private void LoadStudent()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MaHS,Ten,email, Username, Password, Capdo FROM Student";
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
                textBox6.Text = selectedRow.Cells["Capdo"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maHS = textBox1.Text;
            string ten = textBox2.Text;
            string email = textBox3.Text;
            string username = textBox4.Text;
            string password = textBox5.Text;
            string capDo = textBox6.Text;
            string query = "INSERT INTO Student (MaHS, Ten, email, Username, Password, Capdo) VALUES (@MaHS, @Ten, @email, @Username, @Password, @Capdo)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHS", maHS);
                command.Parameters.AddWithValue("@Ten", ten);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Capdo", capDo);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm dữ liệu mới thành công!");
                    LoadStudent();
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
                string maHS = textBox1.Text;
                string ten = textBox2.Text;
                string email = textBox3.Text;
                string username = textBox4.Text;
                string password = textBox5.Text;
                string capDo = textBox6.Text;
                string query = "UPDATE Student SET Ten = @Ten, email = @email, Username = @Username, Password = @Password, Capdo = @Capdo WHERE MaHS = @MaHS";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaHS", maHS);
                    command.Parameters.AddWithValue("@Ten", ten);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Capdo", capDo);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                        LoadStudent();
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
                string maHS = selectedRow.Cells["MaHS"].Value.ToString();
                string query = "DELETE FROM Student WHERE MaHS = @MaHS";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaHS", maHS);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!");
                        LoadStudent();
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