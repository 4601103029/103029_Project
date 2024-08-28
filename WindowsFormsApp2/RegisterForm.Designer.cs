namespace WindowsFormsApp2
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtStuEmail = new System.Windows.Forms.TextBox();
            this.txtStuUsername = new System.Windows.Forms.TextBox();
            this.txtStuPassword = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTchName = new System.Windows.Forms.TextBox();
            this.txtTchEmail = new System.Windows.Forms.TextBox();
            this.txtTchUsername = new System.Windows.Forms.TextBox();
            this.txtTchPassword = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(573, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cấp độ";
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(92, 76);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(181, 22);
            this.txtStuName.TabIndex = 7;
            // 
            // txtStuEmail
            // 
            this.txtStuEmail.Location = new System.Drawing.Point(92, 118);
            this.txtStuEmail.Name = "txtStuEmail";
            this.txtStuEmail.Size = new System.Drawing.Size(181, 22);
            this.txtStuEmail.TabIndex = 8;
            // 
            // txtStuUsername
            // 
            this.txtStuUsername.Location = new System.Drawing.Point(92, 158);
            this.txtStuUsername.Name = "txtStuUsername";
            this.txtStuUsername.Size = new System.Drawing.Size(181, 22);
            this.txtStuUsername.TabIndex = 9;
            // 
            // txtStuPassword
            // 
            this.txtStuPassword.Location = new System.Drawing.Point(91, 196);
            this.txtStuPassword.Name = "txtStuPassword";
            this.txtStuPassword.Size = new System.Drawing.Size(182, 22);
            this.txtStuPassword.TabIndex = 10;
            this.txtStuPassword.UseSystemPasswordChar = true;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(92, 232);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(57, 22);
            this.txtLevel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(471, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(471, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Password";
            // 
            // txtTchName
            // 
            this.txtTchName.Location = new System.Drawing.Point(573, 79);
            this.txtTchName.Name = "txtTchName";
            this.txtTchName.Size = new System.Drawing.Size(174, 22);
            this.txtTchName.TabIndex = 16;
            // 
            // txtTchEmail
            // 
            this.txtTchEmail.Location = new System.Drawing.Point(573, 115);
            this.txtTchEmail.Name = "txtTchEmail";
            this.txtTchEmail.Size = new System.Drawing.Size(174, 22);
            this.txtTchEmail.TabIndex = 17;
            // 
            // txtTchUsername
            // 
            this.txtTchUsername.Location = new System.Drawing.Point(572, 156);
            this.txtTchUsername.Name = "txtTchUsername";
            this.txtTchUsername.Size = new System.Drawing.Size(174, 22);
            this.txtTchUsername.TabIndex = 18;
            // 
            // txtTchPassword
            // 
            this.txtTchPassword.Location = new System.Drawing.Point(573, 196);
            this.txtTchPassword.Name = "txtTchPassword";
            this.txtTchPassword.Size = new System.Drawing.Size(174, 22);
            this.txtTchPassword.TabIndex = 19;
            this.txtTchPassword.UseSystemPasswordChar = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(329, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Quay về";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 308);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Học viên";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(465, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 292);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giáo viên";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtTchPassword);
            this.Controls.Add(this.txtTchUsername);
            this.Controls.Add(this.txtTchEmail);
            this.Controls.Add(this.txtTchName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtStuPassword);
            this.Controls.Add(this.txtStuUsername);
            this.Controls.Add(this.txtStuEmail);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "RegisterForm";
            this.Text = "Đăng kí";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtStuEmail;
        private System.Windows.Forms.TextBox txtStuUsername;
        private System.Windows.Forms.TextBox txtStuPassword;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTchName;
        private System.Windows.Forms.TextBox txtTchEmail;
        private System.Windows.Forms.TextBox txtTchUsername;
        private System.Windows.Forms.TextBox txtTchPassword;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}