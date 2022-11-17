using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Forms.FormSinhVien
{
    internal class ViewSinhVienForm : DetailInfoForm<SinhVien>
    {
        protected System.Windows.Forms.TextBox diaChiTextBox;
        protected System.Windows.Forms.TextBox emailTextBox;
        protected System.Windows.Forms.TextBox gioiTinhTextBox;
        protected System.Windows.Forms.TextBox hoTextBox;
        protected System.Windows.Forms.ComboBox maKhoaComboBox;
        protected System.Windows.Forms.TextBox maSVTextBox;
        protected System.Windows.Forms.DateTimePicker ngaySinhDateTimePicker;
        protected System.Windows.Forms.TextBox tenTextBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        protected System.Windows.Forms.ComboBox tinhTrangComboBox;

        public ViewSinhVienForm(SinhVien sv) : base()
        {
            InitializeComponent();
            this.LoadDataFromObject(sv);
            Init();
        }

        public ViewSinhVienForm() : base()
        {
            InitializeComponent();
            this.bindingSource.DataSource = new SinhVien();
        }

        protected override void Init()
        {
            this.maSVTextBox.Enabled = false;
            this.hoTextBox.Enabled = false;
            this.tenTextBox.Enabled = false;
            this.emailTextBox.Enabled = false;
            this.gioiTinhTextBox.Enabled = false;
            this.diaChiTextBox.Enabled = false;
            this.ngaySinhDateTimePicker.Enabled = false;
            this.tinhTrangComboBox.Enabled = false;
            this.maKhoaComboBox.Enabled = false;
        }
        
        private void InitializeComponent()
        {
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label maKhoaLabel;
            System.Windows.Forms.Label maSVLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label tinhTrangLabel;
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.gioiTinhTextBox = new System.Windows.Forms.TextBox();
            this.hoTextBox = new System.Windows.Forms.TextBox();
            this.maKhoaComboBox = new System.Windows.Forms.ComboBox();
            this.maSVTextBox = new System.Windows.Forms.TextBox();
            this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.tinhTrangComboBox = new System.Windows.Forms.ComboBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            diaChiLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            maKhoaLabel = new System.Windows.Forms.Label();
            maSVLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            tinhTrangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Controls.Add(diaChiLabel);
            this.panel1.Controls.Add(this.diaChiTextBox);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(gioiTinhLabel);
            this.panel1.Controls.Add(this.gioiTinhTextBox);
            this.panel1.Controls.Add(hoLabel);
            this.panel1.Controls.Add(this.hoTextBox);
            this.panel1.Controls.Add(maKhoaLabel);
            this.panel1.Controls.Add(this.maKhoaComboBox);
            this.panel1.Controls.Add(maSVLabel);
            this.panel1.Controls.Add(this.maSVTextBox);
            this.panel1.Controls.Add(ngaySinhLabel);
            this.panel1.Controls.Add(this.ngaySinhDateTimePicker);
            this.panel1.Controls.Add(tenLabel);
            this.panel1.Controls.Add(this.tenTextBox);
            this.panel1.Controls.Add(tinhTrangLabel);
            this.panel1.Controls.Add(this.tinhTrangComboBox);
            this.panel1.Size = new System.Drawing.Size(654, 574);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 574);
            this.panel2.Size = new System.Drawing.Size(654, 114);
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.BackColor = System.Drawing.Color.White;
            diaChiLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diaChiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            diaChiLabel.Location = new System.Drawing.Point(149, 414);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(79, 26);
            diaChiLabel.TabIndex = 0;
            diaChiLabel.Text = "Địa chỉ:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.White;
            emailLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            emailLabel.Location = new System.Drawing.Point(159, 297);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(69, 26);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.BackColor = System.Drawing.Color.White;
            gioiTinhLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gioiTinhLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            gioiTinhLabel.Location = new System.Drawing.Point(135, 221);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(93, 26);
            gioiTinhLabel.TabIndex = 4;
            gioiTinhLabel.Text = "Giới tính:";
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.BackColor = System.Drawing.Color.White;
            hoLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            hoLabel.Location = new System.Drawing.Point(187, 181);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(41, 26);
            hoLabel.TabIndex = 6;
            hoLabel.Text = "Họ:";
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.BackColor = System.Drawing.Color.White;
            maKhoaLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKhoaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maKhoaLabel.Location = new System.Drawing.Point(135, 337);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(95, 26);
            maKhoaLabel.TabIndex = 8;
            maKhoaLabel.Text = "Mã khoa:";
            // 
            // maSVLabel
            // 
            maSVLabel.AutoSize = true;
            maSVLabel.BackColor = System.Drawing.Color.White;
            maSVLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maSVLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maSVLabel.Location = new System.Drawing.Point(95, 106);
            maSVLabel.Name = "maSVLabel";
            maSVLabel.Size = new System.Drawing.Size(133, 26);
            maSVLabel.TabIndex = 10;
            maSVLabel.Text = "Mã sinh viên:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.BackColor = System.Drawing.Color.White;
            ngaySinhLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngaySinhLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            ngaySinhLabel.Location = new System.Drawing.Point(121, 377);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(108, 26);
            ngaySinhLabel.TabIndex = 12;
            ngaySinhLabel.Text = "Ngày sinh:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.BackColor = System.Drawing.Color.White;
            tenLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            tenLabel.Location = new System.Drawing.Point(178, 144);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(50, 26);
            tenLabel.TabIndex = 14;
            tenLabel.Text = "Tên:";
            // 
            // tinhTrangLabel
            // 
            tinhTrangLabel.AutoSize = true;
            tinhTrangLabel.BackColor = System.Drawing.Color.White;
            tinhTrangLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tinhTrangLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            tinhTrangLabel.Location = new System.Drawing.Point(115, 258);
            tinhTrangLabel.Name = "tinhTrangLabel";
            tinhTrangLabel.Size = new System.Drawing.Size(113, 26);
            tinhTrangLabel.TabIndex = 16;
            tinhTrangLabel.Text = "Tình trạng:";
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "DiaChi", true));
            this.diaChiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiTextBox.Location = new System.Drawing.Point(234, 411);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(290, 32);
            this.diaChiTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(234, 295);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(290, 32);
            this.emailTextBox.TabIndex = 3;
            // 
            // gioiTinhTextBox
            // 
            this.gioiTinhTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.gioiTinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "GioiTinh", true));
            this.gioiTinhTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioiTinhTextBox.Location = new System.Drawing.Point(234, 217);
            this.gioiTinhTextBox.Name = "gioiTinhTextBox";
            this.gioiTinhTextBox.Size = new System.Drawing.Size(290, 32);
            this.gioiTinhTextBox.TabIndex = 5;
            // 
            // hoTextBox
            // 
            this.hoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.hoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Ho", true));
            this.hoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTextBox.Location = new System.Drawing.Point(234, 179);
            this.hoTextBox.Name = "hoTextBox";
            this.hoTextBox.Size = new System.Drawing.Size(290, 32);
            this.hoTextBox.TabIndex = 7;
            // 
            // maKhoaComboBox
            // 
            this.maKhoaComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maKhoaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaKhoa", true));
            this.maKhoaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maKhoaComboBox.FormattingEnabled = true;
            this.maKhoaComboBox.Location = new System.Drawing.Point(234, 333);
            this.maKhoaComboBox.Name = "maKhoaComboBox";
            this.maKhoaComboBox.Size = new System.Drawing.Size(290, 34);
            this.maKhoaComboBox.TabIndex = 9;
            // 
            // maSVTextBox
            // 
            this.maSVTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maSVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaSV", true));
            this.maSVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maSVTextBox.Location = new System.Drawing.Point(234, 103);
            this.maSVTextBox.Name = "maSVTextBox";
            this.maSVTextBox.Size = new System.Drawing.Size(290, 32);
            this.maSVTextBox.TabIndex = 11;
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "NgaySinh", true));
            this.ngaySinhDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(234, 373);
            this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(290, 32);
            this.ngaySinhDateTimePicker.TabIndex = 13;
            // 
            // tenTextBox
            // 
            this.tenTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Ten", true));
            this.tenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenTextBox.Location = new System.Drawing.Point(234, 141);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(290, 32);
            this.tenTextBox.TabIndex = 15;
            // 
            // tinhTrangComboBox
            // 
            this.tinhTrangComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.tinhTrangComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "TinhTrang", true));
            this.tinhTrangComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhTrangComboBox.FormattingEnabled = true;
            this.tinhTrangComboBox.Items.AddRange(new object[] {
            "Dang theo hoc",
            "Da thoi hoc",
            "Tam nghi hoc"});
            this.tinhTrangComboBox.Location = new System.Drawing.Point(234, 255);
            this.tinhTrangComboBox.Name = "tinhTrangComboBox";
            this.tinhTrangComboBox.Size = new System.Drawing.Size(290, 34);
            this.tinhTrangComboBox.TabIndex = 17;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(609, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 18;
            // 
            // ViewSinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(654, 688);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewSinhVienForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
