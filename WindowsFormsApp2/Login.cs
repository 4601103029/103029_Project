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
    public partial class Login : Form
    {
        public static int MaHS = -1;
        public static int MaGV = -1;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HoangHuy\SQLEXPRESS;Initial Catalog=ENG;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtUsername.Text;
                string mk = txtPassword.Text;

                string sqlAdmin = "SELECT * FROM Admin WHERE Username = @Username AND Password = @Password";
                SqlCommand cmdAdmin = new SqlCommand(sqlAdmin, conn);
                cmdAdmin.Parameters.AddWithValue("@Username", tk);
                cmdAdmin.Parameters.AddWithValue("@Password", mk);
                SqlDataReader dtaAdmin = cmdAdmin.ExecuteReader();
                if (dtaAdmin.Read())
                {
                    MessageBox.Show("Đăng nhập thành công (Admin)");
                    this.Hide();
                    LessonForm lessonForm = new LessonForm();
                    lessonForm.ShowDialog();
                    this.Show();
                    return;
                }
                dtaAdmin.Close();
                string sqlStudent = "SELECT * FROM Student WHERE Username = @Username AND Password = @Password";
                SqlCommand cmdStudent = new SqlCommand(sqlStudent, conn);
                cmdStudent.Parameters.AddWithValue("@Username", tk);
                cmdStudent.Parameters.AddWithValue("@Password", mk);
                SqlDataReader dtaStudent = cmdStudent.ExecuteReader();
                if (dtaStudent.Read())
                {
                    Login.MaHS = (int)dtaStudent["MaHS"];
                    MessageBox.Show("Đăng nhập thành công (Student)");
                    this.Hide();
                    LessonForm lessonForm = new LessonForm();
                    lessonForm.ShowDialog();
                    this.Show();
                    return;
                }
                dtaStudent.Close();
                string sqlTeacher = "SELECT * FROM Teacher WHERE Username = @Username AND Password = @Password";
                SqlCommand cmdTeacher = new SqlCommand(sqlTeacher, conn);
                cmdTeacher.Parameters.AddWithValue("@Username", tk);
                cmdTeacher.Parameters.AddWithValue("@Password", mk);
                SqlDataReader dtaTeacher = cmdTeacher.ExecuteReader();
                if (dtaTeacher.Read())
                {
                    MessageBox.Show("Đăng nhập thành công (Teacher)");
                    this.Hide();
                    TeacherForm teacherForm = new TeacherForm();
                    teacherForm.ShowDialog();
                    this.Show();
                    return;
                }
                dtaStudent.Close();

                MessageBox.Show("Đăng nhập không thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Show();
        }
    }
}

