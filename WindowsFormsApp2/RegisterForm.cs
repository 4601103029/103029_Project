using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class RegisterForm : Form
    {
        private SqlConnection connection;
        private int lastMaHS = 1;
        private int lastMaGV = 1; 

        public RegisterForm()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source = HoangHuy\SQLEXPRESS; Initial Catalog = ENG; Integrated Security = True;Max Pool Size=100");
            GetLastMaHS();
            GetLastMaGV();
        }

        private void GetLastMaHS()
        {
            try
            {
                string sql = "SELECT MAX(MaHS) FROM Student";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                object result = command.ExecuteScalar();
                connection.Close();
                if (result != DBNull.Value)
                {
                    lastMaHS = (int)result + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy MaGV lớn nhất: " + ex.Message);
            }
        }
        private void GetLastMaGV()
        {
            try
            {
                string sql = "SELECT MAX(MaGV) FROM Teacher";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                object result = command.ExecuteScalar();
                connection.Close();
                if (result != DBNull.Value)
                {
                    lastMaGV = (int)result + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy MaGV lớn nhất: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int capdo = Convert.ToInt32(txtLevel.Text);
                if (capdo < 1 || capdo > 3)
                {
                    MessageBox.Show("Capdo chỉ được nhập 1 (Dễ), 2(Trung bình) hoặc 3(khó).");
                    return;
                }
                int mahs = lastMaHS;
                string ten = txtStuName.Text;
                string email = txtStuEmail.Text;
                string username = txtStuUsername.Text;
                string password = txtStuPassword.Text;
                string stuSQL = "INSERT INTO Student (MaHS, Ten, email, Username, Password, Capdo) VALUES (@MaHS, @Ten, @email, @Username, @Password, @Capdo)";
                SqlCommand stuCommand = new SqlCommand(stuSQL, connection);
                stuCommand.Parameters.AddWithValue("@MaHS", mahs);
                stuCommand.Parameters.AddWithValue("@Ten", ten);
                stuCommand.Parameters.AddWithValue("@email", email);
                stuCommand.Parameters.AddWithValue("@Username", username);
                stuCommand.Parameters.AddWithValue("@Password", password);
                stuCommand.Parameters.AddWithValue("@Capdo", capdo);

                connection.Open();
                int stuRowsAffected = stuCommand.ExecuteNonQuery();
                connection.Close();
                if (stuRowsAffected > 0)
                {
                    lastMaHS++;
                    lastMaGV++;
                    MessageBox.Show("Đăng ký thông tin sinh viên và giáo viên thành công!");
                    txtStuName.Text = "";
                    txtStuEmail.Text = "";
                    txtStuUsername.Text = "";
                    txtStuPassword.Text = "";
                    txtLevel.Text = "";
                }
                else
                {
                    MessageBox.Show("Không thể đăng ký thông tin sinh viên");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký thông tin sinh viên: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int magv = lastMaGV;
            string teng = txtTchName.Text;
            string emailg = txtTchEmail.Text;
            string usernameg = txtTchUsername.Text;
            string passwordg = txtTchPassword.Text;
            string teacherSQL = "INSERT INTO Teacher (MaGV, Ten, email, Username, Password) VALUES (@MaGV, @Ten, @email, @Username, @Password)";
            SqlCommand teacherCommand = new SqlCommand(teacherSQL, connection);
            teacherCommand.Parameters.AddWithValue("@MaGV", magv);
            teacherCommand.Parameters.AddWithValue("@Ten", teng);
            teacherCommand.Parameters.AddWithValue("@email", emailg);
            teacherCommand.Parameters.AddWithValue("@Username", usernameg);
            teacherCommand.Parameters.AddWithValue("@Password", passwordg);
            connection.Open();
            int teacherRowsAffected = teacherCommand.ExecuteNonQuery();
            connection.Close();
            if (teacherRowsAffected > 0)
            {
                lastMaHS++;
                lastMaGV++;
                MessageBox.Show("Đăng ký thông tin giáo viên thành công!");

                txtTchName.Text = "";
                txtTchEmail.Text = "";
                txtTchUsername.Text = "";
                txtTchPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Không thể đăng ký thông tin giáo viên.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}