using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormMonHoc
{
    internal class AddMonHocForm : DetailInfoForm<MonHoc>
    {
        private TextBox tenMonHocTextBox;
        private TextBox soTinhChiTextBox;
        private Button add_button;

        public AddMonHocForm() : base()
        {
            InitializeComponent();
            //this.LoadDataFromObject(diem);
            //tinhTrangTextBox.Text = "Dang giang day";
            //tinhTrangCheckBox.Enabled = false;
            Init();
        }


        private void InitializeComponent()
        {
            System.Windows.Forms.Label soTinhChiLabel;
            System.Windows.Forms.Label tenMonHocLabel;
            this.add_button = new System.Windows.Forms.Button();
            this.soTinhChiTextBox = new System.Windows.Forms.TextBox();
            this.tenMonHocTextBox = new System.Windows.Forms.TextBox();
            soTinhChiLabel = new System.Windows.Forms.Label();
            tenMonHocLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tenMonHocTextBox);
            this.panel1.Controls.Add(this.soTinhChiTextBox);
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Controls.Add(soTinhChiLabel);
            this.panel1.Controls.Add(tenMonHocLabel);
            this.panel1.Size = new System.Drawing.Size(725, 244);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 244);
            this.panel2.Size = new System.Drawing.Size(725, 444);
            // 
            // soTinhChiLabel
            // 
            soTinhChiLabel.AutoSize = true;
            soTinhChiLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soTinhChiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            soTinhChiLabel.Location = new System.Drawing.Point(150, 110);
            soTinhChiLabel.Name = "soTinhChiLabel";
            soTinhChiLabel.Size = new System.Drawing.Size(100, 26);
            soTinhChiLabel.TabIndex = 2;
            soTinhChiLabel.Text = "Số tín chỉ:";
            // 
            // tenMonHocLabel
            // 
            tenMonHocLabel.AutoSize = true;
            tenMonHocLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenMonHocLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            tenMonHocLabel.Location = new System.Drawing.Point(118, 149);
            tenMonHocLabel.Name = "tenMonHocLabel";
            tenMonHocLabel.Size = new System.Drawing.Size(132, 26);
            tenMonHocLabel.TabIndex = 4;
            tenMonHocLabel.Text = "Tên môn học:";
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Roboto Slab Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(417, 186);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(130, 30);
            this.add_button.TabIndex = 8;
            this.add_button.Text = "Thêm";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // soTinhChiTextBox
            // 
            this.soTinhChiTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.soTinhChiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soTinhChiTextBox.Location = new System.Drawing.Point(256, 110);
            this.soTinhChiTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soTinhChiTextBox.Name = "soTinhChiTextBox";
            this.soTinhChiTextBox.Size = new System.Drawing.Size(290, 32);
            this.soTinhChiTextBox.TabIndex = 13;
            // 
            // tenMonHocTextBox
            // 
            this.tenMonHocTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.tenMonHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenMonHocTextBox.Location = new System.Drawing.Point(256, 149);
            this.tenMonHocTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tenMonHocTextBox.Name = "tenMonHocTextBox";
            this.tenMonHocTextBox.Size = new System.Drawing.Size(290, 32);
            this.tenMonHocTextBox.TabIndex = 13;
            // 
            // AddMonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(725, 688);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMonHocForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            MonHoc mh = new MonHoc();
            //mh.MaMonHoc = int.Parse(maMonHocTextBox.Text);
            //mh.MaMonHoc = convert.toint32(maMonHocTextBox.Text);
            mh.SoTinhChi = byte.Parse(soTinhChiTextBox.Text);
            //mh.SoTinhChi = Int16.Parse(soTinhChiTextBox.Text);
            mh.TenMonHoc= tenMonHocTextBox.Text;
           // mh.TinhTrang = tinhTrangCheckBox.Checked;
           
        
            if (mh == null) return;

            ValidationContext context = new ValidationContext(mh, null, null);
            IList<ValidationResult> validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(mh, context, validationResults, true))
            {
                foreach (var item in validationResults)
                {
                    MessageBox.Show(item.ErrorMessage);
                    return;
                }
            }

            if (MainForm.Manager.MonHoc.Add(mh))
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
