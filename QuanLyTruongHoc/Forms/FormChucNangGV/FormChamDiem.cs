using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Helpers.Convert;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormChucNangGV
{
    internal class FormChamDiem : DetailInfoForm<DanhSachLop>
    {
        private TextBox diemCKTextBox;
        private TextBox diemGKTextBox;
        private TextBox hoTextBox;
        private TextBox maLopTextBox;
        private TextBox maSVTextBox;
        private TextBox tenTextBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Button update_btn;

        public FormChamDiem() : base()
        {
            InitializeComponent();
        }
        public FormChamDiem(DanhSachLop danhSachLop) : base()
        {
            InitializeComponent();
            this.LoadDataFromObject(danhSachLop);
            Init();
        }
        protected override void Init()
        {
            this.maLopTextBox.Enabled = false;
            this.maSVTextBox.Enabled = false;
            this.hoTextBox.Enabled = false;
            this.tenTextBox.Enabled = false;
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.Label diemCKLabel;
            System.Windows.Forms.Label diemGKLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label maLopLabel;
            System.Windows.Forms.Label maSVLabel;
            System.Windows.Forms.Label tenLabel;
            this.update_btn = new System.Windows.Forms.Button();
            this.diemCKTextBox = new System.Windows.Forms.TextBox();
            this.diemGKTextBox = new System.Windows.Forms.TextBox();
            this.hoTextBox = new System.Windows.Forms.TextBox();
            this.maLopTextBox = new System.Windows.Forms.TextBox();
            this.maSVTextBox = new System.Windows.Forms.TextBox();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            diemCKLabel = new System.Windows.Forms.Label();
            diemGKLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            maLopLabel = new System.Windows.Forms.Label();
            maSVLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.CurrentChanged += new System.EventHandler(this.bindingSource_CurrentChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Controls.Add(diemCKLabel);
            this.panel1.Controls.Add(this.diemCKTextBox);
            this.panel1.Controls.Add(diemGKLabel);
            this.panel1.Controls.Add(this.diemGKTextBox);
            this.panel1.Controls.Add(hoLabel);
            this.panel1.Controls.Add(this.hoTextBox);
            this.panel1.Controls.Add(maLopLabel);
            this.panel1.Controls.Add(this.maLopTextBox);
            this.panel1.Controls.Add(maSVLabel);
            this.panel1.Controls.Add(this.maSVTextBox);
            this.panel1.Controls.Add(tenLabel);
            this.panel1.Controls.Add(this.tenTextBox);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Size = new System.Drawing.Size(725, 441);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.update_btn);
            this.panel2.Location = new System.Drawing.Point(0, 441);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Size = new System.Drawing.Size(725, 175);
            this.panel2.Controls.SetChildIndex(this.update_btn, 0);
            // 
            // diemCKLabel
            // 
            diemCKLabel.AutoSize = true;
            diemCKLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diemCKLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            diemCKLabel.Location = new System.Drawing.Point(84, 344);
            diemCKLabel.Name = "diemCKLabel";
            diemCKLabel.Size = new System.Drawing.Size(134, 26);
            diemCKLabel.TabIndex = 0;
            diemCKLabel.Text = "Điểm cuối kỳ:";
            // 
            // diemGKLabel
            // 
            diemGKLabel.AutoSize = true;
            diemGKLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diemGKLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            diemGKLabel.Location = new System.Drawing.Point(84, 290);
            diemGKLabel.Name = "diemGKLabel";
            diemGKLabel.Size = new System.Drawing.Size(136, 26);
            diemGKLabel.TabIndex = 2;
            diemGKLabel.Text = "Điểm giữa kỳ:";
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            hoLabel.Location = new System.Drawing.Point(176, 174);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(41, 26);
            hoLabel.TabIndex = 4;
            hoLabel.Text = "Họ:";
            // 
            // maLopLabel
            // 
            maLopLabel.AutoSize = true;
            maLopLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maLopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maLopLabel.Location = new System.Drawing.Point(139, 70);
            maLopLabel.Name = "maLopLabel";
            maLopLabel.Size = new System.Drawing.Size(78, 26);
            maLopLabel.TabIndex = 6;
            maLopLabel.Text = "Mã lớp:";
            // 
            // maSVLabel
            // 
            maSVLabel.AutoSize = true;
            maSVLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maSVLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maSVLabel.Location = new System.Drawing.Point(84, 126);
            maSVLabel.Name = "maSVLabel";
            maSVLabel.Size = new System.Drawing.Size(133, 26);
            maSVLabel.TabIndex = 8;
            maSVLabel.Text = "Mã sinh viên:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            tenLabel.Location = new System.Drawing.Point(167, 230);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(50, 26);
            tenLabel.TabIndex = 10;
            tenLabel.Text = "Tên:";
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Roboto Slab", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(557, 16);
            this.update_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(135, 39);
            this.update_btn.TabIndex = 1;
            this.update_btn.Text = "Cập nhật";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // diemCKTextBox
            // 
            this.diemCKTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.diemCKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "diemCK", true));
            this.diemCKTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diemCKTextBox.Location = new System.Drawing.Point(225, 344);
            this.diemCKTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diemCKTextBox.Name = "diemCKTextBox";
            this.diemCKTextBox.Size = new System.Drawing.Size(389, 32);
            this.diemCKTextBox.TabIndex = 1;
            // 
            // diemGKTextBox
            // 
            this.diemGKTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.diemGKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "diemGK", true));
            this.diemGKTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diemGKTextBox.Location = new System.Drawing.Point(225, 288);
            this.diemGKTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diemGKTextBox.Name = "diemGKTextBox";
            this.diemGKTextBox.Size = new System.Drawing.Size(389, 32);
            this.diemGKTextBox.TabIndex = 3;
            // 
            // hoTextBox
            // 
            this.hoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.hoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Ho", true));
            this.hoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTextBox.Location = new System.Drawing.Point(225, 174);
            this.hoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoTextBox.Name = "hoTextBox";
            this.hoTextBox.Size = new System.Drawing.Size(389, 32);
            this.hoTextBox.TabIndex = 5;
            // 
            // maLopTextBox
            // 
            this.maLopTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maLopTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "maLop", true));
            this.maLopTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maLopTextBox.Location = new System.Drawing.Point(225, 70);
            this.maLopTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maLopTextBox.Name = "maLopTextBox";
            this.maLopTextBox.Size = new System.Drawing.Size(389, 32);
            this.maLopTextBox.TabIndex = 7;
            // 
            // maSVTextBox
            // 
            this.maSVTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maSVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "maSV", true));
            this.maSVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maSVTextBox.Location = new System.Drawing.Point(225, 120);
            this.maSVTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maSVTextBox.Name = "maSVTextBox";
            this.maSVTextBox.Size = new System.Drawing.Size(389, 32);
            this.maSVTextBox.TabIndex = 9;
            // 
            // tenTextBox
            // 
            this.tenTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Ten", true));
            this.tenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenTextBox.Location = new System.Drawing.Point(225, 230);
            this.tenTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(389, 32);
            this.tenTextBox.TabIndex = 11;
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
            this.guna2ControlBox1.TabIndex = 12;
            // 
            // FormChamDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(725, 616);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormChamDiem";
            this.Text = "`";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            DanhSachLop danhSachLop = bindingSource.Current as DanhSachLop;
            if (danhSachLop == null) return;

            ValidationContext context = new ValidationContext(danhSachLop, null, null);
            IList<ValidationResult> validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(danhSachLop, context, validationResults, true))
            {
                foreach (var item in validationResults)
                {
                    MessageBox.Show(item.ErrorMessage);
                    return;
                }
            }

            if (MainForm.Manager.GiangVien.ChamDiem(danhSachLop))
            {
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
