using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormMonHoc
{
    internal class ViewMonHocForm : DetailInfoForm<MonHoc>
    {
        private System.Windows.Forms.Button update_button;
        private TextBox maMonHocTextBox;
        private TextBox soTinhChiTextBox;
        private TextBox tenMonHocTextBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.CheckBox tinhTrangCheckBox;

        public ViewMonHocForm(MonHoc mh) : base()
        {
            InitializeComponent();
            this.LoadDataFromObject(mh);
            Init();
        }

        public ViewMonHocForm() : base()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            this.maMonHocTextBox.Enabled = false;
            this.soTinhChiTextBox.Enabled = true;
            this.tenMonHocTextBox.Enabled = true;
            this.update_button.Enabled = true;
            this.tinhTrangCheckBox.Enabled = true;
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.Label maMonHocLabel;
            System.Windows.Forms.Label soTinhChiLabel;
            System.Windows.Forms.Label tenMonHocLabel;
            System.Windows.Forms.Label tinhTrangLabel;
            this.tinhTrangCheckBox = new System.Windows.Forms.CheckBox();
            this.update_button = new System.Windows.Forms.Button();
            this.maMonHocTextBox = new System.Windows.Forms.TextBox();
            this.soTinhChiTextBox = new System.Windows.Forms.TextBox();
            this.tenMonHocTextBox = new System.Windows.Forms.TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            maMonHocLabel = new System.Windows.Forms.Label();
            soTinhChiLabel = new System.Windows.Forms.Label();
            tenMonHocLabel = new System.Windows.Forms.Label();
            tinhTrangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Controls.Add(this.tenMonHocTextBox);
            this.panel1.Controls.Add(this.soTinhChiTextBox);
            this.panel1.Controls.Add(this.maMonHocTextBox);
            this.panel1.Controls.Add(this.update_button);
            this.panel1.Controls.Add(maMonHocLabel);
            this.panel1.Controls.Add(soTinhChiLabel);
            this.panel1.Controls.Add(tenMonHocLabel);
            this.panel1.Controls.Add(tinhTrangLabel);
            this.panel1.Controls.Add(this.tinhTrangCheckBox);
            this.panel1.Size = new System.Drawing.Size(725, 293);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 293);
            this.panel2.Size = new System.Drawing.Size(725, 395);
            // 
            // maMonHocLabel
            // 
            maMonHocLabel.AutoSize = true;
            maMonHocLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maMonHocLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maMonHocLabel.Location = new System.Drawing.Point(107, 96);
            maMonHocLabel.Name = "maMonHocLabel";
            maMonHocLabel.Size = new System.Drawing.Size(127, 26);
            maMonHocLabel.TabIndex = 0;
            maMonHocLabel.Text = "Mã môn học:";
            // 
            // soTinhChiLabel
            // 
            soTinhChiLabel.AutoSize = true;
            soTinhChiLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soTinhChiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            soTinhChiLabel.Location = new System.Drawing.Point(134, 132);
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
            tenMonHocLabel.Location = new System.Drawing.Point(102, 168);
            tenMonHocLabel.Name = "tenMonHocLabel";
            tenMonHocLabel.Size = new System.Drawing.Size(132, 26);
            tenMonHocLabel.TabIndex = 4;
            tenMonHocLabel.Text = "Tên môn học:";
            // 
            // tinhTrangLabel
            // 
            tinhTrangLabel.AutoSize = true;
            tinhTrangLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tinhTrangLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            tinhTrangLabel.Location = new System.Drawing.Point(409, 132);
            tinhTrangLabel.Name = "tinhTrangLabel";
            tinhTrangLabel.Size = new System.Drawing.Size(77, 26);
            tinhTrangLabel.TabIndex = 6;
            tinhTrangLabel.Text = "Đã xóa:";
            // 
            // tinhTrangCheckBox
            // 
            this.tinhTrangCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bindingSource, "TinhTrang", true));
            this.tinhTrangCheckBox.Location = new System.Drawing.Point(492, 137);
            this.tinhTrangCheckBox.Name = "tinhTrangCheckBox";
            this.tinhTrangCheckBox.Size = new System.Drawing.Size(23, 24);
            this.tinhTrangCheckBox.TabIndex = 7;
            this.tinhTrangCheckBox.UseVisualStyleBackColor = true;
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.Font = new System.Drawing.Font("Roboto Slab Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.ForeColor = System.Drawing.Color.White;
            this.update_button.Location = new System.Drawing.Point(401, 215);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(130, 30);
            this.update_button.TabIndex = 8;
            this.update_button.Text = "Cập nhật ";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // maMonHocTextBox
            // 
            this.maMonHocTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maMonHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maMonHocTextBox.Location = new System.Drawing.Point(240, 93);
            this.maMonHocTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maMonHocTextBox.Name = "maMonHocTextBox";
            this.maMonHocTextBox.Size = new System.Drawing.Size(291, 32);
            this.maMonHocTextBox.TabIndex = 15;
            // 
            // soTinhChiTextBox
            // 
            this.soTinhChiTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.soTinhChiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soTinhChiTextBox.Location = new System.Drawing.Point(240, 129);
            this.soTinhChiTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soTinhChiTextBox.Name = "soTinhChiTextBox";
            this.soTinhChiTextBox.Size = new System.Drawing.Size(158, 32);
            this.soTinhChiTextBox.TabIndex = 15;
            // 
            // tenMonHocTextBox
            // 
            this.tenMonHocTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.tenMonHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenMonHocTextBox.Location = new System.Drawing.Point(240, 165);
            this.tenMonHocTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tenMonHocTextBox.Name = "tenMonHocTextBox";
            this.tenMonHocTextBox.Size = new System.Drawing.Size(291, 32);
            this.tenMonHocTextBox.TabIndex = 15;
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
            this.guna2ControlBox1.TabIndex = 16;
            // 
            // ViewMonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(725, 688);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewMonHocForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            MonHoc mh = bindingSource.Current as MonHoc;
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

            if (MainForm.Manager.MonHoc.Update(mh))
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
