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
    public partial class LessonForm : Form
    {
        private SqlConnection connection;
        public LessonForm()
        {
            InitializeComponent();
            string connectionString = @"Data Source=HoangHuy\SQLEXPRESS;Initial Catalog=ENG;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }
        private void LessonForm_Load(object sender, EventArgs e)
        {
            LoadLessonData();
        }
        private void LoadLessonData()
        {
            try
            {
                connection.Open();
                string query = "SELECT TOP 2 MaLopHoc, Ten FROM LESSON ORDER BY MaLopHoc";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    textBox1.Text = reader["MaLopHoc"].ToString();
                    textBox2.Text = reader["Ten"].ToString();
                }

                if (reader.Read())
                {
                    textBox3.Text = reader["MaLopHoc"].ToString();
                    textBox4.Text = reader["Ten"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VocabularyForm vocabularyForm = new VocabularyForm();
            vocabularyForm.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grammar grammar = new Grammar();
            grammar.ShowDialog();
            this.Show();
        }
    }
}