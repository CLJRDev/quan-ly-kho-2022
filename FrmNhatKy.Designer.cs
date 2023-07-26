
namespace QuanLyKho_Tuan1
{
    partial class FrmNhatKy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhatKy));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_nhatKy = new System.Windows.Forms.DataGridView();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ck_tenDangNhap = new System.Windows.Forms.CheckBox();
            this.ck_thoiDiemDen = new System.Windows.Forms.CheckBox();
            this.ck_thoiDiemTu = new System.Windows.Forms.CheckBox();
            this.txt_tenDangNhap = new System.Windows.Forms.TextBox();
            this.dtp_thoiDiemDen = new System.Windows.Forms.DateTimePicker();
            this.dtp_thoiDiemTu = new System.Windows.Forms.DateTimePicker();
            this.but_timKiem = new System.Windows.Forms.Button();
            this.ck_timKiem = new System.Windows.Forms.CheckBox();
            this.but_dong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhatKy)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬT KÝ HỆ THỐNG";
            // 
            // dgv_nhatKy
            // 
            this.dgv_nhatKy.AllowUserToAddRows = false;
            this.dgv_nhatKy.AllowUserToDeleteRows = false;
            this.dgv_nhatKy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_nhatKy.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgv_nhatKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhatKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDangNhap,
            this.ThoiDiem,
            this.NoiDung});
            this.dgv_nhatKy.Location = new System.Drawing.Point(12, 162);
            this.dgv_nhatKy.MultiSelect = false;
            this.dgv_nhatKy.Name = "dgv_nhatKy";
            this.dgv_nhatKy.ReadOnly = true;
            this.dgv_nhatKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nhatKy.Size = new System.Drawing.Size(920, 387);
            this.dgv_nhatKy.TabIndex = 3;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.ReadOnly = true;
            this.TenDangNhap.Width = 150;
            // 
            // ThoiDiem
            // 
            this.ThoiDiem.DataPropertyName = "ThoiDiem";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.ThoiDiem.DefaultCellStyle = dataGridViewCellStyle1;
            this.ThoiDiem.HeaderText = "Thời Điểm";
            this.ThoiDiem.Name = "ThoiDiem";
            this.ThoiDiem.ReadOnly = true;
            this.ThoiDiem.Width = 200;
            // 
            // NoiDung
            // 
            this.NoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội Dung";
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ck_tenDangNhap);
            this.groupBox1.Controls.Add(this.ck_thoiDiemDen);
            this.groupBox1.Controls.Add(this.ck_thoiDiemTu);
            this.groupBox1.Controls.Add(this.txt_tenDangNhap);
            this.groupBox1.Controls.Add(this.dtp_thoiDiemDen);
            this.groupBox1.Controls.Add(this.dtp_thoiDiemTu);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu chí";
            // 
            // ck_tenDangNhap
            // 
            this.ck_tenDangNhap.AutoSize = true;
            this.ck_tenDangNhap.Location = new System.Drawing.Point(511, 26);
            this.ck_tenDangNhap.Name = "ck_tenDangNhap";
            this.ck_tenDangNhap.Size = new System.Drawing.Size(124, 21);
            this.ck_tenDangNhap.TabIndex = 4;
            this.ck_tenDangNhap.Text = "Tên đăng nhập";
            this.ck_tenDangNhap.UseVisualStyleBackColor = true;
            this.ck_tenDangNhap.CheckedChanged += new System.EventHandler(this.ck_tenDangNhap_CheckedChanged);
            // 
            // ck_thoiDiemDen
            // 
            this.ck_thoiDiemDen.AutoSize = true;
            this.ck_thoiDiemDen.Location = new System.Drawing.Point(255, 26);
            this.ck_thoiDiemDen.Name = "ck_thoiDiemDen";
            this.ck_thoiDiemDen.Size = new System.Drawing.Size(121, 21);
            this.ck_thoiDiemDen.TabIndex = 2;
            this.ck_thoiDiemDen.Text = "Thời điểm đến";
            this.ck_thoiDiemDen.UseVisualStyleBackColor = true;
            this.ck_thoiDiemDen.CheckedChanged += new System.EventHandler(this.ck_thoiDiemDen_CheckedChanged);
            // 
            // ck_thoiDiemTu
            // 
            this.ck_thoiDiemTu.AutoSize = true;
            this.ck_thoiDiemTu.Location = new System.Drawing.Point(9, 26);
            this.ck_thoiDiemTu.Name = "ck_thoiDiemTu";
            this.ck_thoiDiemTu.Size = new System.Drawing.Size(111, 21);
            this.ck_thoiDiemTu.TabIndex = 0;
            this.ck_thoiDiemTu.Text = "Thời điểm từ";
            this.ck_thoiDiemTu.UseVisualStyleBackColor = true;
            this.ck_thoiDiemTu.CheckedChanged += new System.EventHandler(this.ck_thoiDiemTu_CheckedChanged);
            // 
            // txt_tenDangNhap
            // 
            this.txt_tenDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tenDangNhap.Enabled = false;
            this.txt_tenDangNhap.Location = new System.Drawing.Point(641, 25);
            this.txt_tenDangNhap.Name = "txt_tenDangNhap";
            this.txt_tenDangNhap.Size = new System.Drawing.Size(273, 25);
            this.txt_tenDangNhap.TabIndex = 5;
            // 
            // dtp_thoiDiemDen
            // 
            this.dtp_thoiDiemDen.CustomFormat = "dd/MM/yyyy";
            this.dtp_thoiDiemDen.Enabled = false;
            this.dtp_thoiDiemDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_thoiDiemDen.Location = new System.Drawing.Point(382, 21);
            this.dtp_thoiDiemDen.Name = "dtp_thoiDiemDen";
            this.dtp_thoiDiemDen.Size = new System.Drawing.Size(123, 25);
            this.dtp_thoiDiemDen.TabIndex = 3;
            // 
            // dtp_thoiDiemTu
            // 
            this.dtp_thoiDiemTu.CustomFormat = "dd/MM/yyyy";
            this.dtp_thoiDiemTu.Enabled = false;
            this.dtp_thoiDiemTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_thoiDiemTu.Location = new System.Drawing.Point(126, 21);
            this.dtp_thoiDiemTu.Name = "dtp_thoiDiemTu";
            this.dtp_thoiDiemTu.Size = new System.Drawing.Size(123, 25);
            this.dtp_thoiDiemTu.TabIndex = 1;
            // 
            // but_timKiem
            // 
            this.but_timKiem.Enabled = false;
            this.but_timKiem.Image = ((System.Drawing.Image)(resources.GetObject("but_timKiem.Image")));
            this.but_timKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_timKiem.Location = new System.Drawing.Point(114, 116);
            this.but_timKiem.Name = "but_timKiem";
            this.but_timKiem.Size = new System.Drawing.Size(100, 40);
            this.but_timKiem.TabIndex = 2;
            this.but_timKiem.Text = "Tìm kiếm";
            this.but_timKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_timKiem.UseVisualStyleBackColor = true;
            this.but_timKiem.Click += new System.EventHandler(this.but_timKiem_Click);
            // 
            // ck_timKiem
            // 
            this.ck_timKiem.AutoSize = true;
            this.ck_timKiem.Location = new System.Drawing.Point(21, 127);
            this.ck_timKiem.Name = "ck_timKiem";
            this.ck_timKiem.Size = new System.Drawing.Size(87, 21);
            this.ck_timKiem.TabIndex = 1;
            this.ck_timKiem.Text = "Tìm kiếm";
            this.ck_timKiem.UseVisualStyleBackColor = true;
            this.ck_timKiem.CheckedChanged += new System.EventHandler(this.ck_timKiem_CheckedChanged);
            // 
            // but_dong
            // 
            this.but_dong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_dong.Image = ((System.Drawing.Image)(resources.GetObject("but_dong.Image")));
            this.but_dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_dong.Location = new System.Drawing.Point(832, 116);
            this.but_dong.Name = "but_dong";
            this.but_dong.Size = new System.Drawing.Size(100, 40);
            this.but_dong.TabIndex = 4;
            this.but_dong.Text = "Đóng";
            this.but_dong.UseVisualStyleBackColor = true;
            this.but_dong.Click += new System.EventHandler(this.but_dong_Click);
            // 
            // FrmNhatKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.but_dong);
            this.Controls.Add(this.but_timKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ck_timKiem);
            this.Controls.Add(this.dgv_nhatKy);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNhatKy";
            this.Text = "NHẬT KÝ HỆ THỐNG";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhatKy)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_nhatKy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_thoiDiemTu;
        private System.Windows.Forms.DateTimePicker dtp_thoiDiemDen;
        private System.Windows.Forms.TextBox txt_tenDangNhap;
        private System.Windows.Forms.Button but_timKiem;
        private System.Windows.Forms.CheckBox ck_thoiDiemTu;
        private System.Windows.Forms.CheckBox ck_thoiDiemDen;
        private System.Windows.Forms.CheckBox ck_tenDangNhap;
        private System.Windows.Forms.CheckBox ck_timKiem;
        private System.Windows.Forms.Button but_dong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
    }
}