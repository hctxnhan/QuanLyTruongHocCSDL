using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Helpers.Convert;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormKhoa
{
    internal class UpdateKhoaForm : DetailInfoForm<Khoa>
    {
        private TextBox maKhoaTextBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private TextBox tenKhoaTextBox;
        private CheckBox daXoaCheckBox;
        private Button update_button;

        public UpdateKhoaForm(Khoa khoa) : base()
        {
            
            InitializeComponent();
            this.LoadDataFromObject(khoa);
            Init();
        }
        protected override void Init()
        {
            this.maKhoaTextBox.Enabled = false;
            this.daXoaCheckBox.Enabled = false;
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.Label maKhoaLabel;
            System.Windows.Forms.Label tenKhoaLabel;
            System.Windows.Forms.Label label1;
            this.update_button = new System.Windows.Forms.Button();
            this.maKhoaTextBox = new System.Windows.Forms.TextBox();
            this.tenKhoaTextBox = new System.Windows.Forms.TextBox();
            this.daXoaCheckBox = new System.Windows.Forms.CheckBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            maKhoaLabel = new System.Windows.Forms.Label();
            tenKhoaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Controls.Add(this.tenKhoaTextBox);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.daXoaCheckBox);
            this.panel1.Controls.Add(this.maKhoaTextBox);
            this.panel1.Controls.Add(maKhoaLabel);
            this.panel1.Controls.Add(tenKhoaLabel);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Size = new System.Drawing.Size(725, 219);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.update_button);
            this.panel2.Location = new System.Drawing.Point(0, 219);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Size = new System.Drawing.Size(725, 426);
            this.panel2.Controls.SetChildIndex(this.update_button, 0);
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKhoaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maKhoaLabel.Location = new System.Drawing.Point(167, 85);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(97, 26);
            maKhoaLabel.TabIndex = 2;
            maKhoaLabel.Text = "Mã Khoa:";
            // 
            // tenKhoaLabel
            // 
            tenKhoaLabel.AutoSize = true;
            tenKhoaLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenKhoaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            tenKhoaLabel.Location = new System.Drawing.Point(162, 128);
            tenKhoaLabel.Name = "tenKhoaLabel";
            tenKhoaLabel.Size = new System.Drawing.Size(102, 26);
            tenKhoaLabel.TabIndex = 4;
            tenKhoaLabel.Text = "Tên Khoa:";
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(211, 13);
            this.update_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(88, 29);
            this.update_button.TabIndex = 1;
            this.update_button.Text = "Cập nhật";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // maKhoaTextBox
            // 
            this.maKhoaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maKhoaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maKhoaTextBox.Location = new System.Drawing.Point(279, 85);
            this.maKhoaTextBox.Name = "maKhoaTextBox";
            this.maKhoaTextBox.Size = new System.Drawing.Size(176, 32);
            this.maKhoaTextBox.TabIndex = 22;
            // 
            // tenKhoaTextBox
            // 
            this.tenKhoaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.tenKhoaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenKhoaTextBox.Location = new System.Drawing.Point(279, 128);
            this.tenKhoaTextBox.Name = "tenKhoaTextBox";
            this.tenKhoaTextBox.Size = new System.Drawing.Size(291, 32);
            this.tenKhoaTextBox.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            label1.Location = new System.Drawing.Point(461, 91);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 26);
            label1.TabIndex = 23;
            label1.Text = "Đã Xóa:";
            // 
            // daXoaCheckBox
            // 
            this.daXoaCheckBox.Location = new System.Drawing.Point(546, 94);
            this.daXoaCheckBox.Name = "daXoaCheckBox";
            this.daXoaCheckBox.Size = new System.Drawing.Size(18, 24);
            this.daXoaCheckBox.TabIndex = 24;
            this.daXoaCheckBox.UseVisualStyleBackColor = true;
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
            this.guna2ControlBox1.TabIndex = 26;
            // 
            // UpdateKhoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(725, 645);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateKhoaForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            Khoa khoa = bindingSource.Current as Khoa;
            if (khoa == null) return;

            ValidationContext context = new ValidationContext(khoa, null, null);
            IList<ValidationResult> validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(khoa, context, validationResults, true))
            {
                foreach (var item in validationResults)
                {
                    MessageBox.Show(item.ErrorMessage);
                    return;
                }
            }

            if (MainForm.Manager.Khoa.Update(khoa))
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
