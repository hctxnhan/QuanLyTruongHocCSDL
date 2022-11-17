using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormLopHoc
{
    internal class AddLopHocForm : DetailInfoForm<LopHoc>
    {

        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private System.Windows.Forms.Button add_button;
        private TextBox maMonHocTextBox;
        private TextBox maKyHocTextBox;
        private TextBox maGiangVienTextBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.ComponentModel.IContainer components;

        //public AddLopHocForm(LopHoc lh) : base()
        //{
        //    InitializeComponent();
        //    bindingSource.DataSource = new LopHoc();
        //}
        public AddLopHocForm(LopHoc lh) : base()
        {
            InitializeComponent();
            this.LoadDataFromObject(lh);
            Init();
        } 
        public AddLopHocForm() : base()
        {
            InitializeComponent();
            Init();

        }


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maGiangVienLabel;
            System.Windows.Forms.Label maKyHocLabel;
            System.Windows.Forms.Label maMonHocLabel;
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_button = new System.Windows.Forms.Button();
            this.maGiangVienTextBox = new System.Windows.Forms.TextBox();
            this.maKyHocTextBox = new System.Windows.Forms.TextBox();
            this.maMonHocTextBox = new System.Windows.Forms.TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            maGiangVienLabel = new System.Windows.Forms.Label();
            maKyHocLabel = new System.Windows.Forms.Label();
            maMonHocLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Controls.Add(this.maMonHocTextBox);
            this.panel1.Controls.Add(this.maKyHocTextBox);
            this.panel1.Controls.Add(this.maGiangVienTextBox);
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Controls.Add(maGiangVienLabel);
            this.panel1.Controls.Add(maKyHocLabel);
            this.panel1.Controls.Add(maMonHocLabel);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Size = new System.Drawing.Size(725, 340);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 340);
            this.panel2.Size = new System.Drawing.Size(725, 348);
            // 
            // maGiangVienLabel
            // 
            maGiangVienLabel.AutoSize = true;
            maGiangVienLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maGiangVienLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maGiangVienLabel.Location = new System.Drawing.Point(102, 114);
            maGiangVienLabel.Name = "maGiangVienLabel";
            maGiangVienLabel.Size = new System.Drawing.Size(145, 26);
            maGiangVienLabel.TabIndex = 0;
            maGiangVienLabel.Text = "Mã giảng viên:";
            // 
            // maKyHocLabel
            // 
            maKyHocLabel.AutoSize = true;
            maKyHocLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKyHocLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maKyHocLabel.Location = new System.Drawing.Point(137, 153);
            maKyHocLabel.Name = "maKyHocLabel";
            maKyHocLabel.Size = new System.Drawing.Size(110, 26);
            maKyHocLabel.TabIndex = 2;
            maKyHocLabel.Text = "Mã kỳ học:";
            // 
            // maMonHocLabel
            // 
            maMonHocLabel.AutoSize = true;
            maMonHocLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maMonHocLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maMonHocLabel.Location = new System.Drawing.Point(120, 192);
            maMonHocLabel.Name = "maMonHocLabel";
            maMonHocLabel.Size = new System.Drawing.Size(127, 26);
            maMonHocLabel.TabIndex = 6;
            maMonHocLabel.Text = "Mã môn học:";
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.SinhVien);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Roboto Slab Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(404, 241);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(140, 36);
            this.add_button.TabIndex = 8;
            this.add_button.Text = "Thêm";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // maGiangVienTextBox
            // 
            this.maGiangVienTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maGiangVienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "HocPhi", true));
            this.maGiangVienTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maGiangVienTextBox.Location = new System.Drawing.Point(253, 114);
            this.maGiangVienTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maGiangVienTextBox.Name = "maGiangVienTextBox";
            this.maGiangVienTextBox.Size = new System.Drawing.Size(291, 32);
            this.maGiangVienTextBox.TabIndex = 9;
            // 
            // maKyHocTextBox
            // 
            this.maKyHocTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maKyHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maKyHocTextBox.Location = new System.Drawing.Point(253, 153);
            this.maKyHocTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maKyHocTextBox.Name = "maKyHocTextBox";
            this.maKyHocTextBox.Size = new System.Drawing.Size(291, 32);
            this.maKyHocTextBox.TabIndex = 9;
            // 
            // maMonHocTextBox
            // 
            this.maMonHocTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maMonHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maMonHocTextBox.Location = new System.Drawing.Point(253, 192);
            this.maMonHocTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maMonHocTextBox.Name = "maMonHocTextBox";
            this.maMonHocTextBox.Size = new System.Drawing.Size(291, 32);
            this.maMonHocTextBox.TabIndex = 9;
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
            this.guna2ControlBox1.TabIndex = 37;
            // 
            // AddLopHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(725, 688);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddLopHocForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }
        private void add_button_Click(object sender, EventArgs e)
        {
           
            LopHoc lh = new LopHoc();
            lh.MaGiangVien = int.Parse(maGiangVienTextBox.Text);
            lh.MaKyHoc=byte.Parse(maKyHocTextBox.Text);
            //lh.MaKyHoc = Int32.Parse(maKyHocTextBox.Text);
            //lh.MaLop = Int32.Parse(maLopTextBox.Text);
            lh.MaMonHoc = Int32.Parse(maMonHocTextBox.Text);
           // lh.DaXoa = daXoaCheckBox.Enabled;

            if (lh == null) return;
            ValidationContext context = new ValidationContext(lh, null, null);
            IList<ValidationResult> validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(lh, context, validationResults, true))
            {
                foreach (var item in validationResults)
                {
                    MessageBox.Show(item.ErrorMessage);
                    return;
                }
            }

            if (MainForm.Manager.LopHoc.Add(lh))
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
