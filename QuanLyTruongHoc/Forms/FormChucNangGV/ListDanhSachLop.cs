using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using QuanLyTruongHoc.Models.DatabaseModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormChucNangGV
{
    internal class ListDanhSachLop : BaseListForm<LopHoc>
    {
        private BindingSource thongTinLopHocBindingSource;
        private System.ComponentModel.IContainer components;
        private int id;

        public ListDanhSachLop() : base()
        {
            InitializeComponent();
            InitList();
        }
        public override DataTable GetTable()
        {
            return MainForm.Manager.GiangVien.GetDanhSachLop(MainForm.Manager.CurrentLogin);
        }

        public ListDanhSachLop(int id)
        {
            this.id = id;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.thongTinLopHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinLopHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(174)))), ((int)(((byte)(51)))));
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Roboto Slab Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(676, 177);
            this.search_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_btn.Size = new System.Drawing.Size(112, 43);
            this.search_btn.Text = " Tìm kiếm";
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Roboto Slab Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(558, 178);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Size = new System.Drawing.Size(112, 43);
            this.add_btn.Text = "Kết thúc lớp";
            this.add_btn.UseVisualStyleBackColor = false;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Roboto Slab Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Location = new System.Drawing.Point(440, 178);
            this.refresh.Size = new System.Drawing.Size(112, 42);
            this.refresh.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Font = new System.Drawing.Font("Roboto Slab", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 30);
            // 
            // thongTinLopHocBindingSource
            // 
            this.thongTinLopHocBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.ThongTinLopHoc);
            // 
            // ListDanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListDanhSachLop";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thongTinLopHocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        protected override void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                ThongTinLopHoc thongTinLopHoc = Helpers.Convert.ConverterHelper.ConvertDataRow<ThongTinLopHoc>(row);
                MessageBox.Show(thongTinLopHoc.maLop.ToString());
                ListDanhSachSv listDanhSachSv = new ListDanhSachSv(thongTinLopHoc);
                listDanhSachSv.Show();
            }
            else
            {
                MessageBox.Show("Không có giảng viên nào được chọn");
            }
        }

        protected override void add_btn_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {

                ThongTinLopHoc thongTinLopHoc = Helpers.Convert.ConverterHelper.ConvertDataRow<ThongTinLopHoc>(row);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn kết thúc lớp này không?", "Kết thúc lớp", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (MainForm.Manager.GiangVien.KetThucLop(thongTinLopHoc))
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                    
                }    
                  
            }
            else
            {
                MessageBox.Show("Không có giảng viên nào được chọn");
            }
        }

    }
}
