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
    internal class ViewGiangVienForm : DetailInfoForm<GiangVien>
    {
        protected DateTimePicker ngaySinhDateTimePicker;
        private Button update_btn;
        private TextBox maGVTextBox;
        private TextBox soDTTextBox;
        private TextBox tinhTrangTextBox;
        private TextBox tenTextBox;
        private TextBox hoTextBox;
        private TextBox gioiTinhTextBox;
        private TextBox emailTextBox;
        private TextBox diaChiTextBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Label tinhTrangLabel;

        public ViewGiangVienForm()
        {
        }

        public ViewGiangVienForm(GiangVien gv) : base()
        {
            InitializeComponent();
            this.LoadDataFromObject(gv);
            Init();
        }
        protected override void Init()
        {
            this.maGVTextBox.Enabled = false;
            this.hoTextBox.Enabled = true;
            this.tenTextBox.Enabled = true;
            this.emailTextBox.Enabled = true;
            this.gioiTinhTextBox.Enabled = true;
            this.diaChiTextBox.Enabled = true;
            this.ngaySinhDateTimePicker.Enabled = true;
            this.tinhTrangTextBox.Enabled = true;
            this.soDTTextBox.Enabled = true;
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label maGVLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label soDTLabel;
            System.Windows.Forms.Label tenLabel;
            this.tinhTrangLabel = new System.Windows.Forms.Label();
            this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.update_btn = new System.Windows.Forms.Button();
            this.maGVTextBox = new System.Windows.Forms.TextBox();
            this.soDTTextBox = new System.Windows.Forms.TextBox();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.hoTextBox = new System.Windows.Forms.TextBox();
            this.gioiTinhTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.tinhTrangTextBox = new System.Windows.Forms.TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            diaChiLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            maGVLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            soDTLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Controls.Add(this.maGVTextBox);
            this.panel1.Controls.Add(this.soDTTextBox);
            this.panel1.Controls.Add(this.tinhTrangTextBox);
            this.panel1.Controls.Add(this.tenTextBox);
            this.panel1.Controls.Add(this.hoTextBox);
            this.panel1.Controls.Add(this.gioiTinhTextBox);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.diaChiTextBox);
            this.panel1.Controls.Add(this.update_btn);
            this.panel1.Controls.Add(diaChiLabel);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(gioiTinhLabel);
            this.panel1.Controls.Add(hoLabel);
            this.panel1.Controls.Add(maGVLabel);
            this.panel1.Controls.Add(ngaySinhLabel);
            this.panel1.Controls.Add(this.ngaySinhDateTimePicker);
            this.panel1.Controls.Add(soDTLabel);
            this.panel1.Controls.Add(tenLabel);
            this.panel1.Controls.Add(this.tinhTrangLabel);
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diaChiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            diaChiLabel.Location = new System.Drawing.Point(205, 112);
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
            emailLabel.Location = new System.Drawing.Point(215, 150);
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
            gioiTinhLabel.Location = new System.Drawing.Point(191, 185);
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
            hoLabel.Location = new System.Drawing.Point(243, 220);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(41, 26);
            hoLabel.TabIndex = 6;
            hoLabel.Text = "Họ:";
            // 
            // maGVLabel
            // 
            maGVLabel.AutoSize = true;
            maGVLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maGVLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maGVLabel.Location = new System.Drawing.Point(139, 256);
            maGVLabel.Name = "maGVLabel";
            maGVLabel.Size = new System.Drawing.Size(145, 26);
            maGVLabel.TabIndex = 8;
            maGVLabel.Text = "Mã giảng viên:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngaySinhLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            ngaySinhLabel.Location = new System.Drawing.Point(176, 288);
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
            soDTLabel.Location = new System.Drawing.Point(152, 319);
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
            tenLabel.Location = new System.Drawing.Point(234, 356);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(50, 26);
            tenLabel.TabIndex = 14;
            tenLabel.Text = "Tên:";
            // 
            // tinhTrangLabel
            // 
            this.tinhTrangLabel.AutoSize = true;
            this.tinhTrangLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhTrangLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.tinhTrangLabel.Location = new System.Drawing.Point(171, 391);
            this.tinhTrangLabel.Name = "tinhTrangLabel";
            this.tinhTrangLabel.Size = new System.Drawing.Size(113, 26);
            this.tinhTrangLabel.TabIndex = 16;
            this.tinhTrangLabel.Text = "Tình trạng:";
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "NgaySinh", true));
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(301, 290);
            this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(228, 22);
            this.ngaySinhDateTimePicker.TabIndex = 11;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Roboto Slab Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(399, 425);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(130, 33);
            this.update_btn.TabIndex = 18;
            this.update_btn.Text = "Cập nhật";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // maGVTextBox
            // 
            this.maGVTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maGVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maGVTextBox.Location = new System.Drawing.Point(301, 253);
            this.maGVTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maGVTextBox.Name = "maGVTextBox";
            this.maGVTextBox.Size = new System.Drawing.Size(228, 32);
            this.maGVTextBox.TabIndex = 24;
            // 
            // soDTTextBox
            // 
            this.soDTTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.soDTTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soDTTextBox.Location = new System.Drawing.Point(301, 316);
            this.soDTTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soDTTextBox.Name = "soDTTextBox";
            this.soDTTextBox.Size = new System.Drawing.Size(228, 32);
            this.soDTTextBox.TabIndex = 25;
            // 
            // tenTextBox
            // 
            this.tenTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.tenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenTextBox.Location = new System.Drawing.Point(301, 352);
            this.tenTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(228, 32);
            this.tenTextBox.TabIndex = 26;
            // 
            // hoTextBox
            // 
            this.hoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.hoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTextBox.Location = new System.Drawing.Point(301, 217);
            this.hoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoTextBox.Name = "hoTextBox";
            this.hoTextBox.Size = new System.Drawing.Size(228, 32);
            this.hoTextBox.TabIndex = 27;
            // 
            // gioiTinhTextBox
            // 
            this.gioiTinhTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.gioiTinhTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioiTinhTextBox.Location = new System.Drawing.Point(301, 181);
            this.gioiTinhTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gioiTinhTextBox.Name = "gioiTinhTextBox";
            this.gioiTinhTextBox.Size = new System.Drawing.Size(228, 32);
            this.gioiTinhTextBox.TabIndex = 28;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(301, 145);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(228, 32);
            this.emailTextBox.TabIndex = 29;
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.diaChiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiTextBox.Location = new System.Drawing.Point(301, 108);
            this.diaChiTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(228, 32);
            this.diaChiTextBox.TabIndex = 30;
            // 
            // tinhTrangTextBox
            // 
            this.tinhTrangTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.tinhTrangTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhTrangTextBox.Location = new System.Drawing.Point(301, 388);
            this.tinhTrangTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tinhTrangTextBox.Name = "tinhTrangTextBox";
            this.tinhTrangTextBox.Size = new System.Drawing.Size(228, 32);
            this.tinhTrangTextBox.TabIndex = 26;
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
            this.guna2ControlBox1.TabIndex = 31;
            // 
            // ViewGiangVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(725, 688);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewGiangVienForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            GiangVien gv = bindingSource.Current as GiangVien;
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

            if (MainForm.Manager.GiangVien.Update(gv))
            {
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
    }
}
