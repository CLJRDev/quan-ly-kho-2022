
namespace QuanLyKho_Tuan1
{
    partial class FrmQuanLyHangHoa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyHangHoa));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tenHangHoa = new System.Windows.Forms.TextBox();
            this.txt_maHangHoa = new System.Windows.Forms.TextBox();
            this.ck_tenHangHoa = new System.Windows.Forms.CheckBox();
            this.ck_maHangHoa = new System.Windows.Forms.CheckBox();
            this.dgv_hangHoa = new System.Windows.Forms.DataGridView();
            this.MaHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_them = new System.Windows.Forms.Button();
            this.but_sua = new System.Windows.Forms.Button();
            this.but_xoa = new System.Windows.Forms.Button();
            this.but_timKiem = new System.Windows.Forms.Button();
            this.errorMess = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.but_loaiHang = new System.Windows.Forms.Button();
            this.but_donViTinh = new System.Windows.Forms.Button();
            this.but_dong = new System.Windows.Forms.Button();
            this.ck_timKiem = new System.Windows.Forms.CheckBox();
            this.tv_chiTietHangHoa = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMess)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN DANH SÁCH HÀNG HOÁ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_tenHangHoa);
            this.groupBox1.Controls.Add(this.txt_maHangHoa);
            this.groupBox1.Controls.Add(this.ck_tenHangHoa);
            this.groupBox1.Controls.Add(this.ck_maHangHoa);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hàng hoá";
            // 
            // txt_tenHangHoa
            // 
            this.txt_tenHangHoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tenHangHoa.Location = new System.Drawing.Point(113, 62);
            this.txt_tenHangHoa.MaxLength = 30;
            this.txt_tenHangHoa.Name = "txt_tenHangHoa";
            this.txt_tenHangHoa.Size = new System.Drawing.Size(188, 25);
            this.txt_tenHangHoa.TabIndex = 3;
            // 
            // txt_maHangHoa
            // 
            this.txt_maHangHoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_maHangHoa.Location = new System.Drawing.Point(113, 31);
            this.txt_maHangHoa.MaxLength = 3;
            this.txt_maHangHoa.Name = "txt_maHangHoa";
            this.txt_maHangHoa.Size = new System.Drawing.Size(188, 25);
            this.txt_maHangHoa.TabIndex = 1;
            // 
            // ck_tenHangHoa
            // 
            this.ck_tenHangHoa.AutoSize = true;
            this.ck_tenHangHoa.Location = new System.Drawing.Point(6, 63);
            this.ck_tenHangHoa.Name = "ck_tenHangHoa";
            this.ck_tenHangHoa.Size = new System.Drawing.Size(106, 24);
            this.ck_tenHangHoa.TabIndex = 2;
            this.ck_tenHangHoa.Text = "Tên hàng hoá";
            this.ck_tenHangHoa.UseVisualStyleBackColor = true;
            // 
            // ck_maHangHoa
            // 
            this.ck_maHangHoa.AutoSize = true;
            this.ck_maHangHoa.Location = new System.Drawing.Point(6, 32);
            this.ck_maHangHoa.Name = "ck_maHangHoa";
            this.ck_maHangHoa.Size = new System.Drawing.Size(101, 24);
            this.ck_maHangHoa.TabIndex = 0;
            this.ck_maHangHoa.Text = "Mã hàng hoá";
            this.ck_maHangHoa.UseVisualStyleBackColor = true;
            // 
            // dgv_hangHoa
            // 
            this.dgv_hangHoa.AllowUserToAddRows = false;
            this.dgv_hangHoa.AllowUserToDeleteRows = false;
            this.dgv_hangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_hangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHangHoa,
            this.TenHangHoa});
            this.dgv_hangHoa.Location = new System.Drawing.Point(12, 197);
            this.dgv_hangHoa.MultiSelect = false;
            this.dgv_hangHoa.Name = "dgv_hangHoa";
            this.dgv_hangHoa.ReadOnly = true;
            this.dgv_hangHoa.RowHeadersWidth = 51;
            this.dgv_hangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hangHoa.Size = new System.Drawing.Size(682, 339);
            this.dgv_hangHoa.TabIndex = 8;
            this.dgv_hangHoa.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hangHoa_RowEnter);
            // 
            // MaHangHoa
            // 
            this.MaHangHoa.DataPropertyName = "MaHangHoa";
            this.MaHangHoa.HeaderText = "Mã hàng hoá";
            this.MaHangHoa.MinimumWidth = 6;
            this.MaHangHoa.Name = "MaHangHoa";
            this.MaHangHoa.ReadOnly = true;
            this.MaHangHoa.Width = 150;
            // 
            // TenHangHoa
            // 
            this.TenHangHoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHangHoa.DataPropertyName = "TenHangHoa";
            this.TenHangHoa.HeaderText = "TenHangHoa";
            this.TenHangHoa.MinimumWidth = 6;
            this.TenHangHoa.Name = "TenHangHoa";
            this.TenHangHoa.ReadOnly = true;
            // 
            // but_them
            // 
            this.but_them.Image = ((System.Drawing.Image)(resources.GetObject("but_them.Image")));
            this.but_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_them.Location = new System.Drawing.Point(107, 151);
            this.but_them.Name = "but_them";
            this.but_them.Size = new System.Drawing.Size(100, 40);
            this.but_them.TabIndex = 2;
            this.but_them.Text = "Thêm";
            this.but_them.UseVisualStyleBackColor = true;
            this.but_them.Click += new System.EventHandler(this.but_them_Click);
            // 
            // but_sua
            // 
            this.but_sua.Image = ((System.Drawing.Image)(resources.GetObject("but_sua.Image")));
            this.but_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_sua.Location = new System.Drawing.Point(213, 151);
            this.but_sua.Name = "but_sua";
            this.but_sua.Size = new System.Drawing.Size(100, 40);
            this.but_sua.TabIndex = 3;
            this.but_sua.Text = "Sửa";
            this.but_sua.UseVisualStyleBackColor = true;
            this.but_sua.Click += new System.EventHandler(this.but_sua_Click);
            // 
            // but_xoa
            // 
            this.but_xoa.Image = ((System.Drawing.Image)(resources.GetObject("but_xoa.Image")));
            this.but_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_xoa.Location = new System.Drawing.Point(319, 151);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(100, 40);
            this.but_xoa.TabIndex = 4;
            this.but_xoa.Text = "Xoá";
            this.but_xoa.UseVisualStyleBackColor = true;
            this.but_xoa.Click += new System.EventHandler(this.but_xoa_Click);
            // 
            // but_timKiem
            // 
            this.but_timKiem.Enabled = false;
            this.but_timKiem.Image = ((System.Drawing.Image)(resources.GetObject("but_timKiem.Image")));
            this.but_timKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_timKiem.Location = new System.Drawing.Point(425, 151);
            this.but_timKiem.Name = "but_timKiem";
            this.but_timKiem.Size = new System.Drawing.Size(100, 40);
            this.but_timKiem.TabIndex = 5;
            this.but_timKiem.Text = "Tìm";
            this.but_timKiem.UseVisualStyleBackColor = true;
            this.but_timKiem.Click += new System.EventHandler(this.but_timKiem_Click);
            // 
            // errorMess
            // 
            this.errorMess.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(944, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(67, 17);
            this.status.Text = "Thông báo:";
            // 
            // but_loaiHang
            // 
            this.but_loaiHang.Image = ((System.Drawing.Image)(resources.GetObject("but_loaiHang.Image")));
            this.but_loaiHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_loaiHang.Location = new System.Drawing.Point(637, 151);
            this.but_loaiHang.Name = "but_loaiHang";
            this.but_loaiHang.Size = new System.Drawing.Size(100, 40);
            this.but_loaiHang.TabIndex = 7;
            this.but_loaiHang.Text = "Loại hàng";
            this.but_loaiHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_loaiHang.UseVisualStyleBackColor = true;
            this.but_loaiHang.Click += new System.EventHandler(this.but_loaiHang_Click);
            // 
            // but_donViTinh
            // 
            this.but_donViTinh.Image = ((System.Drawing.Image)(resources.GetObject("but_donViTinh.Image")));
            this.but_donViTinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_donViTinh.Location = new System.Drawing.Point(531, 151);
            this.but_donViTinh.Name = "but_donViTinh";
            this.but_donViTinh.Size = new System.Drawing.Size(100, 40);
            this.but_donViTinh.TabIndex = 6;
            this.but_donViTinh.Text = "Đơn vị tính";
            this.but_donViTinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_donViTinh.UseVisualStyleBackColor = true;
            this.but_donViTinh.Click += new System.EventHandler(this.but_donViTinh_Click);
            // 
            // but_dong
            // 
            this.but_dong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_dong.Image = ((System.Drawing.Image)(resources.GetObject("but_dong.Image")));
            this.but_dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_dong.Location = new System.Drawing.Point(832, 151);
            this.but_dong.Name = "but_dong";
            this.but_dong.Size = new System.Drawing.Size(100, 40);
            this.but_dong.TabIndex = 10;
            this.but_dong.Text = "Đóng";
            this.but_dong.UseVisualStyleBackColor = true;
            this.but_dong.Click += new System.EventHandler(this.but_dong_Click);
            // 
            // ck_timKiem
            // 
            this.ck_timKiem.AutoSize = true;
            this.ck_timKiem.Location = new System.Drawing.Point(12, 160);
            this.ck_timKiem.Name = "ck_timKiem";
            this.ck_timKiem.Size = new System.Drawing.Size(82, 24);
            this.ck_timKiem.TabIndex = 1;
            this.ck_timKiem.Text = "Tìm kiếm";
            this.ck_timKiem.UseVisualStyleBackColor = true;
            this.ck_timKiem.CheckedChanged += new System.EventHandler(this.ck_timKiem_CheckedChanged);
            // 
            // tv_chiTietHangHoa
            // 
            this.tv_chiTietHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv_chiTietHangHoa.Location = new System.Drawing.Point(700, 197);
            this.tv_chiTietHangHoa.Name = "tv_chiTietHangHoa";
            this.tv_chiTietHangHoa.Size = new System.Drawing.Size(232, 339);
            this.tv_chiTietHangHoa.TabIndex = 9;
            // 
            // FrmQuanLyHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.dgv_hangHoa);
            this.Controls.Add(this.but_dong);
            this.Controls.Add(this.but_donViTinh);
            this.Controls.Add(this.but_loaiHang);
            this.Controls.Add(this.tv_chiTietHangHoa);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.but_timKiem);
            this.Controls.Add(this.but_xoa);
            this.Controls.Add(this.but_sua);
            this.Controls.Add(this.but_them);
            this.Controls.Add(this.ck_timKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmQuanLyHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ HÀNG HOÁ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMess)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tenHangHoa;
        private System.Windows.Forms.TextBox txt_maHangHoa;
        private System.Windows.Forms.Button but_them;
        private System.Windows.Forms.Button but_sua;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.Button but_timKiem;
        private System.Windows.Forms.DataGridView dgv_hangHoa;
        private System.Windows.Forms.ErrorProvider errorMess;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangHoa;
        private System.Windows.Forms.CheckBox ck_maHangHoa;
        private System.Windows.Forms.CheckBox ck_tenHangHoa;
        private System.Windows.Forms.Button but_loaiHang;
        private System.Windows.Forms.Button but_donViTinh;
        private System.Windows.Forms.Button but_dong;
        private System.Windows.Forms.CheckBox ck_timKiem;
        private System.Windows.Forms.TreeView tv_chiTietHangHoa;
    }
}