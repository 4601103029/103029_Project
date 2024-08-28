using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Grammar : Form
    {
        private string[] imagePaths = {
            "C:\\Users\\hoang\\source\\repos\\WindowsFormsApp2 - Copy - Copy\\WindowsFormsApp2\\UNIT1_GRAMMAR\\1.jpg",
            "C:\\Users\\hoang\\source\\repos\\WindowsFormsApp2 - Copy - Copy\\WindowsFormsApp2\\UNIT1_GRAMMAR\\2.png",
            "C:\\Users\\hoang\\source\\repos\\WindowsFormsApp2 - Copy - Copy\\WindowsFormsApp2\\UNIT1_GRAMMAR\\3.png",
            "C:\\Users\\hoang\\source\\repos\\WindowsFormsApp2 - Copy - Copy\\WindowsFormsApp2\\UNIT1_GRAMMAR\\4.png",
            "C:\\Users\\hoang\\source\\repos\\WindowsFormsApp2 - Copy - Copy\\WindowsFormsApp2\\UNIT1_GRAMMAR\\5.png",
            "C:\\Users\\hoang\\source\\repos\\WindowsFormsApp2 - Copy - Copy\\WindowsFormsApp2\\UNIT1_GRAMMAR\\6.png",
        };
        private int currentIndex = 0;
        public Grammar()
        {
            InitializeComponent();
            LoadImage(imagePaths[currentIndex]);
        }
        private void LoadImage(string imagePath)
        {
            try
            {
                Bitmap image = new Bitmap(imagePath);
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= imagePaths.Length)
                currentIndex = 0;

            LoadImage(imagePaths[currentIndex]);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0)
                currentIndex = imagePaths.Length - 1;

            LoadImage(imagePaths[currentIndex]);
        }

        private void btnDoTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            GrammarTest grammarTest = new GrammarTest();
            grammarTest.ShowDialog();
            this.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;
            string text3 = textBox3.Text;
            string text4 = textBox4.Text;
            string text5 = textBox5.Text;
            bool isValid1 = CheckTextBox(textBox1, text1);
            bool isValid2 = CheckTextBox(textBox2, text2);
            bool isValid3 = CheckTextBox(textBox3, text3);
            bool isValid4 = CheckTextBox(textBox4, text4);
            bool isValid5 = CheckTextBox(textBox5, text5);
            if (isValid1 && isValid2 && isValid3)
            {
                MessageBox.Show("All textboxes are valid!");
            }
            else
            {
                MessageBox.Show("One or more textboxes are invalid.");
            }
        }
        private bool CheckTextBox(TextBox textBox, string text)
        {
            bool isValid = (text.ToUpper() == "READS" || text.ToUpper() == "GOES" || text.ToUpper() == "DOES" || text.ToUpper() == "GETS" || text.ToUpper() == "GO");
            if (isValid)
            {
                textBox.BackColor = Color.LightGreen;
            }
            else
            {
                textBox.BackColor = Color.LightPink;
            }

            return isValid;
        }
    }
}
