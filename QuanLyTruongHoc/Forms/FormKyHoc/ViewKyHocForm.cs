using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Forms.FormKyHoc
{
    internal class ViewKyHocForm : DetailInfoForm<KyHoc>
    {
        private System.Windows.Forms.TextBox kyHocTextBox;
        private System.Windows.Forms.TextBox maKyHocTextBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.TextBox hocPhiTextBox;
        private System.Windows.Forms.TextBox namHocTextBox;

        public ViewKyHocForm() : base()
        {
            InitializeComponent();
        }
        public ViewKyHocForm(KyHoc kyHoc) : base()
        {
            InitializeComponent();
            this.LoadDataFromObject(kyHoc);
            Init();
        }
        protected override void Init()
        {
            this.maKyHocTextBox.Enabled = false;
            this.namHocTextBox.Enabled = false;
            this.kyHocTextBox.Enabled = false;
            this.hocPhiTextBox.Enabled = false;
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.Label hocPhiLabel;
            System.Windows.Forms.Label kyHocLabel;
            System.Windows.Forms.Label maKyHocLabel;
            System.Windows.Forms.Label namHocLabel;
            this.kyHocTextBox = new System.Windows.Forms.TextBox();
            this.maKyHocTextBox = new System.Windows.Forms.TextBox();
            this.namHocTextBox = new System.Windows.Forms.TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.hocPhiTextBox = new System.Windows.Forms.TextBox();
            hocPhiLabel = new System.Windows.Forms.Label();
            kyHocLabel = new System.Windows.Forms.Label();
            maKyHocLabel = new System.Windows.Forms.Label();
            namHocLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Controls.Add(hocPhiLabel);
            this.panel1.Controls.Add(kyHocLabel);
            this.panel1.Controls.Add(maKyHocLabel);
            this.panel1.Controls.Add(namHocLabel);
            this.panel1.Controls.Add(this.hocPhiTextBox);
            this.panel1.Controls.Add(this.kyHocTextBox);
            this.panel1.Controls.Add(this.maKyHocTextBox);
            this.panel1.Controls.Add(this.namHocTextBox);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Size = new System.Drawing.Size(725, 303);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 303);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Size = new System.Drawing.Size(725, 259);
            // 
            // kyHocTextBox
            // 
            this.kyHocTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.kyHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "kyHoc", true));
            this.kyHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kyHocTextBox.Location = new System.Drawing.Point(256, 150);
            this.kyHocTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kyHocTextBox.Name = "kyHocTextBox";
            this.kyHocTextBox.Size = new System.Drawing.Size(291, 32);
            this.kyHocTextBox.TabIndex = 3;
            // 
            // maKyHocTextBox
            // 
            this.maKyHocTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maKyHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaKyHoc", true));
            this.maKyHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maKyHocTextBox.Location = new System.Drawing.Point(256, 189);
            this.maKyHocTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maKyHocTextBox.Name = "maKyHocTextBox";
            this.maKyHocTextBox.Size = new System.Drawing.Size(291, 32);
            this.maKyHocTextBox.TabIndex = 5;
            // 
            // namHocTextBox
            // 
            this.namHocTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.namHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "NamHoc", true));
            this.namHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namHocTextBox.Location = new System.Drawing.Point(256, 228);
            this.namHocTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namHocTextBox.Name = "namHocTextBox";
            this.namHocTextBox.Size = new System.Drawing.Size(291, 32);
            this.namHocTextBox.TabIndex = 7;
            // 
            // hocPhiLabel
            // 
            hocPhiLabel.AutoSize = true;
            hocPhiLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hocPhiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            hocPhiLabel.Location = new System.Drawing.Point(164, 113);
            hocPhiLabel.Name = "hocPhiLabel";
            hocPhiLabel.Size = new System.Drawing.Size(86, 26);
            hocPhiLabel.TabIndex = 31;
            hocPhiLabel.Text = "Học Phí:";
            // 
            // kyHocLabel
            // 
            kyHocLabel.AutoSize = true;
            kyHocLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kyHocLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            kyHocLabel.Location = new System.Drawing.Point(169, 153);
            kyHocLabel.Name = "kyHocLabel";
            kyHocLabel.Size = new System.Drawing.Size(81, 26);
            kyHocLabel.TabIndex = 32;
            kyHocLabel.Text = "Kỳ Học:";
            // 
            // maKyHocLabel
            // 
            maKyHocLabel.AutoSize = true;
            maKyHocLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKyHocLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maKyHocLabel.Location = new System.Drawing.Point(135, 191);
            maKyHocLabel.Name = "maKyHocLabel";
            maKyHocLabel.Size = new System.Drawing.Size(115, 26);
            maKyHocLabel.TabIndex = 33;
            maKyHocLabel.Text = "Mã Kỳ Học:";
            // 
            // namHocLabel
            // 
            namHocLabel.AutoSize = true;
            namHocLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            namHocLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            namHocLabel.Location = new System.Drawing.Point(148, 230);
            namHocLabel.Name = "namHocLabel";
            namHocLabel.Size = new System.Drawing.Size(100, 26);
            namHocLabel.TabIndex = 34;
            namHocLabel.Text = "Năm Học:";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(680, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 36;
            // 
            // hocPhiTextBox
            // 
            this.hocPhiTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.hocPhiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "HocPhi", true));
            this.hocPhiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hocPhiTextBox.Location = new System.Drawing.Point(256, 111);
            this.hocPhiTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hocPhiTextBox.Name = "hocPhiTextBox";
            this.hocPhiTextBox.Size = new System.Drawing.Size(291, 32);
            this.hocPhiTextBox.TabIndex = 1;
            // 
            // ViewKyHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 562);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewKyHocForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
