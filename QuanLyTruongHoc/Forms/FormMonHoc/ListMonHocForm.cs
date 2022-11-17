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


namespace QuanLyTruongHoc.Forms.FormMonHoc
{
     internal class ListMonHocForm : BaseListForm<MonHoc>
    {
        private BindingSource monHocBindingSource;
        private CheckBox tinhTrangCheckBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private TextBox tenMonHocTextBox;
        private TextBox soTinhChiTextBox;
        private TextBox maMonHocTextBox;
        private System.ComponentModel.IContainer components;

        public ListMonHocForm():base()
        {
            InitializeComponent();
            
            monHocBindingSource.DataSource = new MonHoc();
            InitList();
        }
        public override DataTable GetTable()
        {
            return MainForm.Manager.MonHoc.Load();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maMonHocLabel;
            System.Windows.Forms.Label soTinhChiLabel;
            System.Windows.Forms.Label tenMonHocLabel;
            System.Windows.Forms.Label tinhTrangLabel;
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tinhTrangCheckBox = new System.Windows.Forms.CheckBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.maMonHocTextBox = new System.Windows.Forms.TextBox();
            this.soTinhChiTextBox = new System.Windows.Forms.TextBox();
            this.tenMonHocTextBox = new System.Windows.Forms.TextBox();
            maMonHocLabel = new System.Windows.Forms.Label();
            soTinhChiLabel = new System.Windows.Forms.Label();
            tenMonHocLabel = new System.Windows.Forms.Label();
            tinhTrangLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Roboto Slab Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(472, 215);
            this.search_btn.Size = new System.Drawing.Size(130, 30);
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Roboto Slab Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(336, 215);
            this.add_btn.Size = new System.Drawing.Size(130, 30);
            this.add_btn.UseVisualStyleBackColor = false;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Roboto Slab Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Location = new System.Drawing.Point(200, 215);
            this.refresh.Size = new System.Drawing.Size(130, 30);
            this.refresh.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tenMonHocTextBox);
            this.panel1.Controls.Add(this.soTinhChiTextBox);
            this.panel1.Controls.Add(this.maMonHocTextBox);
            this.panel1.Controls.Add(maMonHocLabel);
            this.panel1.Controls.Add(soTinhChiLabel);
            this.panel1.Controls.Add(tenMonHocLabel);
            this.panel1.Controls.Add(tinhTrangLabel);
            this.panel1.Controls.Add(this.tinhTrangCheckBox);
            this.panel1.Size = new System.Drawing.Size(800, 290);
            this.panel1.Controls.SetChildIndex(this.refresh, 0);
            this.panel1.Controls.SetChildIndex(this.search_btn, 0);
            this.panel1.Controls.SetChildIndex(this.add_btn, 0);
            this.panel1.Controls.SetChildIndex(this.tinhTrangCheckBox, 0);
            this.panel1.Controls.SetChildIndex(tinhTrangLabel, 0);
            this.panel1.Controls.SetChildIndex(tenMonHocLabel, 0);
            this.panel1.Controls.SetChildIndex(soTinhChiLabel, 0);
            this.panel1.Controls.SetChildIndex(maMonHocLabel, 0);
            this.panel1.Controls.SetChildIndex(this.maMonHocTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.soTinhChiTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.tenMonHocTextBox, 0);
            // 
            // maMonHocLabel
            // 
            maMonHocLabel.AutoSize = true;
            maMonHocLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maMonHocLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maMonHocLabel.Location = new System.Drawing.Point(178, 80);
            maMonHocLabel.Name = "maMonHocLabel";
            maMonHocLabel.Size = new System.Drawing.Size(127, 26);
            maMonHocLabel.TabIndex = 2;
            maMonHocLabel.Text = "Mã môn học:";
            // 
            // soTinhChiLabel
            // 
            soTinhChiLabel.AutoSize = true;
            soTinhChiLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soTinhChiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            soTinhChiLabel.Location = new System.Drawing.Point(205, 117);
            soTinhChiLabel.Name = "soTinhChiLabel";
            soTinhChiLabel.Size = new System.Drawing.Size(100, 26);
            soTinhChiLabel.TabIndex = 4;
            soTinhChiLabel.Text = "Số tín chỉ:";
            // 
            // tenMonHocLabel
            // 
            tenMonHocLabel.AutoSize = true;
            tenMonHocLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenMonHocLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            tenMonHocLabel.Location = new System.Drawing.Point(173, 152);
            tenMonHocLabel.Name = "tenMonHocLabel";
            tenMonHocLabel.Size = new System.Drawing.Size(132, 26);
            tenMonHocLabel.TabIndex = 6;
            tenMonHocLabel.Text = "Tên môn học:";
            // 
            // tinhTrangLabel
            // 
            tinhTrangLabel.AutoSize = true;
            tinhTrangLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tinhTrangLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            tinhTrangLabel.Location = new System.Drawing.Point(500, 118);
            tinhTrangLabel.Name = "tinhTrangLabel";
            tinhTrangLabel.Size = new System.Drawing.Size(77, 26);
            tinhTrangLabel.TabIndex = 8;
            tinhTrangLabel.Text = "Đã xóa:";
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.MonHoc);
            // 
            // tinhTrangCheckBox
            // 
            this.tinhTrangCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.monHocBindingSource, "TinhTrang", true));
            this.tinhTrangCheckBox.Location = new System.Drawing.Point(583, 119);
            this.tinhTrangCheckBox.Name = "tinhTrangCheckBox";
            this.tinhTrangCheckBox.Size = new System.Drawing.Size(19, 24);
            this.tinhTrangCheckBox.TabIndex = 9;
            this.tinhTrangCheckBox.UseVisualStyleBackColor = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(755, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 4;
            // 
            // maMonHocTextBox
            // 
            this.maMonHocTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maMonHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maMonHocTextBox.Location = new System.Drawing.Point(311, 76);
            this.maMonHocTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maMonHocTextBox.Name = "maMonHocTextBox";
            this.maMonHocTextBox.Size = new System.Drawing.Size(291, 32);
            this.maMonHocTextBox.TabIndex = 14;
            // 
            // soTinhChiTextBox
            // 
            this.soTinhChiTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.soTinhChiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soTinhChiTextBox.Location = new System.Drawing.Point(311, 112);
            this.soTinhChiTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soTinhChiTextBox.Name = "soTinhChiTextBox";
            this.soTinhChiTextBox.Size = new System.Drawing.Size(183, 32);
            this.soTinhChiTextBox.TabIndex = 14;
            // 
            // tenMonHocTextBox
            // 
            this.tenMonHocTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.tenMonHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenMonHocTextBox.Location = new System.Drawing.Point(311, 148);
            this.tenMonHocTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tenMonHocTextBox.Name = "tenMonHocTextBox";
            this.tenMonHocTextBox.Size = new System.Drawing.Size(291, 32);
            this.tenMonHocTextBox.TabIndex = 14;
            // 
            // ListMonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListMonHocForm";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.guna2ControlBox1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        protected override void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                MonHoc mh = ConverterHelper.ConvertDataRow<MonHoc>(row);
                ViewMonHocForm viewMonHocForm = new ViewMonHocForm(mh);
                viewMonHocForm.Show();

            }
            else
            {
                MessageBox.Show("Không có giảng viên nào được chọn");
            }
        }

        protected override void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                MonHoc lh = ConverterHelper.ConvertDataRow<MonHoc>(row);
                ViewMonHocForm viewMonHocForm = new ViewMonHocForm(lh);
                viewMonHocForm.Show();

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
                MonHoc lh = Helpers.Convert.ConverterHelper.ConvertDataRow<MonHoc>(row);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ADOMonHoc MonHoc = MainForm.Manager.MonHoc;
                    if (MonHoc.Delete(lh))
                    {
                        MessageBox.Show("Xóa thành công");
                        dataGridView.DataSource = MonHoc.Load();
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
            AddMonHocForm addMonHocForm = new AddMonHocForm();
            addMonHocForm.Show();
        }
        protected override MonHoc SearchObject()
        {
            return monHocBindingSource.Current as MonHoc;
        }

        protected override void search_btn_Click(object sender, EventArgs e)
        {
            base.search_btn_Click(sender, e);
            this.monHocBindingSource.DataSource = new MonHoc();
        }
    }
}
