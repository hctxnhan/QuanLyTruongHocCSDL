using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Helpers.Convert;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormGiangVien
{
    internal class ListGiangVienForm : BaseListForm<GiangVien>
    {
        private System.Windows.Forms.BindingSource giangVienBindingSource;
        private BindingSource giangVienBindingSource1;
        private ComboBox gioiTinhComboBox;
        private DateTimePicker ngaySinhDateTimePicker;
        private Label tinhTrangLabel;
        private TextBox hoTextBox;
        private TextBox emailTextBox;
        private TextBox diaChiTextBox;
        private TextBox soDTTextBox;
        private TextBox maGVTextBox;
        private TextBox tinhTrangTextBox;
        private TextBox tenTextBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

        //private Button add_btn;
        private System.ComponentModel.IContainer components;
        public ListGiangVienForm() : base()
        {
            InitializeComponent();
            giangVienBindingSource1.DataSource = new GiangVien();
            InitList();
        }

        public override DataTable GetTable()
        {
            return MainForm.Manager.GiangVien.Load();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label maGVLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label soDTLabel;
            System.Windows.Forms.Label tenLabel;
            this.tinhTrangLabel = new System.Windows.Forms.Label();
            this.giangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giangVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gioiTinhComboBox = new System.Windows.Forms.ComboBox();
            this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.hoTextBox = new System.Windows.Forms.TextBox();
            this.maGVTextBox = new System.Windows.Forms.TextBox();
            this.soDTTextBox = new System.Windows.Forms.TextBox();
            this.tenTextBox = new System.Windows.Forms.TextBox();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Roboto Slab Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(660, 277);
            this.search_btn.Size = new System.Drawing.Size(130, 35);
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Roboto Slab Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(660, 317);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Size = new System.Drawing.Size(130, 35);
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click_1);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Roboto Slab Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Location = new System.Drawing.Point(660, 236);
            this.refresh.Size = new System.Drawing.Size(130, 35);
            this.refresh.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tinhTrangTextBox);
            this.panel1.Controls.Add(this.tenTextBox);
            this.panel1.Controls.Add(this.soDTTextBox);
            this.panel1.Controls.Add(this.maGVTextBox);
            this.panel1.Controls.Add(this.hoTextBox);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.diaChiTextBox);
            this.panel1.Controls.Add(diaChiLabel);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(gioiTinhLabel);
            this.panel1.Controls.Add(this.gioiTinhComboBox);
            this.panel1.Controls.Add(hoLabel);
            this.panel1.Controls.Add(maGVLabel);
            this.panel1.Controls.Add(ngaySinhLabel);
            this.panel1.Controls.Add(this.ngaySinhDateTimePicker);
            this.panel1.Controls.Add(soDTLabel);
            this.panel1.Controls.Add(tenLabel);
            this.panel1.Controls.Add(this.tinhTrangLabel);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Size = new System.Drawing.Size(828, 379);
            this.panel1.Controls.SetChildIndex(this.refresh, 0);
            this.panel1.Controls.SetChildIndex(this.search_btn, 0);
            this.panel1.Controls.SetChildIndex(this.add_btn, 0);
            this.panel1.Controls.SetChildIndex(this.tinhTrangLabel, 0);
            this.panel1.Controls.SetChildIndex(tenLabel, 0);
            this.panel1.Controls.SetChildIndex(soDTLabel, 0);
            this.panel1.Controls.SetChildIndex(this.ngaySinhDateTimePicker, 0);
            this.panel1.Controls.SetChildIndex(ngaySinhLabel, 0);
            this.panel1.Controls.SetChildIndex(maGVLabel, 0);
            this.panel1.Controls.SetChildIndex(hoLabel, 0);
            this.panel1.Controls.SetChildIndex(this.gioiTinhComboBox, 0);
            this.panel1.Controls.SetChildIndex(gioiTinhLabel, 0);
            this.panel1.Controls.SetChildIndex(emailLabel, 0);
            this.panel1.Controls.SetChildIndex(diaChiLabel, 0);
            this.panel1.Controls.SetChildIndex(this.diaChiTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.emailTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.hoTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.maGVTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.soDTTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.tenTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.tinhTrangTextBox, 0);
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diaChiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            diaChiLabel.Location = new System.Drawing.Point(273, 43);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(79, 26);
            diaChiLabel.TabIndex = 2;
            diaChiLabel.Text = "Địa chỉ:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            emailLabel.Location = new System.Drawing.Point(283, 79);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(69, 26);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gioiTinhLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            gioiTinhLabel.Location = new System.Drawing.Point(259, 113);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(93, 26);
            gioiTinhLabel.TabIndex = 6;
            gioiTinhLabel.Text = "Giới tính:";
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            hoLabel.Location = new System.Drawing.Point(311, 145);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(41, 26);
            hoLabel.TabIndex = 8;
            hoLabel.Text = "Họ:";
            // 
            // maGVLabel
            // 
            maGVLabel.AutoSize = true;
            maGVLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maGVLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maGVLabel.Location = new System.Drawing.Point(207, 181);
            maGVLabel.Name = "maGVLabel";
            maGVLabel.Size = new System.Drawing.Size(145, 26);
            maGVLabel.TabIndex = 10;
            maGVLabel.Text = "Mã giảng viên:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngaySinhLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            ngaySinhLabel.Location = new System.Drawing.Point(244, 214);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(108, 26);
            ngaySinhLabel.TabIndex = 12;
            ngaySinhLabel.Text = "Ngày sinh:";
            // 
            // soDTLabel
            // 
            soDTLabel.AutoSize = true;
            soDTLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soDTLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            soDTLabel.Location = new System.Drawing.Point(220, 245);
            soDTLabel.Name = "soDTLabel";
            soDTLabel.Size = new System.Drawing.Size(132, 26);
            soDTLabel.TabIndex = 14;
            soDTLabel.Text = "Số điện thoại:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            tenLabel.Location = new System.Drawing.Point(302, 281);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(50, 26);
            tenLabel.TabIndex = 16;
            tenLabel.Text = "Tên:";
            // 
            // tinhTrangLabel
            // 
            this.tinhTrangLabel.AutoSize = true;
            this.tinhTrangLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhTrangLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.tinhTrangLabel.Location = new System.Drawing.Point(239, 317);
            this.tinhTrangLabel.Name = "tinhTrangLabel";
            this.tinhTrangLabel.Size = new System.Drawing.Size(113, 26);
            this.tinhTrangLabel.TabIndex = 18;
            this.tinhTrangLabel.Text = "Tình trạng:";
            // 
            // giangVienBindingSource1
            // 
            this.giangVienBindingSource1.DataSource = typeof(QuanLyTruongHoc.DataObjects.GiangVien);
            // 
            // gioiTinhComboBox
            // 
            this.gioiTinhComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBindingSource1, "GioiTinh", true));
            this.gioiTinhComboBox.FormattingEnabled = true;
            this.gioiTinhComboBox.Location = new System.Drawing.Point(358, 116);
            this.gioiTinhComboBox.Name = "gioiTinhComboBox";
            this.gioiTinhComboBox.Size = new System.Drawing.Size(228, 24);
            this.gioiTinhComboBox.TabIndex = 7;
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.giangVienBindingSource1, "NgaySinh", true));
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(358, 218);
            this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(228, 22);
            this.ngaySinhDateTimePicker.TabIndex = 13;
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.diaChiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiTextBox.Location = new System.Drawing.Point(358, 43);
            this.diaChiTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(228, 32);
            this.diaChiTextBox.TabIndex = 21;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(358, 80);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(228, 32);
            this.emailTextBox.TabIndex = 21;
            // 
            // hoTextBox
            // 
            this.hoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.hoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTextBox.Location = new System.Drawing.Point(358, 145);
            this.hoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoTextBox.Name = "hoTextBox";
            this.hoTextBox.Size = new System.Drawing.Size(228, 32);
            this.hoTextBox.TabIndex = 21;
            // 
            // maGVTextBox
            // 
            this.maGVTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maGVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maGVTextBox.Location = new System.Drawing.Point(358, 181);
            this.maGVTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maGVTextBox.Name = "maGVTextBox";
            this.maGVTextBox.Size = new System.Drawing.Size(228, 32);
            this.maGVTextBox.TabIndex = 21;
            // 
            // soDTTextBox
            // 
            this.soDTTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.soDTTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soDTTextBox.Location = new System.Drawing.Point(358, 245);
            this.soDTTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soDTTextBox.Name = "soDTTextBox";
            this.soDTTextBox.Size = new System.Drawing.Size(228, 32);
            this.soDTTextBox.TabIndex = 21;
            // 
            // tenTextBox
            // 
            this.tenTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.tenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenTextBox.Location = new System.Drawing.Point(358, 281);
            this.tenTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(228, 32);
            this.tenTextBox.TabIndex = 21;
            // 
            // tinhTrangTextBox
            // 
            this.tinhTrangTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.tinhTrangTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhTrangTextBox.Location = new System.Drawing.Point(358, 317);
            this.tinhTrangTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tinhTrangTextBox.Name = "tinhTrangTextBox";
            this.tinhTrangTextBox.Size = new System.Drawing.Size(228, 32);
            this.tinhTrangTextBox.TabIndex = 21;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(783, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 4;
            // 
            // ListGiangVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListGiangVienForm";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.guna2ControlBox1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {

                GiangVien gv = Helpers.Convert.ConverterHelper.ConvertDataRow<GiangVien>(row);
                ViewGiangVienForm viewGiangVienForm = new ViewGiangVienForm(gv);
                viewGiangVienForm.Show();
            }
            else
            {
                MessageBox.Show("Không có giảng viên nào được chọn");
            }
        }

        protected override void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            //if (row != null)
            //{
            //    GiangVien gv = ConverterHelper.ConvertDataRow<GiangVien>(row);
            //    UpdateGiangVienForm updateGiangVienForm = new UpdateGiangVienForm(gv);
            //    updateGiangVienForm.Show();

            //}
            //else
            //{
            //    MessageBox.Show("Không có giảng viên nào được chọn");
            //}
        }

        protected override void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                GiangVien gv = Helpers.Convert.ConverterHelper.ConvertDataRow<GiangVien>(row);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa giang vien này không?", "Xóa giang vien", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ADOGiangVien giangVien = MainForm.Manager.GiangVien;
                    if (giangVien.Delete(gv))
                    {
                        MessageBox.Show("Xóa giảng viên thành công");
                        dataGridView.DataSource = giangVien.Load();
                    }
                    else
                    {
                        MessageBox.Show("Xóa giảng viên thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có giảng viên nào được chọn");
            }
        }

        private void add_btn_Click_1(object sender, EventArgs e)
        {
            AddGiangVienForm addGiangVienForm = new AddGiangVienForm();
            addGiangVienForm.Show();
        }

        protected override GiangVien SearchObject()
        {
            return giangVienBindingSource1.Current as GiangVien;
        }

        private void diaChiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void search_btn_Click(object sender, EventArgs e)
        {
            base.search_btn_Click(sender, e);
            this.giangVienBindingSource1.DataSource = new GiangVien();
        }
    }
}
