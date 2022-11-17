namespace QuanLyTruongHoc
{
    partial class MainForm
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
            this.sign_in_qtv = new System.Windows.Forms.RadioButton();
            this.sign_in_teacher = new System.Windows.Forms.RadioButton();
            this.sign_in_student = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.input_username = new System.Windows.Forms.TextBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sign_in_btn = new System.Windows.Forms.Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sign_in_qtv
            // 
            this.sign_in_qtv.AutoSize = true;
            this.sign_in_qtv.Font = new System.Drawing.Font("Roboto Slab", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in_qtv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.sign_in_qtv.Location = new System.Drawing.Point(105, 210);
            this.sign_in_qtv.Name = "sign_in_qtv";
            this.sign_in_qtv.Size = new System.Drawing.Size(133, 27);
            this.sign_in_qtv.TabIndex = 1;
            this.sign_in_qtv.TabStop = true;
            this.sign_in_qtv.Text = "Quản trị viên";
            this.sign_in_qtv.UseVisualStyleBackColor = true;
            // 
            // sign_in_teacher
            // 
            this.sign_in_teacher.AutoSize = true;
            this.sign_in_teacher.Font = new System.Drawing.Font("Roboto Slab", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in_teacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.sign_in_teacher.Location = new System.Drawing.Point(256, 210);
            this.sign_in_teacher.Name = "sign_in_teacher";
            this.sign_in_teacher.Size = new System.Drawing.Size(104, 27);
            this.sign_in_teacher.TabIndex = 0;
            this.sign_in_teacher.TabStop = true;
            this.sign_in_teacher.Text = "Giáo viên";
            this.sign_in_teacher.UseVisualStyleBackColor = true;
            // 
            // sign_in_student
            // 
            this.sign_in_student.AutoSize = true;
            this.sign_in_student.Font = new System.Drawing.Font("Roboto Slab", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in_student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.sign_in_student.Location = new System.Drawing.Point(383, 210);
            this.sign_in_student.Name = "sign_in_student";
            this.sign_in_student.Size = new System.Drawing.Size(107, 27);
            this.sign_in_student.TabIndex = 2;
            this.sign_in_student.TabStop = true;
            this.sign_in_student.Text = "Sinh viên";
            this.sign_in_student.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(101, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập :";
            // 
            // input_username
            // 
            this.input_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.input_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_username.Location = new System.Drawing.Point(105, 94);
            this.input_username.Name = "input_username";
            this.input_username.Size = new System.Drawing.Size(385, 32);
            this.input_username.TabIndex = 3;
            // 
            // input_password
            // 
            this.input_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.input_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_password.Location = new System.Drawing.Point(105, 158);
            this.input_password.Name = "input_password";
            this.input_password.PasswordChar = '*';
            this.input_password.Size = new System.Drawing.Size(385, 32);
            this.input_password.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.sign_in_student);
            this.panel1.Controls.Add(this.sign_in_teacher);
            this.panel1.Controls.Add(this.sign_in_qtv);
            this.panel1.Controls.Add(this.sign_in_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.input_password);
            this.panel1.Controls.Add(this.input_username);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(55, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 354);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Slab", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.label3.Location = new System.Drawing.Point(35, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(538, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "PHẦN MỀM QUẢN LÝ TRƯỜNG HỌC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Slab", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.label4.Location = new System.Drawing.Point(101, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mật khẩu :";
            // 
            // sign_in_btn
            // 
            this.sign_in_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.sign_in_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_in_btn.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in_btn.ForeColor = System.Drawing.Color.White;
            this.sign_in_btn.Location = new System.Drawing.Point(184, 253);
            this.sign_in_btn.Name = "sign_in_btn";
            this.sign_in_btn.Size = new System.Drawing.Size(243, 36);
            this.sign_in_btn.TabIndex = 5;
            this.sign_in_btn.Text = "Đăng nhập";
            this.sign_in_btn.UseVisualStyleBackColor = false;
            this.sign_in_btn.Click += new System.EventHandler(this.sign_in_btn_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(693, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(738, 477);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton sign_in_qtv;
        private System.Windows.Forms.RadioButton sign_in_teacher;
        private System.Windows.Forms.RadioButton sign_in_student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_username;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sign_in_btn;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}

