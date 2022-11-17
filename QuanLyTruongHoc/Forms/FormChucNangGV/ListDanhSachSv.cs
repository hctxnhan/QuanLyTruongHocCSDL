using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using QuanLyTruongHoc.Models.DatabaseModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTruongHoc.Helpers.Convert;

namespace QuanLyTruongHoc.Forms.FormChucNangGV
{
    internal class ListDanhSachSv : BaseListForm<SinhVien>
    {
        private BindingSource danhSachLopBindingSource;
        private System.ComponentModel.IContainer components;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private ThongTinLopHoc thongTin;
        public ListDanhSachSv(ThongTinLopHoc thongTinLopHoc) : base()
        {
            InitializeComponent();
            thongTin = thongTinLopHoc;
            InitList();
        }


        public override DataTable GetTable()
        {
            return MainForm.Manager.GiangVien.GetDanhSachSV(thongTin);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.danhSachLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachLopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(174)))), ((int)(((byte)(51)))));
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Roboto Slab Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(760, 230);
            this.search_btn.Size = new System.Drawing.Size(126, 55);
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Roboto Slab Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(628, 230);
            this.add_btn.Size = new System.Drawing.Size(126, 55);
            this.add_btn.Text = "Chấm điểm";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click_1);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Roboto Slab Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(495, 230);
            this.refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.refresh.Size = new System.Drawing.Size(126, 55);
            this.refresh.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Font = new System.Drawing.Font("Roboto Slab Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Size = new System.Drawing.Size(900, 301);
            // 
            // danhSachLopBindingSource
            // 
            this.danhSachLopBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.DanhSachLop);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(855, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 4;
            // 
            // ListDanhSachSv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(900, 591);
            this.Controls.Add(this.guna2ControlBox1);
            this.Font = new System.Drawing.Font("Roboto Slab", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListDanhSachSv";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.guna2ControlBox1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachLopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void add_btn_Click_1(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                DanhSachLop danhSachLop = ConverterHelper.ConvertDataRow<DanhSachLop>(row);

                FormChamDiem formChamDiem = new FormChamDiem(danhSachLop);
                formChamDiem.Show();
            }
            else
            {
                MessageBox.Show("Không có sinh viên nào được chọn");
            }
        }
    }
}
