using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormGiangVien
{
    internal class AddGiangVienForm : DetailInfoForm<GiangVien>
    {
        private ComboBox gioiTinhComboBox;
        private DateTimePicker ngaySinhDateTimePicker;
        private TextBox tinhTrangTextBox;
        private TextBox soDTTextBox;
        private TextBox diaChiTextBox;
        private TextBox emailTextBox;
        private TextBox tenTextBox;
        private TextBox hoTextBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Button add_btn;

        public AddGiangVienForm() : base()
        {
            InitializeComponent();
            //this.LoadDataFromObject(diem);
            tinhTrangTextBox.Text = "Dang giang day";
            tinhTrangTextBox.Enabled = false;
            Init();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label soDTLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label tinhTrangLabel;
            this.gioiTinhComboBox = new System.Windows.Forms.ComboBox();
            this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.add_btn = new System.Windows.Forms.Button();
            this.hoTextBox = new System.Windows.Forms.TextBox();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.soDTTextBox = new System.Windows.Forms.TextBox();
            this.tinhTrangTextBox = new System.Windows.Forms.TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            diaChiLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            soDTLabel = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.tinhTrangTextBox);
            this.panel1.Controls.Add(this.soDTTextBox);
            this.panel1.Controls.Add(this.diaChiTextBox);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.tenTextBox);
            this.panel1.Controls.Add(this.hoTextBox);
            this.panel1.Controls.Add(tinhTrangLabel);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(diaChiLabel);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(gioiTinhLabel);
            this.panel1.Controls.Add(this.gioiTinhComboBox);
            this.panel1.Controls.Add(hoLabel);
            this.panel1.Controls.Add(ngaySinhLabel);
            this.panel1.Controls.Add(this.ngaySinhDateTimePicker);
            this.panel1.Controls.Add(soDTLabel);
            this.panel1.Controls.Add(tenLabel);
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diaChiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            diaChiLabel.Location = new System.Drawing.Point(193, 257);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(79, 26);
            diaChiLabel.TabIndex = 0;
            diaChiLabel.Text = "Địa chỉ:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            emailLabel.Location = new System.Drawing.Point(203, 191);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(69, 26);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gioiTinhLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            gioiTinhLabel.Location = new System.Drawing.Point(179, 223);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(93, 26);
            gioiTinhLabel.TabIndex = 4;
            gioiTinhLabel.Text = "Giới tính:";
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            hoLabel.Location = new System.Drawing.Point(231, 122);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(41, 26);
            hoLabel.TabIndex = 6;
            hoLabel.Text = "Họ:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngaySinhLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            ngaySinhLabel.Location = new System.Drawing.Point(164, 289);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(108, 26);
            ngaySinhLabel.TabIndex = 10;
            ngaySinhLabel.Text = "Ngày sinh:";
            // 
            // soDTLabel
            // 
            soDTLabel.AutoSize = true;
            soDTLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soDTLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            soDTLabel.Location = new System.Drawing.Point(140, 322);
            soDTLabel.Name = "soDTLabel";
            soDTLabel.Size = new System.Drawing.Size(132, 26);
            soDTLabel.TabIndex = 12;
            soDTLabel.Text = "Số điện thoại:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            tenLabel.Location = new System.Drawing.Point(222, 159);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(50, 26);
            tenLabel.TabIndex = 14;
            tenLabel.Text = "Tên:";
            // 
            // tinhTrangLabel
            // 
            tinhTrangLabel.AutoSize = true;
            tinhTrangLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tinhTrangLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            tinhTrangLabel.Location = new System.Drawing.Point(159, 352);
            tinhTrangLabel.Name = "tinhTrangLabel";
            tinhTrangLabel.Size = new System.Drawing.Size(113, 26);
            tinhTrangLabel.TabIndex = 18;
            tinhTrangLabel.Text = "Tình trạng:";
            // 
            // gioiTinhComboBox
            // 
            this.gioiTinhComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "GioiTinh", true));
            this.gioiTinhComboBox.FormattingEnabled = true;
            this.gioiTinhComboBox.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.gioiTinhComboBox.Location = new System.Drawing.Point(278, 223);
            this.gioiTinhComboBox.Name = "gioiTinhComboBox";
            this.gioiTinhComboBox.Size = new System.Drawing.Size(228, 24);
            this.gioiTinhComboBox.TabIndex = 5;
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "NgaySinh", true));
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(279, 289);
            this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(227, 22);
            this.ngaySinhDateTimePicker.TabIndex = 11;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(376, 400);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 42);
            this.add_btn.TabIndex = 18;
            this.add_btn.Text = "Thêm";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // hoTextBox
            // 
            this.hoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.hoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTextBox.Location = new System.Drawing.Point(278, 117);
            this.hoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoTextBox.Name = "hoTextBox";
            this.hoTextBox.Size = new System.Drawing.Size(228, 32);
            this.hoTextBox.TabIndex = 20;
            // 
            // tenTextBox
            // 
            this.tenTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.tenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenTextBox.Location = new System.Drawing.Point(279, 153);
            this.tenTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(227, 32);
            this.tenTextBox.TabIndex = 20;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(278, 186);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(227, 32);
            this.emailTextBox.TabIndex = 20;
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.diaChiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiTextBox.Location = new System.Drawing.Point(279, 252);
            this.diaChiTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(227, 32);
            this.diaChiTextBox.TabIndex = 20;
            // 
            // soDTTextBox
            // 
            this.soDTTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.soDTTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soDTTextBox.Location = new System.Drawing.Point(278, 316);
            this.soDTTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soDTTextBox.Name = "soDTTextBox";
            this.soDTTextBox.Size = new System.Drawing.Size(227, 32);
            this.soDTTextBox.TabIndex = 20;
            // 
            // tinhTrangTextBox
            // 
            this.tinhTrangTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.tinhTrangTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhTrangTextBox.Location = new System.Drawing.Point(278, 352);
            this.tinhTrangTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tinhTrangTextBox.Name = "tinhTrangTextBox";
            this.tinhTrangTextBox.Size = new System.Drawing.Size(227, 32);
            this.tinhTrangTextBox.TabIndex = 20;
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
            this.guna2ControlBox1.TabIndex = 21;
            // 
            // AddGiangVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(725, 688);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddGiangVienForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien();
            gv.Ho = hoTextBox.Text;
            gv.Ten = tenTextBox.Text;
            gv.Email = emailTextBox.Text;
            gv.GioiTinh = gioiTinhComboBox.Text;
            gv.SoDT = soDTTextBox.Text;
            gv.DiaChi = diaChiTextBox.Text;
            gv.NgaySinh = ngaySinhDateTimePicker.Value;
            gv.TinhTrang = tinhTrangTextBox.Text;
            if (gv == null) return;

            ValidationContext context = new ValidationContext(gv, null, null);
            IList<ValidationResult> validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(gv, context, validationResults, true))
            {
                foreach (var item in validationResults)
                {
                    MessageBox.Show(item.ErrorMessage);
                    return;
                }
            }

            if (MainForm.Manager.GiangVien.Add(gv))
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
