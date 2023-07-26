
namespace QuanLyKho_Tuan1
{
    partial class FrmQuanLyNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyNguoiDung));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_nguoiDung = new System.Windows.Forms.DataGridView();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tv_chucNang = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_false = new System.Windows.Forms.RadioButton();
            this.rb_true = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_matKhau2 = new System.Windows.Forms.TextBox();
            this.txt_matKhau1 = new System.Windows.Forms.TextBox();
            this.txt_tenDangNhap = new System.Windows.Forms.TextBox();
            this.but_themTaiKhoan = new System.Windows.Forms.Button();
            this.errorMess = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ck_quanLyPhieuXuat = new System.Windows.Forms.CheckBox();
            this.ck_quanLyPhieuNhap = new System.Windows.Forms.CheckBox();
            this.ck_quanLyKho = new System.Windows.Forms.CheckBox();
            this.ck_quanLyDonViTinh = new System.Windows.Forms.CheckBox();
            this.ck_quanLyHangHoa = new System.Windows.Forms.CheckBox();
            this.ck_quanLyLoaiHang = new System.Windows.Forms.CheckBox();
            this.ck_quanLyNguoiDung = new System.Windows.Forms.CheckBox();
            this.but_suaTaiKhoan = new System.Windows.Forms.Button();
            this.but_xoaTaiKhoan = new System.Windows.Forms.Button();
            this.but_lamMoi = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.but_dong = new System.Windows.Forms.Button();
            this.ck_quanLyKiemKho = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguoiDung)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMess)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NGƯỜI DÙNG";
            // 
            // dgv_nguoiDung
            // 
            this.dgv_nguoiDung.AllowUserToAddRows = false;
            this.dgv_nguoiDung.AllowUserToDeleteRows = false;
            this.dgv_nguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_nguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDangNhap,
            this.TrangThai});
            this.dgv_nguoiDung.Location = new System.Drawing.Point(12, 246);
            this.dgv_nguoiDung.MultiSelect = false;
            this.dgv_nguoiDung.Name = "dgv_nguoiDung";
            this.dgv_nguoiDung.ReadOnly = true;
            this.dgv_nguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nguoiDung.Size = new System.Drawing.Size(682, 290);
            this.dgv_nguoiDung.TabIndex = 3;
            this.dgv_nguoiDung.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nguoiDung_RowEnter);
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.ReadOnly = true;
            this.TenDangNhap.Width = 150;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // tv_chucNang
            // 
            this.tv_chucNang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv_chucNang.Location = new System.Drawing.Point(700, 246);
            this.tv_chucNang.Name = "tv_chucNang";
            this.tv_chucNang.Size = new System.Drawing.Size(235, 290);
            this.tv_chucNang.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_false);
            this.groupBox3.Controls.Add(this.rb_true);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_matKhau2);
            this.groupBox3.Controls.Add(this.txt_matKhau1);
            this.groupBox3.Controls.Add(this.txt_tenDangNhap);
            this.groupBox3.Location = new System.Drawing.Point(12, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(455, 151);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin tài khoản";
            // 
            // rb_false
            // 
            this.rb_false.AutoSize = true;
            this.rb_false.Location = new System.Drawing.Point(190, 115);
            this.rb_false.Name = "rb_false";
            this.rb_false.Size = new System.Drawing.Size(63, 24);
            this.rb_false.TabIndex = 4;
            this.rb_false.Text = "Không";
            this.rb_false.UseVisualStyleBackColor = true;
            // 
            // rb_true
            // 
            this.rb_true.AutoSize = true;
            this.rb_true.Checked = true;
            this.rb_true.Location = new System.Drawing.Point(104, 115);
            this.rb_true.Name = "rb_true";
            this.rb_true.Size = new System.Drawing.Size(80, 24);
            this.rb_true.TabIndex = 3;
            this.rb_true.TabStop = true;
            this.rb_true.Text = "Kích hoạt";
            this.rb_true.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên đăng nhập";
            // 
            // txt_matKhau2
            // 
            this.txt_matKhau2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_matKhau2.Location = new System.Drawing.Point(108, 84);
            this.txt_matKhau2.Name = "txt_matKhau2";
            this.txt_matKhau2.PasswordChar = '*';
            this.txt_matKhau2.Size = new System.Drawing.Size(326, 25);
            this.txt_matKhau2.TabIndex = 2;
            // 
            // txt_matKhau1
            // 
            this.txt_matKhau1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_matKhau1.Location = new System.Drawing.Point(108, 53);
            this.txt_matKhau1.Name = "txt_matKhau1";
            this.txt_matKhau1.PasswordChar = '*';
            this.txt_matKhau1.Size = new System.Drawing.Size(326, 25);
            this.txt_matKhau1.TabIndex = 1;
            // 
            // txt_tenDangNhap
            // 
            this.txt_tenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tenDangNhap.Location = new System.Drawing.Point(108, 22);
            this.txt_tenDangNhap.Name = "txt_tenDangNhap";
            this.txt_tenDangNhap.Size = new System.Drawing.Size(326, 25);
            this.txt_tenDangNhap.TabIndex = 0;
            // 
            // but_themTaiKhoan
            // 
            this.but_themTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("but_themTaiKhoan.Image")));
            this.but_themTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_themTaiKhoan.Location = new System.Drawing.Point(12, 200);
            this.but_themTaiKhoan.Name = "but_themTaiKhoan";
            this.but_themTaiKhoan.Size = new System.Drawing.Size(130, 40);
            this.but_themTaiKhoan.TabIndex = 5;
            this.but_themTaiKhoan.Text = "Thêm tài khoản";
            this.but_themTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_themTaiKhoan.UseVisualStyleBackColor = true;
            this.but_themTaiKhoan.Click += new System.EventHandler(this.but_themTaiKhoan_Click);
            // 
            // errorMess
            // 
            this.errorMess.ContainerControl = this;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.ck_quanLyKiemKho);
            this.groupBox4.Controls.Add(this.ck_quanLyPhieuXuat);
            this.groupBox4.Controls.Add(this.ck_quanLyPhieuNhap);
            this.groupBox4.Controls.Add(this.ck_quanLyKho);
            this.groupBox4.Controls.Add(this.ck_quanLyDonViTinh);
            this.groupBox4.Controls.Add(this.ck_quanLyHangHoa);
            this.groupBox4.Controls.Add(this.ck_quanLyLoaiHang);
            this.groupBox4.Controls.Add(this.ck_quanLyNguoiDung);
            this.groupBox4.Location = new System.Drawing.Point(473, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(459, 151);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng người dùng";
            // 
            // ck_quanLyPhieuXuat
            // 
            this.ck_quanLyPhieuXuat.AutoSize = true;
            this.ck_quanLyPhieuXuat.Location = new System.Drawing.Point(259, 80);
            this.ck_quanLyPhieuXuat.Name = "ck_quanLyPhieuXuat";
            this.ck_quanLyPhieuXuat.Size = new System.Drawing.Size(133, 24);
            this.ck_quanLyPhieuXuat.TabIndex = 7;
            this.ck_quanLyPhieuXuat.Text = "Quản lý phiếu xuất";
            this.ck_quanLyPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // ck_quanLyPhieuNhap
            // 
            this.ck_quanLyPhieuNhap.AutoSize = true;
            this.ck_quanLyPhieuNhap.Location = new System.Drawing.Point(259, 50);
            this.ck_quanLyPhieuNhap.Name = "ck_quanLyPhieuNhap";
            this.ck_quanLyPhieuNhap.Size = new System.Drawing.Size(138, 24);
            this.ck_quanLyPhieuNhap.TabIndex = 7;
            this.ck_quanLyPhieuNhap.Text = "Quản lý phiếu nhập";
            this.ck_quanLyPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // ck_quanLyKho
            // 
            this.ck_quanLyKho.AutoSize = true;
            this.ck_quanLyKho.Location = new System.Drawing.Point(259, 20);
            this.ck_quanLyKho.Name = "ck_quanLyKho";
            this.ck_quanLyKho.Size = new System.Drawing.Size(94, 24);
            this.ck_quanLyKho.TabIndex = 7;
            this.ck_quanLyKho.Text = "Quản lý kho";
            this.ck_quanLyKho.UseVisualStyleBackColor = true;
            // 
            // ck_quanLyDonViTinh
            // 
            this.ck_quanLyDonViTinh.AutoSize = true;
            this.ck_quanLyDonViTinh.Location = new System.Drawing.Point(6, 111);
            this.ck_quanLyDonViTinh.Name = "ck_quanLyDonViTinh";
            this.ck_quanLyDonViTinh.Size = new System.Drawing.Size(131, 24);
            this.ck_quanLyDonViTinh.TabIndex = 7;
            this.ck_quanLyDonViTinh.Text = "Quản lý đơn vị tính";
            this.ck_quanLyDonViTinh.UseVisualStyleBackColor = true;
            // 
            // ck_quanLyHangHoa
            // 
            this.ck_quanLyHangHoa.AutoSize = true;
            this.ck_quanLyHangHoa.Location = new System.Drawing.Point(6, 81);
            this.ck_quanLyHangHoa.Name = "ck_quanLyHangHoa";
            this.ck_quanLyHangHoa.Size = new System.Drawing.Size(126, 24);
            this.ck_quanLyHangHoa.TabIndex = 7;
            this.ck_quanLyHangHoa.Text = "Quản lý hàng hoá";
            this.ck_quanLyHangHoa.UseVisualStyleBackColor = true;
            // 
            // ck_quanLyLoaiHang
            // 
            this.ck_quanLyLoaiHang.AutoSize = true;
            this.ck_quanLyLoaiHang.Location = new System.Drawing.Point(6, 51);
            this.ck_quanLyLoaiHang.Name = "ck_quanLyLoaiHang";
            this.ck_quanLyLoaiHang.Size = new System.Drawing.Size(126, 24);
            this.ck_quanLyLoaiHang.TabIndex = 7;
            this.ck_quanLyLoaiHang.Text = "Quản lý loại hàng";
            this.ck_quanLyLoaiHang.UseVisualStyleBackColor = true;
            // 
            // ck_quanLyNguoiDung
            // 
            this.ck_quanLyNguoiDung.AutoSize = true;
            this.ck_quanLyNguoiDung.Location = new System.Drawing.Point(6, 24);
            this.ck_quanLyNguoiDung.Name = "ck_quanLyNguoiDung";
            this.ck_quanLyNguoiDung.Size = new System.Drawing.Size(139, 24);
            this.ck_quanLyNguoiDung.TabIndex = 7;
            this.ck_quanLyNguoiDung.Text = "Quản lý người dùng";
            this.ck_quanLyNguoiDung.UseVisualStyleBackColor = true;
            // 
            // but_suaTaiKhoan
            // 
            this.but_suaTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("but_suaTaiKhoan.Image")));
            this.but_suaTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_suaTaiKhoan.Location = new System.Drawing.Point(148, 200);
            this.but_suaTaiKhoan.Name = "but_suaTaiKhoan";
            this.but_suaTaiKhoan.Size = new System.Drawing.Size(130, 40);
            this.but_suaTaiKhoan.TabIndex = 5;
            this.but_suaTaiKhoan.Text = "Sửa tài khoản";
            this.but_suaTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_suaTaiKhoan.UseVisualStyleBackColor = true;
            this.but_suaTaiKhoan.Click += new System.EventHandler(this.but_suaTaiKhoan_Click);
            // 
            // but_xoaTaiKhoan
            // 
            this.but_xoaTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("but_xoaTaiKhoan.Image")));
            this.but_xoaTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_xoaTaiKhoan.Location = new System.Drawing.Point(284, 200);
            this.but_xoaTaiKhoan.Name = "but_xoaTaiKhoan";
            this.but_xoaTaiKhoan.Size = new System.Drawing.Size(130, 40);
            this.but_xoaTaiKhoan.TabIndex = 5;
            this.but_xoaTaiKhoan.Text = "Xoá tài khoản";
            this.but_xoaTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_xoaTaiKhoan.UseVisualStyleBackColor = true;
            this.but_xoaTaiKhoan.Click += new System.EventHandler(this.but_xoaTaiKhoan_Click);
            // 
            // but_lamMoi
            // 
            this.but_lamMoi.Image = ((System.Drawing.Image)(resources.GetObject("but_lamMoi.Image")));
            this.but_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_lamMoi.Location = new System.Drawing.Point(420, 200);
            this.but_lamMoi.Name = "but_lamMoi";
            this.but_lamMoi.Size = new System.Drawing.Size(130, 40);
            this.but_lamMoi.TabIndex = 5;
            this.but_lamMoi.Text = "Làm mới";
            this.but_lamMoi.UseVisualStyleBackColor = true;
            this.but_lamMoi.Click += new System.EventHandler(this.but_lamMoi_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(944, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(67, 17);
            this.status.Text = "Thông báo:";
            // 
            // but_dong
            // 
            this.but_dong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_dong.Image = ((System.Drawing.Image)(resources.GetObject("but_dong.Image")));
            this.but_dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_dong.Location = new System.Drawing.Point(832, 200);
            this.but_dong.Name = "but_dong";
            this.but_dong.Size = new System.Drawing.Size(100, 40);
            this.but_dong.TabIndex = 22;
            this.but_dong.Text = "Đóng";
            this.but_dong.UseVisualStyleBackColor = true;
            this.but_dong.Click += new System.EventHandler(this.but_dong_Click);
            // 
            // ck_quanLyKiemKho
            // 
            this.ck_quanLyKiemKho.AutoSize = true;
            this.ck_quanLyKiemKho.Location = new System.Drawing.Point(259, 110);
            this.ck_quanLyKiemKho.Name = "ck_quanLyKiemKho";
            this.ck_quanLyKiemKho.Size = new System.Drawing.Size(125, 24);
            this.ck_quanLyKiemKho.TabIndex = 8;
            this.ck_quanLyKiemKho.Text = "Quản lý kiểm kho";
            this.ck_quanLyKiemKho.UseVisualStyleBackColor = true;
            // 
            // FrmQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.but_dong);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tv_chucNang);
            this.Controls.Add(this.dgv_nguoiDung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_lamMoi);
            this.Controls.Add(this.but_xoaTaiKhoan);
            this.Controls.Add(this.but_suaTaiKhoan);
            this.Controls.Add(this.but_themTaiKhoan);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmQuanLyNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NGƯỜI DÙNG";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguoiDung)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMess)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_nguoiDung;
        private System.Windows.Forms.TreeView tv_chucNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_matKhau1;
        private System.Windows.Forms.TextBox txt_tenDangNhap;
        private System.Windows.Forms.Button but_themTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_matKhau2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_false;
        private System.Windows.Forms.RadioButton rb_true;
        private System.Windows.Forms.ErrorProvider errorMess;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button but_xoaTaiKhoan;
        private System.Windows.Forms.Button but_suaTaiKhoan;
        private System.Windows.Forms.CheckBox ck_quanLyPhieuXuat;
        private System.Windows.Forms.CheckBox ck_quanLyPhieuNhap;
        private System.Windows.Forms.CheckBox ck_quanLyKho;
        private System.Windows.Forms.CheckBox ck_quanLyDonViTinh;
        private System.Windows.Forms.CheckBox ck_quanLyHangHoa;
        private System.Windows.Forms.CheckBox ck_quanLyLoaiHang;
        private System.Windows.Forms.CheckBox ck_quanLyNguoiDung;
        private System.Windows.Forms.Button but_lamMoi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.Button but_dong;
        private System.Windows.Forms.CheckBox ck_quanLyKiemKho;
    }
}