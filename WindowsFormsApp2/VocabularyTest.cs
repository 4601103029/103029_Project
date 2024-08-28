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
    public partial class VocabularyTest : Form
    {
        private string connectionString = @"Data Source=HoangHuy\SQLEXPRESS;Initial Catalog=ENG;Integrated Security=True";

        private string[] correctAnswers = { "HOMEWORK", "HISTORY", "FOOTBALL", "EXCERCISE", "SCHOOL", "MUSIC", "LUNCH", "SCIENCE", "LESSON", "MUSIC" };

        public VocabularyTest()
        {
            InitializeComponent();
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            int score = 0;
            for (int i = 0; i < 10; i++)
            {
                string answer = ((TextBox)this.Controls["textBox" + (i + 1)]).Text.Trim().ToUpper();
                if (answer == correctAnswers[i])
                {
                    score++;
                }
                else if (string.IsNullOrEmpty(answer))
                {
                    continue;
                }
            }

            SaveScoreToDatabase(score);
            MessageBox.Show("Your score is: " + score + "/10");
        }

        private void SaveScoreToDatabase(int score)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Grade (ID, MaHS, MaLopHoc, Diem, Nhanxet) VALUES (@ID, @MaHS, @MaLopHoc, @Diem, @Nhanxet)";
                SqlCommand command = new SqlCommand(query, connection);
                int id = GetNextID(connection);

                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@MaHS", Login.MaHS);
                command.Parameters.AddWithValue("@MaLopHoc", 1);
                command.Parameters.AddWithValue("@Diem", score);
                command.Parameters.AddWithValue("@Nhanxet", ""); 

                command.ExecuteNonQuery();
            }
        }

        private int GetNextID(SqlConnection connection)
        {
            string query = "SELECT ISNULL(MAX(ID), 0) + 1 AS NextID FROM Grade";
            SqlCommand command = new SqlCommand(query, connection);
            int nextID = (int)command.ExecuteScalar();
            return nextID;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}