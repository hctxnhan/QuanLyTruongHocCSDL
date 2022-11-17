using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Helpers.Convert;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormLopHoc
{
    internal class ListLopHocForm : BaseListForm<LopHoc>
    {
        private BindingSource thongTinLopHocBindingSource;
        private BindingSource lopHocBindingSource;
        private CheckBox daXoaCheckBox;
        private TextBox maMonHocTextBox;
        private TextBox maLopTextBox;
        private TextBox maKyHocTextBox;
        private TextBox maGiangVienTextBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.ComponentModel.IContainer components;

        public ListLopHocForm() : base()
        {
            InitializeComponent();
            lopHocBindingSource.DataSource = new LopHoc();
            InitList();
            //dataGridView.DataSource = MainForm.Manager.LopHoc.Load();
        }
        public override DataTable GetTable()
        {
            return MainForm.Manager.LopHoc.Load();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label daXoaLabel;
            System.Windows.Forms.Label maGiangVienLabel;
            System.Windows.Forms.Label maKyHocLabel;
            System.Windows.Forms.Label maLopLabel;
            System.Windows.Forms.Label maMonHocLabel;
            this.thongTinLopHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daXoaCheckBox = new System.Windows.Forms.CheckBox();
            this.maGiangVienTextBox = new System.Windows.Forms.TextBox();
            this.maKyHocTextBox = new System.Windows.Forms.TextBox();
            this.maLopTextBox = new System.Windows.Forms.TextBox();
            this.maMonHocTextBox = new System.Windows.Forms.TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            daXoaLabel = new System.Windows.Forms.Label();
            maGiangVienLabel = new System.Windows.Forms.Label();
            maKyHocLabel = new System.Windows.Forms.Label();
            maLopLabel = new System.Windows.Forms.Label();
            maMonHocLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinLopHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Roboto Slab Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(296, 225);
            this.search_btn.Size = new System.Drawing.Size(130, 30);
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Roboto Slab Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(160, 225);
            this.add_btn.Size = new System.Drawing.Size(130, 30);
            this.add_btn.UseVisualStyleBackColor = false;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Roboto Slab Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Location = new System.Drawing.Point(432, 225);
            this.refresh.Size = new System.Drawing.Size(130, 30);
            this.refresh.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.maMonHocTextBox);
            this.panel1.Controls.Add(this.maLopTextBox);
            this.panel1.Controls.Add(this.maKyHocTextBox);
            this.panel1.Controls.Add(this.maGiangVienTextBox);
            this.panel1.Controls.Add(daXoaLabel);
            this.panel1.Controls.Add(this.daXoaCheckBox);
            this.panel1.Controls.Add(maGiangVienLabel);
            this.panel1.Controls.Add(maKyHocLabel);
            this.panel1.Controls.Add(maLopLabel);
            this.panel1.Controls.Add(maMonHocLabel);
            this.panel1.Size = new System.Drawing.Size(800, 291);
            this.panel1.Controls.SetChildIndex(this.refresh, 0);
            this.panel1.Controls.SetChildIndex(this.search_btn, 0);
            this.panel1.Controls.SetChildIndex(this.add_btn, 0);
            this.panel1.Controls.SetChildIndex(maMonHocLabel, 0);
            this.panel1.Controls.SetChildIndex(maLopLabel, 0);
            this.panel1.Controls.SetChildIndex(maKyHocLabel, 0);
            this.panel1.Controls.SetChildIndex(maGiangVienLabel, 0);
            this.panel1.Controls.SetChildIndex(this.daXoaCheckBox, 0);
            this.panel1.Controls.SetChildIndex(daXoaLabel, 0);
            this.panel1.Controls.SetChildIndex(this.maGiangVienTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.maKyHocTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.maLopTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.maMonHocTextBox, 0);
            // 
            // daXoaLabel
            // 
            daXoaLabel.AutoSize = true;
            daXoaLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            daXoaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            daXoaLabel.Location = new System.Drawing.Point(445, 95);
            daXoaLabel.Name = "daXoaLabel";
            daXoaLabel.Size = new System.Drawing.Size(77, 26);
            daXoaLabel.TabIndex = 2;
            daXoaLabel.Text = "Đã xóa:";
            // 
            // maGiangVienLabel
            // 
            maGiangVienLabel.AutoSize = true;
            maGiangVienLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maGiangVienLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maGiangVienLabel.Location = new System.Drawing.Point(120, 55);
            maGiangVienLabel.Name = "maGiangVienLabel";
            maGiangVienLabel.Size = new System.Drawing.Size(145, 26);
            maGiangVienLabel.TabIndex = 4;
            maGiangVienLabel.Text = "Mã giảng viên:";
            // 
            // maKyHocLabel
            // 
            maKyHocLabel.AutoSize = true;
            maKyHocLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKyHocLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maKyHocLabel.Location = new System.Drawing.Point(155, 91);
            maKyHocLabel.Name = "maKyHocLabel";
            maKyHocLabel.Size = new System.Drawing.Size(110, 26);
            maKyHocLabel.TabIndex = 6;
            maKyHocLabel.Text = "Mã kỳ học:";
            // 
            // maLopLabel
            // 
            maLopLabel.AutoSize = true;
            maLopLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maLopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maLopLabel.Location = new System.Drawing.Point(150, 127);
            maLopLabel.Name = "maLopLabel";
            maLopLabel.Size = new System.Drawing.Size(115, 26);
            maLopLabel.TabIndex = 8;
            maLopLabel.Text = "Mã lớp học:";
            // 
            // maMonHocLabel
            // 
            maMonHocLabel.AutoSize = true;
            maMonHocLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maMonHocLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maMonHocLabel.Location = new System.Drawing.Point(137, 163);
            maMonHocLabel.Name = "maMonHocLabel";
            maMonHocLabel.Size = new System.Drawing.Size(127, 26);
            maMonHocLabel.TabIndex = 10;
            maMonHocLabel.Text = "Mã môn học:";
            // 
            // thongTinLopHocBindingSource
            // 
            this.thongTinLopHocBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.ThongTinLopHoc);
            // 
            // lopHocBindingSource
            // 
            this.lopHocBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.LopHoc);
            // 
            // daXoaCheckBox
            // 
            this.daXoaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.lopHocBindingSource, "DaXoa", true));
            this.daXoaCheckBox.Location = new System.Drawing.Point(528, 98);
            this.daXoaCheckBox.Name = "daXoaCheckBox";
            this.daXoaCheckBox.Size = new System.Drawing.Size(19, 24);
            this.daXoaCheckBox.TabIndex = 3;
            this.daXoaCheckBox.UseVisualStyleBackColor = true;
            // 
            // maGiangVienTextBox
            // 
            this.maGiangVienTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maGiangVienTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maGiangVienTextBox.Location = new System.Drawing.Point(271, 55);
            this.maGiangVienTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maGiangVienTextBox.Name = "maGiangVienTextBox";
            this.maGiangVienTextBox.Size = new System.Drawing.Size(291, 32);
            this.maGiangVienTextBox.TabIndex = 12;
            // 
            // maKyHocTextBox
            // 
            this.maKyHocTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maKyHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maKyHocTextBox.Location = new System.Drawing.Point(271, 91);
            this.maKyHocTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maKyHocTextBox.Name = "maKyHocTextBox";
            this.maKyHocTextBox.Size = new System.Drawing.Size(158, 32);
            this.maKyHocTextBox.TabIndex = 12;
            // 
            // maLopTextBox
            // 
            this.maLopTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maLopTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maLopTextBox.Location = new System.Drawing.Point(271, 127);
            this.maLopTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maLopTextBox.Name = "maLopTextBox";
            this.maLopTextBox.Size = new System.Drawing.Size(291, 32);
            this.maLopTextBox.TabIndex = 12;
            // 
            // maMonHocTextBox
            // 
            this.maMonHocTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maMonHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maMonHocTextBox.Location = new System.Drawing.Point(270, 163);
            this.maMonHocTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maMonHocTextBox.Name = "maMonHocTextBox";
            this.maMonHocTextBox.Size = new System.Drawing.Size(291, 32);
            this.maMonHocTextBox.TabIndex = 12;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(755, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 36;
            // 
            // ListLopHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListLopHocForm";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.guna2ControlBox1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinLopHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        protected override void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                LopHoc lh = ConverterHelper.ConvertDataRow<LopHoc>(row);
                ViewLopHocForm viewLopHocForm = new ViewLopHocForm(lh);
                viewLopHocForm.Show();
            }
            else
            {
                MessageBox.Show("Không có lớp học nào được chọn");
            }
        }
        protected override void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                LopHoc lh = ConverterHelper.ConvertDataRow<LopHoc>(row);
                ViewLopHocForm viewLopHocForm = new ViewLopHocForm(lh);
                viewLopHocForm.Show();

            }
            else
            {
                MessageBox.Show("Không có giảng viên nào được chọn");
            }
        }



        protected override void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                LopHoc lh= Helpers.Convert.ConverterHelper.ConvertDataRow<LopHoc>(row);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ADOLopHoc LopHoc = MainForm.Manager.LopHoc;
                    if (LopHoc.Delete(lh))
                    {
                        MessageBox.Show("Xóa thành công");
                        dataGridView.DataSource = LopHoc.Load();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có điểm nào được chọn");
            }
        }

        protected override void add_btn_Click(object sender, EventArgs e)
        {
            AddLopHocForm addLopHocForm = new AddLopHocForm();
            addLopHocForm.Show();
        }
        protected override LopHoc SearchObject()
        {
            return lopHocBindingSource.Current as LopHoc;
        }

        private void maLopTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maKyHocTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void search_btn_Click(object sender, EventArgs e)
        {
            base.search_btn_Click(sender, e);
            this.lopHocBindingSource.DataSource = new LopHoc();
        }
    }
}
