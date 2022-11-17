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
    internal class AddDiemForm : DetailInfoForm<Diem>
    {
        private TextBox maSVTextBox;
        private TextBox maLopTextBox;
        private TextBox diem_giua_kyTextBox;
        private TextBox diem_cuoi_kyTextBox;
        private Button add_btn;

        public AddDiemForm() : base()
        {
            InitializeComponent();
            //this.LoadDataFromObject(diem);
            Init();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.Label diem_cuoi_kyLabel;
            System.Windows.Forms.Label diem_giua_kyLabel;
            System.Windows.Forms.Label maLopLabel;
            System.Windows.Forms.Label maSVLabel;
            this.add_btn = new System.Windows.Forms.Button();
            this.diem_cuoi_kyTextBox = new System.Windows.Forms.TextBox();
            this.diem_giua_kyTextBox = new System.Windows.Forms.TextBox();
            this.maLopTextBox = new System.Windows.Forms.TextBox();
            this.maSVTextBox = new System.Windows.Forms.TextBox();
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
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.maSVTextBox);
            this.panel1.Controls.Add(this.maLopTextBox);
            this.panel1.Controls.Add(this.diem_giua_kyTextBox);
            this.panel1.Controls.Add(this.diem_cuoi_kyTextBox);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(diem_cuoi_kyLabel);
            this.panel1.Controls.Add(diem_giua_kyLabel);
            this.panel1.Controls.Add(maLopLabel);
            this.panel1.Controls.Add(maSVLabel);
            this.panel1.Size = new System.Drawing.Size(725, 440);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 440);
            this.panel2.Size = new System.Drawing.Size(725, 248);
            // 
            // diem_cuoi_kyLabel
            // 
            diem_cuoi_kyLabel.AutoSize = true;
            diem_cuoi_kyLabel.Font = new System.Drawing.Font("Roboto Slab", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diem_cuoi_kyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            diem_cuoi_kyLabel.Location = new System.Drawing.Point(89, 148);
            diem_cuoi_kyLabel.Name = "diem_cuoi_kyLabel";
            diem_cuoi_kyLabel.Size = new System.Drawing.Size(116, 23);
            diem_cuoi_kyLabel.TabIndex = 0;
            diem_cuoi_kyLabel.Text = "Điểm cuối kỳ:";
            // 
            // diem_giua_kyLabel
            // 
            diem_giua_kyLabel.AutoSize = true;
            diem_giua_kyLabel.Font = new System.Drawing.Font("Roboto Slab", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diem_giua_kyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            diem_giua_kyLabel.Location = new System.Drawing.Point(87, 196);
            diem_giua_kyLabel.Name = "diem_giua_kyLabel";
            diem_giua_kyLabel.Size = new System.Drawing.Size(118, 23);
            diem_giua_kyLabel.TabIndex = 2;
            diem_giua_kyLabel.Text = "Điểm giữa kỳ:";
            // 
            // maLopLabel
            // 
            maLopLabel.AutoSize = true;
            maLopLabel.Font = new System.Drawing.Font("Roboto Slab", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maLopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maLopLabel.Location = new System.Drawing.Point(105, 241);
            maLopLabel.Name = "maLopLabel";
            maLopLabel.Size = new System.Drawing.Size(100, 23);
            maLopLabel.TabIndex = 4;
            maLopLabel.Text = "Mã lớp học:";
            // 
            // maSVLabel
            // 
            maSVLabel.AutoSize = true;
            maSVLabel.Font = new System.Drawing.Font("Roboto Slab", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maSVLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            maSVLabel.Location = new System.Drawing.Point(89, 287);
            maSVLabel.Name = "maSVLabel";
            maSVLabel.Size = new System.Drawing.Size(116, 23);
            maSVLabel.TabIndex = 6;
            maSVLabel.Text = "Mã sinh viên:";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Roboto Slab Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(494, 332);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(112, 43);
            this.add_btn.TabIndex = 8;
            this.add_btn.Text = "Thêm";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // diem_cuoi_kyTextBox
            // 
            this.diem_cuoi_kyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.diem_cuoi_kyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "maLop", true));
            this.diem_cuoi_kyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diem_cuoi_kyTextBox.Location = new System.Drawing.Point(217, 142);
            this.diem_cuoi_kyTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diem_cuoi_kyTextBox.Name = "diem_cuoi_kyTextBox";
            this.diem_cuoi_kyTextBox.Size = new System.Drawing.Size(389, 32);
            this.diem_cuoi_kyTextBox.TabIndex = 9;
            // 
            // diem_giua_kyTextBox
            // 
            this.diem_giua_kyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.diem_giua_kyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "maLop", true));
            this.diem_giua_kyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diem_giua_kyTextBox.Location = new System.Drawing.Point(217, 187);
            this.diem_giua_kyTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diem_giua_kyTextBox.Name = "diem_giua_kyTextBox";
            this.diem_giua_kyTextBox.Size = new System.Drawing.Size(389, 32);
            this.diem_giua_kyTextBox.TabIndex = 10;
            // 
            // maLopTextBox
            // 
            this.maLopTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maLopTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maLopTextBox.Location = new System.Drawing.Point(217, 235);
            this.maLopTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maLopTextBox.Name = "maLopTextBox";
            this.maLopTextBox.Size = new System.Drawing.Size(389, 32);
            this.maLopTextBox.TabIndex = 10;
            // 
            // maSVTextBox
            // 
            this.maSVTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.maSVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maSVTextBox.Location = new System.Drawing.Point(217, 281);
            this.maSVTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maSVTextBox.Name = "maSVTextBox";
            this.maSVTextBox.Size = new System.Drawing.Size(389, 32);
            this.maSVTextBox.TabIndex = 10;
            // 
            // AddDiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(725, 688);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDiemForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            //Diem diem = bindingSource.Current as Diem;
            Diem diem = new Diem();
            diem.maLop = int.Parse(maLopTextBox.Text);
            diem.maSV = int.Parse(maSVTextBox.Text);
            diem.diem_cuoi_ky = int.Parse(diem_cuoi_kyTextBox.Text);
            diem.diem_giua_ky = int.Parse(diem_giua_kyTextBox.Text);
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

            if (MainForm.Manager.Diem.Add(diem))
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
