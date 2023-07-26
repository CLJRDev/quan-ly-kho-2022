
namespace QuanLyKho_Tuan1
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.but_dangNhap = new System.Windows.Forms.Button();
            this.but_thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_matKhau);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_tenDangNhap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người dùng";
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_matKhau.Location = new System.Drawing.Point(108, 56);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.PasswordChar = '*';
            this.txt_matKhau.Size = new System.Drawing.Size(245, 25);
            this.txt_matKhau.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // txt_tenDangNhap
            // 
            this.txt_tenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tenDangNhap.Location = new System.Drawing.Point(108, 25);
            this.txt_tenDangNhap.Name = "txt_tenDangNhap";
            this.txt_tenDangNhap.Size = new System.Drawing.Size(245, 25);
            this.txt_tenDangNhap.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đăng nhập";
            // 
            // but_dangNhap
            // 
            this.but_dangNhap.BackColor = System.Drawing.Color.Transparent;
            this.but_dangNhap.Image = ((System.Drawing.Image)(resources.GetObject("but_dangNhap.Image")));
            this.but_dangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_dangNhap.Location = new System.Drawing.Point(119, 143);
            this.but_dangNhap.Name = "but_dangNhap";
            this.but_dangNhap.Size = new System.Drawing.Size(123, 34);
            this.but_dangNhap.TabIndex = 1;
            this.but_dangNhap.Text = "Đăng nhập";
            this.but_dangNhap.UseVisualStyleBackColor = false;
            this.but_dangNhap.Click += new System.EventHandler(this.but_dangNhap_Click);
            // 
            // but_thoat
            // 
            this.but_thoat.BackColor = System.Drawing.Color.Transparent;
            this.but_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_thoat.Image = ((System.Drawing.Image)(resources.GetObject("but_thoat.Image")));
            this.but_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_thoat.Location = new System.Drawing.Point(248, 143);
            this.but_thoat.Name = "but_thoat";
            this.but_thoat.Size = new System.Drawing.Size(123, 34);
            this.but_thoat.TabIndex = 2;
            this.but_thoat.Text = "Thoát";
            this.but_thoat.UseVisualStyleBackColor = false;
            this.but_thoat.Click += new System.EventHandler(this.but_thoat_Click);
            // 
            // FrmDangNhap
            // 
            this.AcceptButton = this.but_dangNhap;
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.but_thoat;
            this.ClientSize = new System.Drawing.Size(383, 185);
            this.Controls.Add(this.but_thoat);
            this.Controls.Add(this.but_dangNhap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_dangNhap;
        private System.Windows.Forms.Button but_thoat;
    }
}