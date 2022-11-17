
namespace QuanLyTruongHoc.Forms.FormTrangChu.FormTrangChuGV
{
    partial class FormHomeGV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dslop_btn = new System.Windows.Forms.Button();
            this.chamdiem_btn = new System.Windows.Forms.Button();
            this.dsSV_btn = new System.Windows.Forms.Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // dslop_btn
            // 
            this.dslop_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.dslop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dslop_btn.Font = new System.Drawing.Font("Roboto Slab Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dslop_btn.ForeColor = System.Drawing.Color.White;
            this.dslop_btn.Location = new System.Drawing.Point(25, 73);
            this.dslop_btn.Name = "dslop_btn";
            this.dslop_btn.Size = new System.Drawing.Size(234, 51);
            this.dslop_btn.TabIndex = 3;
            this.dslop_btn.Text = "Các lớp học";
            this.dslop_btn.UseVisualStyleBackColor = false;
            // 
            // chamdiem_btn
            // 
            this.chamdiem_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.chamdiem_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chamdiem_btn.Font = new System.Drawing.Font("Roboto Slab Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chamdiem_btn.ForeColor = System.Drawing.Color.White;
            this.chamdiem_btn.Location = new System.Drawing.Point(505, 73);
            this.chamdiem_btn.Name = "chamdiem_btn";
            this.chamdiem_btn.Size = new System.Drawing.Size(234, 51);
            this.chamdiem_btn.TabIndex = 5;
            this.chamdiem_btn.Text = "Chấm điểm";
            this.chamdiem_btn.UseVisualStyleBackColor = false;
            // 
            // dsSV_btn
            // 
            this.dsSV_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(75)))));
            this.dsSV_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dsSV_btn.Font = new System.Drawing.Font("Roboto Slab Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsSV_btn.ForeColor = System.Drawing.Color.White;
            this.dsSV_btn.Location = new System.Drawing.Point(265, 73);
            this.dsSV_btn.Name = "dsSV_btn";
            this.dsSV_btn.Size = new System.Drawing.Size(234, 51);
            this.dsSV_btn.TabIndex = 4;
            this.dsSV_btn.Text = "Danh Sách Sinh Viên";
            this.dsSV_btn.UseVisualStyleBackColor = false;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(725, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // FormHomeGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 202);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.dslop_btn);
            this.Controls.Add(this.chamdiem_btn);
            this.Controls.Add(this.dsSV_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHomeGV";
            this.Text = "FormHomeGV";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dslop_btn;
        private System.Windows.Forms.Button chamdiem_btn;
        private System.Windows.Forms.Button dsSV_btn;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}