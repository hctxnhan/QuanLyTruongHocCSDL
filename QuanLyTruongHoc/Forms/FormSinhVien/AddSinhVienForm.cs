using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormSinhVien
{
    internal class AddSinhVienForm : ViewSinhVienForm
    {
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        protected System.Windows.Forms.Button add_button;
        
        public AddSinhVienForm(SinhVien sv) : base(sv)
        {
            InitializeComponent();
            bindingSource.DataSource = new SinhVien();
        }
        
        public AddSinhVienForm() : base()
        {
            InitializeComponent();
            this.maSVTextBox.Enabled = false;
        }

        private void InitializeComponent()
        {
            this.add_button = new System.Windows.Forms.Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.Location = new System.Drawing.Point(266, 497);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(266, 358);
            // 
            // gioiTinhTextBox
            // 
            this.gioiTinhTextBox.Location = new System.Drawing.Point(266, 260);
            // 
            // hoTextBox
            // 
            this.hoTextBox.Location = new System.Drawing.Point(266, 213);
            // 
            // maKhoaComboBox
            // 
            this.maKhoaComboBox.Location = new System.Drawing.Point(266, 406);
            // 
            // maSVTextBox
            // 
            this.maSVTextBox.Location = new System.Drawing.Point(266, 131);
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(266, 452);
            // 
            // tenTextBox
            // 
            this.tenTextBox.Location = new System.Drawing.Point(266, 172);
            // 
            // tinhTrangComboBox
            // 
            this.tinhTrangComboBox.Location = new System.Drawing.Point(266, 308);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Font = new System.Drawing.Font("Roboto Slab", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Size = new System.Drawing.Size(615, 584);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.Controls.SetChildIndex(this.tinhTrangComboBox, 0);
            this.panel1.Controls.SetChildIndex(this.tenTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.ngaySinhDateTimePicker, 0);
            this.panel1.Controls.SetChildIndex(this.maSVTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.maKhoaComboBox, 0);
            this.panel1.Controls.SetChildIndex(this.hoTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.gioiTinhTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.emailTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.diaChiTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.guna2ControlBox1, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.add_button);
            this.panel2.Location = new System.Drawing.Point(0, 584);
            this.panel2.Size = new System.Drawing.Size(615, 104);
            this.panel2.Controls.SetChildIndex(this.add_button, 0);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(233, 16);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "Thêm";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(568, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 18;
            // 
            // AddSinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(615, 688);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSinhVienForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            SinhVien sv = bindingSource.Current as SinhVien; // Chuyển về data object (ngôn ngữ chung để nói chuyện với nhau)
            //MessageBox.Show(sv.ToString());
            if (sv == null) return;
            ValidationContext context = new ValidationContext(sv, null, null);
            IList<ValidationResult> validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(sv, context, validationResults, true))
            {
                foreach (var item in validationResults)
                {
                    MessageBox.Show(item.ErrorMessage);
                    return;
                }
            }

            if (MainForm.Manager.SinhVien.Add(sv))
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
