using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Forms.FormKhoa;
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

namespace QuanLyTruongHoc.Forms.FormKyHoc
{
    internal class ListKyHocForm : BaseListForm<KyHoc>
    {
        private BindingSource kyHocBindingSource;
        private BindingSource khoaBindingSource;
        private TextBox namHocTextBox;
        private TextBox maKyHocTextBox;
        private TextBox kyHocTextBox;
        private TextBox hocPhiTextBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.ComponentModel.IContainer components;

        public ListKyHocForm():base()
        {
            InitializeComponent();
            kyHocBindingSource.DataSource = new KyHoc();
            InitList();
        }
        public override DataTable GetTable()
        {
            return MainForm.Manager.KyHoc.Load()
;        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label hocPhiLabel;
            System.Windows.Forms.Label kyHocLabel;
            System.Windows.Forms.Label maKyHocLabel;
            System.Windows.Forms.Label namHocLabel;
            this.kyHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hocPhiTextBox = new System.Windows.Forms.TextBox();
            this.kyHocTextBox = new System.Windows.Forms.TextBox();
            this.maKyHocTextBox = new System.Windows.Forms.TextBox();
            this.namHocTextBox = new System.Windows.Forms.TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            hocPhiLabel = new System.Windows.Forms.Label();
            kyHocLabel = new System.Windows.Forms.Label();
            maKyHocLabel = new System.Windows.Forms.Label();
            namHocLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kyHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Roboto Slab Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(473, 215);
            this.search_btn.Size = new System.Drawing.Size(130, 30);
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Roboto Slab Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(337, 215);
            this.add_btn.Size = new System.Drawing.Size(130, 30);
            this.add_btn.UseVisualStyleBackColor = false;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Roboto Slab Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Location = new System.Drawing.Point(201, 215);
            this.refresh.Size = new System.Drawing.Size(130, 30);
            this.refresh.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.namHocTextBox);
            this.panel1.Controls.Add(this.maKyHocTextBox);
            this.panel1.Controls.Add(this.kyHocTextBox);
            this.panel1.Controls.Add(this.hocPhiTextBox);
            this.panel1.Controls.Add(hocPhiLabel);
            this.panel1.Controls.Add(kyHocLabel);
            this.panel1.Controls.Add(maKyHocLabel);
            this.panel1.Controls.Add(namHocLabel);
            this.panel1.Size = new System.Drawing.Size(800, 262);
            this.panel1.Controls.SetChildIndex(this.refresh, 0);
            this.panel1.Controls.SetChildIndex(this.search_btn, 0);
            this.panel1.Controls.SetChildIndex(this.add_btn, 0);
            this.panel1.Controls.SetChildIndex(namHocLabel, 0);
            this.panel1.Controls.SetChildIndex(maKyHocLabel, 0);
            this.panel1.Controls.SetChildIndex(kyHocLabel, 0);
            this.panel1.Controls.SetChildIndex(hocPhiLabel, 0);
            this.panel1.Controls.SetChildIndex(this.hocPhiTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.kyHocTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.maKyHocTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.namHocTextBox, 0);
            // 
            // hocPhiLabel
            // 
            hocPhiLabel.AutoSize = true;
            hocPhiLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hocPhiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            hocPhiLabel.Location = new System.Drawing.Point(212, 50);
            hocPhiLabel.Name = "hocPhiLabel";
            hocPhiLabel.Size = new System.Drawing.Size(86, 26);
            hocPhiLabel.TabIndex = 2;
            hocPhiLabel.Text = "Học Phí:";
            // 
            // kyHocLabel
            // 
            kyHocLabel.AutoSize = true;
            kyHocLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kyHocLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            kyHocLabel.Location = new System.Drawing.Point(217, 89);
            kyHocLabel.Name = "kyHocLabel";
            kyHocLabel.Size = new System.Drawing.Size(81, 26);
            kyHocLabel.TabIndex = 4;
            kyHocLabel.Text = "Kỳ Học:";
            // 
            // maKyHocLabel
            // 
            maKyHocLabel.AutoSize = true;
            maKyHocLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKyHocLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maKyHocLabel.Location = new System.Drawing.Point(183, 126);
            maKyHocLabel.Name = "maKyHocLabel";
            maKyHocLabel.Size = new System.Drawing.Size(115, 26);
            maKyHocLabel.TabIndex = 6;
            maKyHocLabel.Text = "Mã Kỳ Học:";
            // 
            // namHocLabel
            // 
            namHocLabel.AutoSize = true;
            namHocLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            namHocLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            namHocLabel.Location = new System.Drawing.Point(196, 164);
            namHocLabel.Name = "namHocLabel";
            namHocLabel.Size = new System.Drawing.Size(100, 26);
            namHocLabel.TabIndex = 8;
            namHocLabel.Text = "Năm Học:";
            // 
            // kyHocBindingSource
            // 
            this.kyHocBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.KyHoc);
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.Khoa);
            // 
            // hocPhiTextBox
            // 
            this.hocPhiTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.hocPhiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hocPhiTextBox.Location = new System.Drawing.Point(312, 50);
            this.hocPhiTextBox.Name = "hocPhiTextBox";
            this.hocPhiTextBox.Size = new System.Drawing.Size(291, 32);
            this.hocPhiTextBox.TabIndex = 26;
            // 
            // kyHocTextBox
            // 
            this.kyHocTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.kyHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kyHocTextBox.Location = new System.Drawing.Point(312, 88);
            this.kyHocTextBox.Name = "kyHocTextBox";
            this.kyHocTextBox.Size = new System.Drawing.Size(291, 32);
            this.kyHocTextBox.TabIndex = 26;
            // 
            // maKyHocTextBox
            // 
            this.maKyHocTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maKyHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maKyHocTextBox.Location = new System.Drawing.Point(312, 126);
            this.maKyHocTextBox.Name = "maKyHocTextBox";
            this.maKyHocTextBox.Size = new System.Drawing.Size(291, 32);
            this.maKyHocTextBox.TabIndex = 26;
            // 
            // namHocTextBox
            // 
            this.namHocTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.namHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namHocTextBox.Location = new System.Drawing.Point(312, 164);
            this.namHocTextBox.Name = "namHocTextBox";
            this.namHocTextBox.Size = new System.Drawing.Size(291, 32);
            this.namHocTextBox.TabIndex = 26;
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
            // ListKyHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListKyHocForm";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.guna2ControlBox1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kyHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        protected override void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                KyHoc ky = ConverterHelper.ConvertDataRow<KyHoc>(row);
                ViewKyHocForm viewKyHocForm = new ViewKyHocForm(ky);
                viewKyHocForm.Show();
            }
            else
            {
                MessageBox.Show("Không có kỳ học nào được chọn");
            }
        }
        protected override void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                KyHoc kyHoc = ConverterHelper.ConvertDataRow<KyHoc>(row);
                UpdateKyHocForm updateKyHocForm = new UpdateKyHocForm(kyHoc);
                updateKyHocForm.Show();
            }
            else
            {
                MessageBox.Show("Không có kỳ học nào được chọn");
            }
        }
        protected override void add_btn_Click(object sender, EventArgs e)
        {
            AddKyHocForm addKyHocForm = new AddKyHocForm();
            addKyHocForm.Show();
        }
        protected override KyHoc SearchObject()
        {
            return kyHocBindingSource.Current as KyHoc;
        }

        protected override void search_btn_Click(object sender, EventArgs e)
        {
            base.search_btn_Click(sender, e);
            this.kyHocBindingSource.DataSource = new KyHoc();
        }
    }
}
