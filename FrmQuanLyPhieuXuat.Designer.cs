
namespace QuanLyKho_Tuan1
{
    partial class FrmQuanLyPhieuXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyPhieuXuat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ck_hienThiKho = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ck_hienThiNoiNhan = new System.Windows.Forms.CheckBox();
            this.ck_hienThiNguoiNhanHang = new System.Windows.Forms.CheckBox();
            this.ck_hienThiThuKho = new System.Windows.Forms.CheckBox();
            this.ck_hienThiGhiChu = new System.Windows.Forms.CheckBox();
            this.but_timKiem = new System.Windows.Forms.Button();
            this.ck_ghiChu = new System.Windows.Forms.CheckBox();
            this.cbb_donViTinh = new System.Windows.Forms.ComboBox();
            this.cbb_hangHoa = new System.Windows.Forms.ComboBox();
            this.cbb_kho = new System.Windows.Forms.ComboBox();
            this.ck_donViTinh = new System.Windows.Forms.CheckBox();
            this.dtp_ngayXuatDen = new System.Windows.Forms.DateTimePicker();
            this.ck_hangHoa = new System.Windows.Forms.CheckBox();
            this.txt_ghiChu = new System.Windows.Forms.TextBox();
            this.tv_chiTietPhieuXuat = new System.Windows.Forms.TreeView();
            this.ck_maKho = new System.Windows.Forms.CheckBox();
            this.ck_chietKhau = new System.Windows.Forms.CheckBox();
            this.ck_donGia = new System.Windows.Forms.CheckBox();
            this.ck_soLuong = new System.Windows.Forms.CheckBox();
            this.ck_thuKho = new System.Windows.Forms.CheckBox();
            this.ck_noiNhan = new System.Windows.Forms.CheckBox();
            this.txt_thuKho = new System.Windows.Forms.TextBox();
            this.ck_nguoiNhanHang = new System.Windows.Forms.CheckBox();
            this.txt_chietKhau = new System.Windows.Forms.TextBox();
            this.ck_ngayXuatDen = new System.Windows.Forms.CheckBox();
            this.txt_donGia = new System.Windows.Forms.TextBox();
            this.dtp_ngayXuatTu = new System.Windows.Forms.DateTimePicker();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.ck_timKiem = new System.Windows.Forms.CheckBox();
            this.txt_noiNhan = new System.Windows.Forms.TextBox();
            this.dgv_phieuXuat = new System.Windows.Forms.DataGridView();
            this.MaPhieuXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiNhanHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThuKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_xoa = new System.Windows.Forms.Button();
            this.but_sua = new System.Windows.Forms.Button();
            this.but_them = new System.Windows.Forms.Button();
            this.ck_ngayXuatTu = new System.Windows.Forms.CheckBox();
            this.txt_nguoiNhanHang = new System.Windows.Forms.TextBox();
            this.txt_maPhieuXuat = new System.Windows.Forms.TextBox();
            this.ck_maPhieuXuat = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_dong = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuXuat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ck_hienThiKho
            // 
            this.ck_hienThiKho.AutoSize = true;
            this.ck_hienThiKho.Checked = true;
            this.ck_hienThiKho.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_hienThiKho.Location = new System.Drawing.Point(6, 92);
            this.ck_hienThiKho.Name = "ck_hienThiKho";
            this.ck_hienThiKho.Size = new System.Drawing.Size(84, 21);
            this.ck_hienThiKho.TabIndex = 2;
            this.ck_hienThiKho.Text = "Kho xuất";
            this.ck_hienThiKho.UseVisualStyleBackColor = true;
            this.ck_hienThiKho.CheckedChanged += new System.EventHandler(this.ck_hienThiKho_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.ck_hienThiNoiNhan);
            this.groupBox2.Controls.Add(this.ck_hienThiKho);
            this.groupBox2.Controls.Add(this.ck_hienThiNguoiNhanHang);
            this.groupBox2.Controls.Add(this.ck_hienThiThuKho);
            this.groupBox2.Controls.Add(this.ck_hienThiGhiChu);
            this.groupBox2.Location = new System.Drawing.Point(12, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 347);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hiển thị";
            // 
            // ck_hienThiNoiNhan
            // 
            this.ck_hienThiNoiNhan.AutoSize = true;
            this.ck_hienThiNoiNhan.Checked = true;
            this.ck_hienThiNoiNhan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_hienThiNoiNhan.Location = new System.Drawing.Point(6, 59);
            this.ck_hienThiNoiNhan.Name = "ck_hienThiNoiNhan";
            this.ck_hienThiNoiNhan.Size = new System.Drawing.Size(86, 21);
            this.ck_hienThiNoiNhan.TabIndex = 1;
            this.ck_hienThiNoiNhan.Text = "Nơi nhận";
            this.ck_hienThiNoiNhan.UseVisualStyleBackColor = true;
            this.ck_hienThiNoiNhan.CheckedChanged += new System.EventHandler(this.ck_hienThiNoiNhan_CheckedChanged);
            // 
            // ck_hienThiNguoiNhanHang
            // 
            this.ck_hienThiNguoiNhanHang.AutoSize = true;
            this.ck_hienThiNguoiNhanHang.Checked = true;
            this.ck_hienThiNguoiNhanHang.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_hienThiNguoiNhanHang.Location = new System.Drawing.Point(6, 26);
            this.ck_hienThiNguoiNhanHang.Name = "ck_hienThiNguoiNhanHang";
            this.ck_hienThiNguoiNhanHang.Size = new System.Drawing.Size(140, 21);
            this.ck_hienThiNguoiNhanHang.TabIndex = 0;
            this.ck_hienThiNguoiNhanHang.Text = "Người nhận hàng";
            this.ck_hienThiNguoiNhanHang.UseVisualStyleBackColor = true;
            this.ck_hienThiNguoiNhanHang.CheckedChanged += new System.EventHandler(this.ck_hienThiNguoiNhanHang_CheckedChanged);
            // 
            // ck_hienThiThuKho
            // 
            this.ck_hienThiThuKho.AutoSize = true;
            this.ck_hienThiThuKho.Checked = true;
            this.ck_hienThiThuKho.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_hienThiThuKho.Location = new System.Drawing.Point(6, 125);
            this.ck_hienThiThuKho.Name = "ck_hienThiThuKho";
            this.ck_hienThiThuKho.Size = new System.Drawing.Size(79, 21);
            this.ck_hienThiThuKho.TabIndex = 3;
            this.ck_hienThiThuKho.Text = "Thủ kho";
            this.ck_hienThiThuKho.UseVisualStyleBackColor = true;
            this.ck_hienThiThuKho.CheckedChanged += new System.EventHandler(this.ck_hienThiThuKho_CheckedChanged);
            // 
            // ck_hienThiGhiChu
            // 
            this.ck_hienThiGhiChu.AutoSize = true;
            this.ck_hienThiGhiChu.Checked = true;
            this.ck_hienThiGhiChu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_hienThiGhiChu.Location = new System.Drawing.Point(6, 158);
            this.ck_hienThiGhiChu.Name = "ck_hienThiGhiChu";
            this.ck_hienThiGhiChu.Size = new System.Drawing.Size(77, 21);
            this.ck_hienThiGhiChu.TabIndex = 4;
            this.ck_hienThiGhiChu.Text = "Ghi chú";
            this.ck_hienThiGhiChu.UseVisualStyleBackColor = true;
            this.ck_hienThiGhiChu.CheckedChanged += new System.EventHandler(this.ck_hienThiGhiChu_CheckedChanged);
            // 
            // but_timKiem
            // 
            this.but_timKiem.Image = ((System.Drawing.Image)(resources.GetObject("but_timKiem.Image")));
            this.but_timKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_timKiem.Location = new System.Drawing.Point(330, 258);
            this.but_timKiem.Name = "but_timKiem";
            this.but_timKiem.Size = new System.Drawing.Size(100, 40);
            this.but_timKiem.TabIndex = 5;
            this.but_timKiem.Text = "Tìm";
            this.but_timKiem.UseVisualStyleBackColor = true;
            this.but_timKiem.Click += new System.EventHandler(this.but_timKiem_Click);
            // 
            // ck_ghiChu
            // 
            this.ck_ghiChu.AutoSize = true;
            this.ck_ghiChu.Location = new System.Drawing.Point(6, 93);
            this.ck_ghiChu.Name = "ck_ghiChu";
            this.ck_ghiChu.Size = new System.Drawing.Size(77, 21);
            this.ck_ghiChu.TabIndex = 14;
            this.ck_ghiChu.Text = "Ghi chú";
            this.ck_ghiChu.UseVisualStyleBackColor = true;
            this.ck_ghiChu.CheckedChanged += new System.EventHandler(this.ck_ghiChu_CheckedChanged);
            // 
            // cbb_donViTinh
            // 
            this.cbb_donViTinh.DisplayMember = "TenDonViTinh";
            this.cbb_donViTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_donViTinh.Enabled = false;
            this.cbb_donViTinh.FormattingEnabled = true;
            this.cbb_donViTinh.Location = new System.Drawing.Point(442, 124);
            this.cbb_donViTinh.Name = "cbb_donViTinh";
            this.cbb_donViTinh.Size = new System.Drawing.Size(123, 25);
            this.cbb_donViTinh.TabIndex = 19;
            this.cbb_donViTinh.ValueMember = "MaDonViTinh";
            // 
            // cbb_hangHoa
            // 
            this.cbb_hangHoa.DisplayMember = "TenHangHoa";
            this.cbb_hangHoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_hangHoa.Enabled = false;
            this.cbb_hangHoa.FormattingEnabled = true;
            this.cbb_hangHoa.Location = new System.Drawing.Point(149, 124);
            this.cbb_hangHoa.Name = "cbb_hangHoa";
            this.cbb_hangHoa.Size = new System.Drawing.Size(157, 25);
            this.cbb_hangHoa.TabIndex = 17;
            this.cbb_hangHoa.ValueMember = "MaHangHoa";
            this.cbb_hangHoa.SelectedIndexChanged += new System.EventHandler(this.cbb_hangHoa_SelectedIndexChanged);
            // 
            // cbb_kho
            // 
            this.cbb_kho.DisplayMember = "TenKho";
            this.cbb_kho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_kho.Enabled = false;
            this.cbb_kho.FormattingEnabled = true;
            this.cbb_kho.Location = new System.Drawing.Point(442, 58);
            this.cbb_kho.Name = "cbb_kho";
            this.cbb_kho.Size = new System.Drawing.Size(123, 25);
            this.cbb_kho.TabIndex = 11;
            this.cbb_kho.ValueMember = "MaKho";
            // 
            // ck_donViTinh
            // 
            this.ck_donViTinh.AutoSize = true;
            this.ck_donViTinh.Location = new System.Drawing.Point(311, 126);
            this.ck_donViTinh.Name = "ck_donViTinh";
            this.ck_donViTinh.Size = new System.Drawing.Size(97, 21);
            this.ck_donViTinh.TabIndex = 18;
            this.ck_donViTinh.Text = "Đơn vị tính";
            this.ck_donViTinh.UseVisualStyleBackColor = true;
            this.ck_donViTinh.CheckedChanged += new System.EventHandler(this.ck_donViTinh_CheckedChanged);
            // 
            // dtp_ngayXuatDen
            // 
            this.dtp_ngayXuatDen.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngayXuatDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayXuatDen.Location = new System.Drawing.Point(716, 23);
            this.dtp_ngayXuatDen.Name = "dtp_ngayXuatDen";
            this.dtp_ngayXuatDen.Size = new System.Drawing.Size(123, 25);
            this.dtp_ngayXuatDen.TabIndex = 5;
            // 
            // ck_hangHoa
            // 
            this.ck_hangHoa.AutoSize = true;
            this.ck_hangHoa.Location = new System.Drawing.Point(6, 126);
            this.ck_hangHoa.Name = "ck_hangHoa";
            this.ck_hangHoa.Size = new System.Drawing.Size(89, 21);
            this.ck_hangHoa.TabIndex = 16;
            this.ck_hangHoa.Text = "Hàng hoá";
            this.ck_hangHoa.UseVisualStyleBackColor = true;
            this.ck_hangHoa.CheckedChanged += new System.EventHandler(this.ck_hangHoa_CheckedChanged);
            // 
            // txt_ghiChu
            // 
            this.txt_ghiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ghiChu.Enabled = false;
            this.txt_ghiChu.Location = new System.Drawing.Point(149, 91);
            this.txt_ghiChu.Name = "txt_ghiChu";
            this.txt_ghiChu.Size = new System.Drawing.Size(1003, 25);
            this.txt_ghiChu.TabIndex = 15;
            // 
            // tv_chiTietPhieuXuat
            // 
            this.tv_chiTietPhieuXuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv_chiTietPhieuXuat.Location = new System.Drawing.Point(939, 303);
            this.tv_chiTietPhieuXuat.Name = "tv_chiTietPhieuXuat";
            this.tv_chiTietPhieuXuat.Size = new System.Drawing.Size(233, 346);
            this.tv_chiTietPhieuXuat.TabIndex = 8;
            // 
            // ck_maKho
            // 
            this.ck_maKho.AutoSize = true;
            this.ck_maKho.Location = new System.Drawing.Point(312, 60);
            this.ck_maKho.Name = "ck_maKho";
            this.ck_maKho.Size = new System.Drawing.Size(89, 21);
            this.ck_maKho.TabIndex = 10;
            this.ck_maKho.Text = "Kho nhập";
            this.ck_maKho.UseVisualStyleBackColor = true;
            this.ck_maKho.CheckedChanged += new System.EventHandler(this.ck_maKho_CheckedChanged);
            // 
            // ck_chietKhau
            // 
            this.ck_chietKhau.AutoSize = true;
            this.ck_chietKhau.Location = new System.Drawing.Point(571, 159);
            this.ck_chietKhau.Name = "ck_chietKhau";
            this.ck_chietKhau.Size = new System.Drawing.Size(96, 21);
            this.ck_chietKhau.TabIndex = 24;
            this.ck_chietKhau.Text = "Chiết khấu";
            this.ck_chietKhau.UseVisualStyleBackColor = true;
            this.ck_chietKhau.CheckedChanged += new System.EventHandler(this.ck_chietKhau_CheckedChanged);
            // 
            // ck_donGia
            // 
            this.ck_donGia.AutoSize = true;
            this.ck_donGia.Location = new System.Drawing.Point(311, 159);
            this.ck_donGia.Name = "ck_donGia";
            this.ck_donGia.Size = new System.Drawing.Size(79, 21);
            this.ck_donGia.TabIndex = 22;
            this.ck_donGia.Text = "Đơn giá";
            this.ck_donGia.UseVisualStyleBackColor = true;
            this.ck_donGia.CheckedChanged += new System.EventHandler(this.ck_donGia_CheckedChanged);
            // 
            // ck_soLuong
            // 
            this.ck_soLuong.AutoSize = true;
            this.ck_soLuong.Location = new System.Drawing.Point(6, 159);
            this.ck_soLuong.Name = "ck_soLuong";
            this.ck_soLuong.Size = new System.Drawing.Size(88, 21);
            this.ck_soLuong.TabIndex = 20;
            this.ck_soLuong.Text = "Số lượng";
            this.ck_soLuong.UseVisualStyleBackColor = true;
            this.ck_soLuong.CheckedChanged += new System.EventHandler(this.ck_soLuong_CheckedChanged);
            // 
            // ck_thuKho
            // 
            this.ck_thuKho.AutoSize = true;
            this.ck_thuKho.Location = new System.Drawing.Point(571, 60);
            this.ck_thuKho.Name = "ck_thuKho";
            this.ck_thuKho.Size = new System.Drawing.Size(79, 21);
            this.ck_thuKho.TabIndex = 12;
            this.ck_thuKho.Text = "Thủ kho";
            this.ck_thuKho.UseVisualStyleBackColor = true;
            this.ck_thuKho.CheckedChanged += new System.EventHandler(this.ck_thuKho_CheckedChanged);
            // 
            // ck_noiNhan
            // 
            this.ck_noiNhan.AutoSize = true;
            this.ck_noiNhan.Location = new System.Drawing.Point(6, 60);
            this.ck_noiNhan.Name = "ck_noiNhan";
            this.ck_noiNhan.Size = new System.Drawing.Size(86, 21);
            this.ck_noiNhan.TabIndex = 8;
            this.ck_noiNhan.Text = "Nơi nhận";
            this.ck_noiNhan.UseVisualStyleBackColor = true;
            this.ck_noiNhan.CheckedChanged += new System.EventHandler(this.ck_noiNhan_CheckedChanged);
            // 
            // txt_thuKho
            // 
            this.txt_thuKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_thuKho.Enabled = false;
            this.txt_thuKho.Location = new System.Drawing.Point(716, 58);
            this.txt_thuKho.Name = "txt_thuKho";
            this.txt_thuKho.Size = new System.Drawing.Size(436, 25);
            this.txt_thuKho.TabIndex = 13;
            // 
            // ck_nguoiNhanHang
            // 
            this.ck_nguoiNhanHang.AutoSize = true;
            this.ck_nguoiNhanHang.Location = new System.Drawing.Point(845, 27);
            this.ck_nguoiNhanHang.Name = "ck_nguoiNhanHang";
            this.ck_nguoiNhanHang.Size = new System.Drawing.Size(140, 21);
            this.ck_nguoiNhanHang.TabIndex = 6;
            this.ck_nguoiNhanHang.Text = "Người nhận hàng";
            this.ck_nguoiNhanHang.UseVisualStyleBackColor = true;
            this.ck_nguoiNhanHang.CheckedChanged += new System.EventHandler(this.ck_nguoiNhanHang_CheckedChanged);
            // 
            // txt_chietKhau
            // 
            this.txt_chietKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_chietKhau.Enabled = false;
            this.txt_chietKhau.Location = new System.Drawing.Point(716, 157);
            this.txt_chietKhau.Name = "txt_chietKhau";
            this.txt_chietKhau.Size = new System.Drawing.Size(123, 25);
            this.txt_chietKhau.TabIndex = 25;
            this.txt_chietKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_chietKhau_KeyPress);
            // 
            // ck_ngayXuatDen
            // 
            this.ck_ngayXuatDen.AutoSize = true;
            this.ck_ngayXuatDen.Checked = true;
            this.ck_ngayXuatDen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_ngayXuatDen.Location = new System.Drawing.Point(571, 27);
            this.ck_ngayXuatDen.Name = "ck_ngayXuatDen";
            this.ck_ngayXuatDen.Size = new System.Drawing.Size(119, 21);
            this.ck_ngayXuatDen.TabIndex = 4;
            this.ck_ngayXuatDen.Text = "Ngày xuất đến";
            this.ck_ngayXuatDen.UseVisualStyleBackColor = true;
            this.ck_ngayXuatDen.CheckedChanged += new System.EventHandler(this.ck_ngayXuatDen_CheckedChanged);
            // 
            // txt_donGia
            // 
            this.txt_donGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_donGia.Enabled = false;
            this.txt_donGia.Location = new System.Drawing.Point(442, 157);
            this.txt_donGia.Name = "txt_donGia";
            this.txt_donGia.Size = new System.Drawing.Size(123, 25);
            this.txt_donGia.TabIndex = 23;
            this.txt_donGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_donGia_KeyPress);
            // 
            // dtp_ngayXuatTu
            // 
            this.dtp_ngayXuatTu.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngayXuatTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayXuatTu.Location = new System.Drawing.Point(442, 23);
            this.dtp_ngayXuatTu.Name = "dtp_ngayXuatTu";
            this.dtp_ngayXuatTu.Size = new System.Drawing.Size(123, 25);
            this.dtp_ngayXuatTu.TabIndex = 3;
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_soLuong.Enabled = false;
            this.txt_soLuong.Location = new System.Drawing.Point(149, 157);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(157, 25);
            this.txt_soLuong.TabIndex = 21;
            this.txt_soLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soLuong_KeyPress);
            // 
            // ck_timKiem
            // 
            this.ck_timKiem.AutoSize = true;
            this.ck_timKiem.Checked = true;
            this.ck_timKiem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_timKiem.Location = new System.Drawing.Point(18, 20);
            this.ck_timKiem.Name = "ck_timKiem";
            this.ck_timKiem.Size = new System.Drawing.Size(87, 21);
            this.ck_timKiem.TabIndex = 0;
            this.ck_timKiem.Text = "Tìm kiếm";
            this.ck_timKiem.UseVisualStyleBackColor = true;
            this.ck_timKiem.CheckedChanged += new System.EventHandler(this.ck_timKiem_CheckedChanged);
            // 
            // txt_noiNhan
            // 
            this.txt_noiNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_noiNhan.Enabled = false;
            this.txt_noiNhan.Location = new System.Drawing.Point(149, 58);
            this.txt_noiNhan.Name = "txt_noiNhan";
            this.txt_noiNhan.Size = new System.Drawing.Size(157, 25);
            this.txt_noiNhan.TabIndex = 9;
            // 
            // dgv_phieuXuat
            // 
            this.dgv_phieuXuat.AllowUserToAddRows = false;
            this.dgv_phieuXuat.AllowUserToDeleteRows = false;
            this.dgv_phieuXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_phieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuXuat,
            this.NgayXuat,
            this.NguoiNhanHang,
            this.NoiNhan,
            this.TenKho,
            this.ThuKho,
            this.GhiChu});
            this.dgv_phieuXuat.Location = new System.Drawing.Point(203, 303);
            this.dgv_phieuXuat.MultiSelect = false;
            this.dgv_phieuXuat.Name = "dgv_phieuXuat";
            this.dgv_phieuXuat.ReadOnly = true;
            this.dgv_phieuXuat.RowHeadersWidth = 51;
            this.dgv_phieuXuat.RowTemplate.Height = 24;
            this.dgv_phieuXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_phieuXuat.Size = new System.Drawing.Size(730, 346);
            this.dgv_phieuXuat.TabIndex = 7;
            this.dgv_phieuXuat.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phieuXuat_RowEnter);
            // 
            // MaPhieuXuat
            // 
            this.MaPhieuXuat.DataPropertyName = "MaPhieuXuat";
            this.MaPhieuXuat.HeaderText = "Mã phiếu xuất";
            this.MaPhieuXuat.MinimumWidth = 6;
            this.MaPhieuXuat.Name = "MaPhieuXuat";
            this.MaPhieuXuat.ReadOnly = true;
            this.MaPhieuXuat.Width = 125;
            // 
            // NgayXuat
            // 
            this.NgayXuat.DataPropertyName = "NgayXuat";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.NgayXuat.DefaultCellStyle = dataGridViewCellStyle1;
            this.NgayXuat.HeaderText = "Ngày xuất";
            this.NgayXuat.MinimumWidth = 6;
            this.NgayXuat.Name = "NgayXuat";
            this.NgayXuat.ReadOnly = true;
            this.NgayXuat.Width = 125;
            // 
            // NguoiNhanHang
            // 
            this.NguoiNhanHang.DataPropertyName = "NguoiNhanHang";
            this.NguoiNhanHang.HeaderText = "Người nhận hàng";
            this.NguoiNhanHang.MinimumWidth = 6;
            this.NguoiNhanHang.Name = "NguoiNhanHang";
            this.NguoiNhanHang.ReadOnly = true;
            this.NguoiNhanHang.Width = 175;
            // 
            // NoiNhan
            // 
            this.NoiNhan.DataPropertyName = "NoiNhan";
            this.NoiNhan.HeaderText = "Nơi nhận";
            this.NoiNhan.MinimumWidth = 6;
            this.NoiNhan.Name = "NoiNhan";
            this.NoiNhan.ReadOnly = true;
            this.NoiNhan.Width = 200;
            // 
            // TenKho
            // 
            this.TenKho.DataPropertyName = "TenKho";
            this.TenKho.HeaderText = "Kho";
            this.TenKho.MinimumWidth = 6;
            this.TenKho.Name = "TenKho";
            this.TenKho.ReadOnly = true;
            this.TenKho.Width = 175;
            // 
            // ThuKho
            // 
            this.ThuKho.DataPropertyName = "ThuKho";
            this.ThuKho.HeaderText = "Thủ Kho";
            this.ThuKho.MinimumWidth = 6;
            this.ThuKho.Name = "ThuKho";
            this.ThuKho.ReadOnly = true;
            this.ThuKho.Width = 175;
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.MinimumWidth = 200;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // but_xoa
            // 
            this.but_xoa.Image = ((System.Drawing.Image)(resources.GetObject("but_xoa.Image")));
            this.but_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_xoa.Location = new System.Drawing.Point(224, 258);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(100, 40);
            this.but_xoa.TabIndex = 4;
            this.but_xoa.Text = "Xoá";
            this.but_xoa.UseVisualStyleBackColor = true;
            this.but_xoa.Click += new System.EventHandler(this.but_xoa_Click);
            // 
            // but_sua
            // 
            this.but_sua.Image = ((System.Drawing.Image)(resources.GetObject("but_sua.Image")));
            this.but_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_sua.Location = new System.Drawing.Point(118, 258);
            this.but_sua.Name = "but_sua";
            this.but_sua.Size = new System.Drawing.Size(100, 40);
            this.but_sua.TabIndex = 3;
            this.but_sua.Text = "Sửa";
            this.but_sua.UseVisualStyleBackColor = true;
            this.but_sua.Click += new System.EventHandler(this.but_sua_Click);
            // 
            // but_them
            // 
            this.but_them.Image = ((System.Drawing.Image)(resources.GetObject("but_them.Image")));
            this.but_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_them.Location = new System.Drawing.Point(12, 258);
            this.but_them.Name = "but_them";
            this.but_them.Size = new System.Drawing.Size(100, 40);
            this.but_them.TabIndex = 2;
            this.but_them.Text = "Thêm";
            this.but_them.UseVisualStyleBackColor = true;
            this.but_them.Click += new System.EventHandler(this.but_them_Click);
            // 
            // ck_ngayXuatTu
            // 
            this.ck_ngayXuatTu.AutoSize = true;
            this.ck_ngayXuatTu.Checked = true;
            this.ck_ngayXuatTu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_ngayXuatTu.Location = new System.Drawing.Point(312, 27);
            this.ck_ngayXuatTu.Name = "ck_ngayXuatTu";
            this.ck_ngayXuatTu.Size = new System.Drawing.Size(109, 21);
            this.ck_ngayXuatTu.TabIndex = 2;
            this.ck_ngayXuatTu.Text = "Ngày xuất từ";
            this.ck_ngayXuatTu.UseVisualStyleBackColor = true;
            this.ck_ngayXuatTu.CheckedChanged += new System.EventHandler(this.ck_ngayXuatTu_CheckedChanged);
            // 
            // txt_nguoiNhanHang
            // 
            this.txt_nguoiNhanHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nguoiNhanHang.Enabled = false;
            this.txt_nguoiNhanHang.Location = new System.Drawing.Point(995, 25);
            this.txt_nguoiNhanHang.Name = "txt_nguoiNhanHang";
            this.txt_nguoiNhanHang.Size = new System.Drawing.Size(157, 25);
            this.txt_nguoiNhanHang.TabIndex = 7;
            // 
            // txt_maPhieuXuat
            // 
            this.txt_maPhieuXuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_maPhieuXuat.Enabled = false;
            this.txt_maPhieuXuat.Location = new System.Drawing.Point(149, 25);
            this.txt_maPhieuXuat.Name = "txt_maPhieuXuat";
            this.txt_maPhieuXuat.Size = new System.Drawing.Size(157, 25);
            this.txt_maPhieuXuat.TabIndex = 1;
            // 
            // ck_maPhieuXuat
            // 
            this.ck_maPhieuXuat.AutoSize = true;
            this.ck_maPhieuXuat.Location = new System.Drawing.Point(6, 27);
            this.ck_maPhieuXuat.Name = "ck_maPhieuXuat";
            this.ck_maPhieuXuat.Size = new System.Drawing.Size(116, 21);
            this.ck_maPhieuXuat.TabIndex = 0;
            this.ck_maPhieuXuat.Text = "Mã phiếu xuất";
            this.ck_maPhieuXuat.UseVisualStyleBackColor = true;
            this.ck_maPhieuXuat.CheckedChanged += new System.EventHandler(this.ck_maPhieuXuat_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ck_ghiChu);
            this.groupBox1.Controls.Add(this.cbb_donViTinh);
            this.groupBox1.Controls.Add(this.cbb_hangHoa);
            this.groupBox1.Controls.Add(this.cbb_kho);
            this.groupBox1.Controls.Add(this.ck_donViTinh);
            this.groupBox1.Controls.Add(this.dtp_ngayXuatDen);
            this.groupBox1.Controls.Add(this.ck_hangHoa);
            this.groupBox1.Controls.Add(this.txt_ghiChu);
            this.groupBox1.Controls.Add(this.ck_maKho);
            this.groupBox1.Controls.Add(this.ck_chietKhau);
            this.groupBox1.Controls.Add(this.ck_donGia);
            this.groupBox1.Controls.Add(this.ck_soLuong);
            this.groupBox1.Controls.Add(this.ck_noiNhan);
            this.groupBox1.Controls.Add(this.ck_thuKho);
            this.groupBox1.Controls.Add(this.txt_thuKho);
            this.groupBox1.Controls.Add(this.ck_nguoiNhanHang);
            this.groupBox1.Controls.Add(this.txt_chietKhau);
            this.groupBox1.Controls.Add(this.ck_ngayXuatDen);
            this.groupBox1.Controls.Add(this.txt_donGia);
            this.groupBox1.Controls.Add(this.dtp_ngayXuatTu);
            this.groupBox1.Controls.Add(this.txt_soLuong);
            this.groupBox1.Controls.Add(this.txt_noiNhan);
            this.groupBox1.Controls.Add(this.ck_ngayXuatTu);
            this.groupBox1.Controls.Add(this.txt_nguoiNhanHang);
            this.groupBox1.Controls.Add(this.txt_maPhieuXuat);
            this.groupBox1.Controls.Add(this.ck_maPhieuXuat);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ PHIẾU XUẤT";
            // 
            // but_dong
            // 
            this.but_dong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_dong.Image = ((System.Drawing.Image)(resources.GetObject("but_dong.Image")));
            this.but_dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_dong.Location = new System.Drawing.Point(1064, 258);
            this.but_dong.Name = "but_dong";
            this.but_dong.Size = new System.Drawing.Size(100, 40);
            this.but_dong.TabIndex = 9;
            this.but_dong.Text = "Đóng";
            this.but_dong.UseVisualStyleBackColor = true;
            this.but_dong.Click += new System.EventHandler(this.but_dong_Click);
            // 
            // FrmQuanLyPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.but_dong);
            this.Controls.Add(this.but_xoa);
            this.Controls.Add(this.but_timKiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.but_them);
            this.Controls.Add(this.but_sua);
            this.Controls.Add(this.tv_chiTietPhieuXuat);
            this.Controls.Add(this.ck_timKiem);
            this.Controls.Add(this.dgv_phieuXuat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQuanLyPhieuXuat";
            this.Text = "QUẢN LÝ PHIẾU XUẤT";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuXuat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ck_hienThiKho;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ck_hienThiNoiNhan;
        private System.Windows.Forms.CheckBox ck_hienThiNguoiNhanHang;
        private System.Windows.Forms.CheckBox ck_hienThiThuKho;
        private System.Windows.Forms.CheckBox ck_hienThiGhiChu;
        private System.Windows.Forms.Button but_timKiem;
        private System.Windows.Forms.CheckBox ck_ghiChu;
        private System.Windows.Forms.ComboBox cbb_donViTinh;
        private System.Windows.Forms.ComboBox cbb_hangHoa;
        private System.Windows.Forms.ComboBox cbb_kho;
        private System.Windows.Forms.CheckBox ck_donViTinh;
        private System.Windows.Forms.DateTimePicker dtp_ngayXuatDen;
        private System.Windows.Forms.CheckBox ck_hangHoa;
        private System.Windows.Forms.TextBox txt_ghiChu;
        private System.Windows.Forms.TreeView tv_chiTietPhieuXuat;
        private System.Windows.Forms.CheckBox ck_maKho;
        private System.Windows.Forms.CheckBox ck_chietKhau;
        private System.Windows.Forms.CheckBox ck_donGia;
        private System.Windows.Forms.CheckBox ck_soLuong;
        private System.Windows.Forms.CheckBox ck_thuKho;
        private System.Windows.Forms.CheckBox ck_noiNhan;
        private System.Windows.Forms.TextBox txt_thuKho;
        private System.Windows.Forms.CheckBox ck_nguoiNhanHang;
        private System.Windows.Forms.TextBox txt_chietKhau;
        private System.Windows.Forms.CheckBox ck_ngayXuatDen;
        private System.Windows.Forms.TextBox txt_donGia;
        private System.Windows.Forms.DateTimePicker dtp_ngayXuatTu;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.CheckBox ck_timKiem;
        private System.Windows.Forms.TextBox txt_noiNhan;
        private System.Windows.Forms.DataGridView dgv_phieuXuat;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.Button but_sua;
        private System.Windows.Forms.Button but_them;
        private System.Windows.Forms.CheckBox ck_ngayXuatTu;
        private System.Windows.Forms.TextBox txt_nguoiNhanHang;
        private System.Windows.Forms.TextBox txt_maPhieuXuat;
        private System.Windows.Forms.CheckBox ck_maPhieuXuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiNhanHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThuKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Button but_dong;
    }
}