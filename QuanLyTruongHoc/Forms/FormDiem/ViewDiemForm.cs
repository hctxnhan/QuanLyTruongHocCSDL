using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormDiem
{
    internal class ViewDiemForm: DetailInfoForm<Diem>
    {
        private TextBox maLopTextBox;
        private TextBox diem_cuoi_kyTextBox;
        private TextBox diem_giua_kyTextBox;
        private TextBox maSVTextBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Button update_btn;

        public ViewDiemForm(Diem diem) : base()
        {
            InitializeComponent();
            this.LoadDataFromObject(diem);
            Init();

        }

        protected override void Init()
        {
            this.maLopTextBox.Enabled = false;
            this.maSVTextBox.Enabled = true;
            this.diem_giua_kyTextBox.Enabled = true;
            this.diem_cuoi_kyTextBox.Enabled = true;
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.Label diem_cuoi_kyLabel;
            System.Windows.Forms.Label diem_giua_kyLabel;
            System.Windows.Forms.Label maLopLabel;
            System.Windows.Forms.Label maSVLabel;
            this.update_btn = new System.Windows.Forms.Button();
            this.maLopTextBox = new System.Windows.Forms.TextBox();
            this.diem_cuoi_kyTextBox = new System.Windows.Forms.TextBox();
            this.diem_giua_kyTextBox = new System.Windows.Forms.TextBox();
            this.maSVTextBox = new System.Windows.Forms.TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            diem_cuoi_kyLabel = new System.Windows.Forms.Label();
            diem_giua_kyLabel = new System.Windows.Forms.Label();
            maLopLabel = new System.Windows.Forms.Label();
            maSVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Controls.Add(this.maLopTextBox);
            this.panel1.Controls.Add(this.diem_cuoi_kyTextBox);
            this.panel1.Controls.Add(this.diem_giua_kyTextBox);
            this.panel1.Controls.Add(this.maSVTextBox);
            this.panel1.Controls.Add(this.update_btn);
            this.panel1.Controls.Add(diem_cuoi_kyLabel);
            this.panel1.Controls.Add(diem_giua_kyLabel);
            this.panel1.Controls.Add(maLopLabel);
            this.panel1.Controls.Add(maSVLabel);
            this.panel1.Size = new System.Drawing.Size(725, 427);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 427);
            this.panel2.Size = new System.Drawing.Size(725, 261);
            // 
            // diem_cuoi_kyLabel
            // 
            diem_cuoi_kyLabel.AutoSize = true;
            diem_cuoi_kyLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diem_cuoi_kyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            diem_cuoi_kyLabel.Location = new System.Drawing.Point(65, 85);
            diem_cuoi_kyLabel.Name = "diem_cuoi_kyLabel";
            diem_cuoi_kyLabel.Size = new System.Drawing.Size(134, 26);
            diem_cuoi_kyLabel.TabIndex = 0;
            diem_cuoi_kyLabel.Text = "Điểm cuối kỳ:";
            // 
            // diem_giua_kyLabel
            // 
            diem_giua_kyLabel.AutoSize = true;
            diem_giua_kyLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diem_giua_kyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            diem_giua_kyLabel.Location = new System.Drawing.Point(64, 133);
            diem_giua_kyLabel.Name = "diem_giua_kyLabel";
            diem_giua_kyLabel.Size = new System.Drawing.Size(136, 26);
            diem_giua_kyLabel.TabIndex = 2;
            diem_giua_kyLabel.Text = "Điểm giữa kỳ:";
            // 
            // maLopLabel
            // 
            maLopLabel.AutoSize = true;
            maLopLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maLopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maLopLabel.Location = new System.Drawing.Point(83, 187);
            maLopLabel.Name = "maLopLabel";
            maLopLabel.Size = new System.Drawing.Size(115, 26);
            maLopLabel.TabIndex = 4;
            maLopLabel.Text = "Mã lớp học:";
            // 
            // maSVLabel
            // 
            maSVLabel.AutoSize = true;
            maSVLabel.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maSVLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maSVLabel.Location = new System.Drawing.Point(65, 242);
            maSVLabel.Name = "maSVLabel";
            maSVLabel.Size = new System.Drawing.Size(133, 26);
            maSVLabel.TabIndex = 6;
            maSVLabel.Text = "Mã sinh viên:";
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Roboto Slab Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(545, 324);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(130, 35);
            this.update_btn.TabIndex = 8;
            this.update_btn.Text = "Cập nhật";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // maLopTextBox
            // 
            this.maLopTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maLopTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Ho", true));
            this.maLopTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maLopTextBox.Location = new System.Drawing.Point(212, 187);
            this.maLopTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maLopTextBox.Name = "maLopTextBox";
            this.maLopTextBox.Size = new System.Drawing.Size(389, 32);
            this.maLopTextBox.TabIndex = 14;
            // 
            // diem_cuoi_kyTextBox
            // 
            this.diem_cuoi_kyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.diem_cuoi_kyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "maLop", true));
            this.diem_cuoi_kyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diem_cuoi_kyTextBox.Location = new System.Drawing.Point(212, 83);
            this.diem_cuoi_kyTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diem_cuoi_kyTextBox.Name = "diem_cuoi_kyTextBox";
            this.diem_cuoi_kyTextBox.Size = new System.Drawing.Size(389, 32);
            this.diem_cuoi_kyTextBox.TabIndex = 15;
            // 
            // diem_giua_kyTextBox
            // 
            this.diem_giua_kyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.diem_giua_kyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "maSV", true));
            this.diem_giua_kyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diem_giua_kyTextBox.Location = new System.Drawing.Point(212, 133);
            this.diem_giua_kyTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diem_giua_kyTextBox.Name = "diem_giua_kyTextBox";
            this.diem_giua_kyTextBox.Size = new System.Drawing.Size(389, 32);
            this.diem_giua_kyTextBox.TabIndex = 16;
            // 
            // maSVTextBox
            // 
            this.maSVTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maSVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Ten", true));
            this.maSVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maSVTextBox.Location = new System.Drawing.Point(212, 243);
            this.maSVTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maSVTextBox.Name = "maSVTextBox";
            this.maSVTextBox.Size = new System.Drawing.Size(389, 32);
            this.maSVTextBox.TabIndex = 17;
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
            this.guna2ControlBox1.TabIndex = 18;
            // 
            // ViewDiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(725, 688);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewDiemForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            Diem diem = bindingSource.Current as Diem;
            if (diem == null) return;

            ValidationContext context = new ValidationContext(diem, null, null);
            IList<ValidationResult> validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(diem, context, validationResults, true))
            {
                foreach (var item in validationResults)
                {
                    MessageBox.Show(item.ErrorMessage);
                    return;
                }
            }

            if (MainForm.Manager.Diem.Update(diem))
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
