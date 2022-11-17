using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Forms.FormSinhVien;
using QuanLyTruongHoc.Helpers.Convert;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormKhoa
{
    internal class ListKhoaForm : BaseListForm<Khoa>
    {
        private BindingSource khoaBindingSource;
        private CheckBox daXoaCheckBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private TextBox maKhoaTextBox;
        private TextBox tenKhoaTextBox;
        private System.ComponentModel.IContainer components;

        public ListKhoaForm():base()
        {
            InitializeComponent();
            dataGridView.DataSource = GetTable();
            khoaBindingSource.DataSource = new Khoa();
            InitList();
        }
        public override DataTable GetTable()
        {
            return MainForm.Manager.Khoa.Load();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label daXoaLabel;
            System.Windows.Forms.Label maKhoaLabel;
            System.Windows.Forms.Label tenKhoaLabel;
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daXoaCheckBox = new System.Windows.Forms.CheckBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.maKhoaTextBox = new System.Windows.Forms.TextBox();
            this.tenKhoaTextBox = new System.Windows.Forms.TextBox();
            daXoaLabel = new System.Windows.Forms.Label();
            maKhoaLabel = new System.Windows.Forms.Label();
            tenKhoaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(174)))), ((int)(((byte)(51)))));
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Roboto Slab Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(454, 162);
            this.search_btn.Size = new System.Drawing.Size(130, 30);
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Roboto Slab Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(312, 162);
            this.add_btn.Size = new System.Drawing.Size(130, 30);
            this.add_btn.UseVisualStyleBackColor = false;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Roboto Slab Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Location = new System.Drawing.Point(176, 162);
            this.refresh.Size = new System.Drawing.Size(130, 30);
            this.refresh.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tenKhoaTextBox);
            this.panel1.Controls.Add(this.maKhoaTextBox);
            this.panel1.Controls.Add(daXoaLabel);
            this.panel1.Controls.Add(this.daXoaCheckBox);
            this.panel1.Controls.Add(maKhoaLabel);
            this.panel1.Controls.Add(tenKhoaLabel);
            this.panel1.Size = new System.Drawing.Size(800, 220);
            this.panel1.Controls.SetChildIndex(this.refresh, 0);
            this.panel1.Controls.SetChildIndex(this.search_btn, 0);
            this.panel1.Controls.SetChildIndex(this.add_btn, 0);
            this.panel1.Controls.SetChildIndex(tenKhoaLabel, 0);
            this.panel1.Controls.SetChildIndex(maKhoaLabel, 0);
            this.panel1.Controls.SetChildIndex(this.daXoaCheckBox, 0);
            this.panel1.Controls.SetChildIndex(daXoaLabel, 0);
            this.panel1.Controls.SetChildIndex(this.maKhoaTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.tenKhoaTextBox, 0);
            // 
            // daXoaLabel
            // 
            daXoaLabel.AutoSize = true;
            daXoaLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            daXoaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            daXoaLabel.Location = new System.Drawing.Point(466, 57);
            daXoaLabel.Name = "daXoaLabel";
            daXoaLabel.Size = new System.Drawing.Size(79, 26);
            daXoaLabel.TabIndex = 2;
            daXoaLabel.Text = "Đã Xóa:";
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKhoaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maKhoaLabel.Location = new System.Drawing.Point(170, 59);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(97, 26);
            maKhoaLabel.TabIndex = 4;
            maKhoaLabel.Text = "Mã Khoa:";
            // 
            // tenKhoaLabel
            // 
            tenKhoaLabel.AutoSize = true;
            tenKhoaLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenKhoaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            tenKhoaLabel.Location = new System.Drawing.Point(165, 99);
            tenKhoaLabel.Name = "tenKhoaLabel";
            tenKhoaLabel.Size = new System.Drawing.Size(102, 26);
            tenKhoaLabel.TabIndex = 6;
            tenKhoaLabel.Text = "Tên Khoa:";
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.Khoa);
            // 
            // daXoaCheckBox
            // 
            this.daXoaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.khoaBindingSource, "DaXoa", true));
            this.daXoaCheckBox.Location = new System.Drawing.Point(551, 60);
            this.daXoaCheckBox.Name = "daXoaCheckBox";
            this.daXoaCheckBox.Size = new System.Drawing.Size(18, 24);
            this.daXoaCheckBox.TabIndex = 3;
            this.daXoaCheckBox.UseVisualStyleBackColor = true;
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
            this.guna2ControlBox1.TabIndex = 4;
            // 
            // maKhoaTextBox
            // 
            this.maKhoaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maKhoaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maKhoaTextBox.Location = new System.Drawing.Point(284, 55);
            this.maKhoaTextBox.Name = "maKhoaTextBox";
            this.maKhoaTextBox.Size = new System.Drawing.Size(176, 32);
            this.maKhoaTextBox.TabIndex = 21;
            // 
            // tenKhoaTextBox
            // 
            this.tenKhoaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.tenKhoaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenKhoaTextBox.Location = new System.Drawing.Point(284, 94);
            this.tenKhoaTextBox.Name = "tenKhoaTextBox";
            this.tenKhoaTextBox.Size = new System.Drawing.Size(291, 32);
            this.tenKhoaTextBox.TabIndex = 21;
            // 
            // ListKhoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListKhoaForm";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.guna2ControlBox1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        protected override void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                Khoa khoa = ConverterHelper.ConvertDataRow<Khoa>(row);
                ViewKhoaForm viewKhoaForm = new ViewKhoaForm(khoa);
                viewKhoaForm.Show();
            }
            else
            {
                MessageBox.Show("Không có khoa nào được chọn");
            }
        }
        protected override void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                Khoa khoa = ConverterHelper.ConvertDataRow<Khoa>(row);
                UpdateKhoaForm updateKhoaForm = new UpdateKhoaForm(khoa);
                updateKhoaForm.Show();
            }
            else
            {
                MessageBox.Show("Không có khoa nào được chọn");
            }
        }
        protected override void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                Khoa kh = ConverterHelper.ConvertDataRow<Khoa>(row);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này không?", "Xóa khoa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ADOKhoa khoa = MainForm.Manager.Khoa;
                    if (khoa.Delete(kh))
                    {
                        MessageBox.Show("Xóa khoa thành công");
                        dataGridView.DataSource = khoa.Load();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khoa thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có sinh viên nào được chọn");
            }
        }
        protected override Khoa SearchObject()
        {
            return khoaBindingSource.Current as Khoa;
        }
        protected override void add_btn_Click(object sender, EventArgs e)
        {
            AddKhoaForm addKhoaForm = new AddKhoaForm();
            addKhoaForm.Show();
        }

        protected override void search_btn_Click(object sender, EventArgs e)
        {
            base.search_btn_Click(sender, e);
            this.khoaBindingSource.DataSource = new Khoa();
        }
    }
}
