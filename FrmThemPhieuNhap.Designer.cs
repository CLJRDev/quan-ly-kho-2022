﻿
namespace QuanLyKho_Tuan1
{
    partial class FrmThemPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemPhieuNhap));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_maKho = new System.Windows.Forms.ComboBox();
            this.dtp_ngayNhap = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nguonNhap = new System.Windows.Forms.TextBox();
            this.txt_ghiChu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nguoiGiaoHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.but_donViTinh = new System.Windows.Forms.Button();
            this.but_hangHoa = new System.Windows.Forms.Button();
            this.but_loaiHang = new System.Windows.Forms.Button();
            this.cbb_loaiHang = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.but_xoa = new System.Windows.Forms.Button();
            this.but_them = new System.Windows.Forms.Button();
            this.dgv_chiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.TenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChietKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbb_maDonViTinh = new System.Windows.Forms.ComboBox();
            this.cbb_maHangHoa = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_chietKhau = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_donGia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.but_luu = new System.Windows.Forms.Button();
            this.erroMes = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroMes)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbb_maKho);
            this.groupBox1.Controls.Add(this.dtp_ngayNhap);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_nguonNhap);
            this.groupBox1.Controls.Add(this.txt_ghiChu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_nguoiGiaoHang);
            this.groupBox1.Location = new System.Drawing.Point(7, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // cbb_maKho
            // 
            this.cbb_maKho.DisplayMember = "TenKho";
            this.cbb_maKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_maKho.FormattingEnabled = true;
            this.cbb_maKho.Location = new System.Drawing.Point(396, 24);
            this.cbb_maKho.Name = "cbb_maKho";
            this.cbb_maKho.Size = new System.Drawing.Size(133, 28);
            this.cbb_maKho.TabIndex = 1;
            this.cbb_maKho.ValueMember = "MaKho";
            this.cbb_maKho.SelectedIndexChanged += new System.EventHandler(this.cbb_maKho_SelectedIndexChanged);
            // 
            // dtp_ngayNhap
            // 
            this.dtp_ngayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayNhap.Location = new System.Drawing.Point(115, 28);
            this.dtp_ngayNhap.Name = "dtp_ngayNhap";
            this.dtp_ngayNhap.Size = new System.Drawing.Size(133, 25);
            this.dtp_ngayNhap.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ghi chú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nguồn nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Người giao hàng";
            // 
            // txt_nguonNhap
            // 
            this.txt_nguonNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nguonNhap.Location = new System.Drawing.Point(671, 24);
            this.txt_nguonNhap.Name = "txt_nguonNhap";
            this.txt_nguonNhap.Size = new System.Drawing.Size(246, 25);
            this.txt_nguonNhap.TabIndex = 2;
            // 
            // txt_ghiChu
            // 
            this.txt_ghiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ghiChu.Location = new System.Drawing.Point(396, 62);
            this.txt_ghiChu.Name = "txt_ghiChu";
            this.txt_ghiChu.Size = new System.Drawing.Size(521, 25);
            this.txt_ghiChu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày nhập";
            // 
            // txt_nguoiGiaoHang
            // 
            this.txt_nguoiGiaoHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nguoiGiaoHang.Location = new System.Drawing.Point(115, 62);
            this.txt_nguoiGiaoHang.Name = "txt_nguoiGiaoHang";
            this.txt_nguoiGiaoHang.Size = new System.Drawing.Size(133, 25);
            this.txt_nguoiGiaoHang.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÊM PHIẾU NHẬP";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.but_donViTinh);
            this.groupBox2.Controls.Add(this.but_hangHoa);
            this.groupBox2.Controls.Add(this.but_loaiHang);
            this.groupBox2.Controls.Add(this.cbb_loaiHang);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.but_xoa);
            this.groupBox2.Controls.Add(this.but_them);
            this.groupBox2.Controls.Add(this.dgv_chiTietPhieuNhap);
            this.groupBox2.Controls.Add(this.cbb_maDonViTinh);
            this.groupBox2.Controls.Add(this.cbb_maHangHoa);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_chietKhau);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_donGia);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_soLuong);
            this.groupBox2.Location = new System.Drawing.Point(7, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(925, 346);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hàng hoá";
            // 
            // but_donViTinh
            // 
            this.but_donViTinh.Location = new System.Drawing.Point(741, 21);
            this.but_donViTinh.Name = "but_donViTinh";
            this.but_donViTinh.Size = new System.Drawing.Size(30, 28);
            this.but_donViTinh.TabIndex = 10;
            this.but_donViTinh.Text = "......";
            this.but_donViTinh.UseVisualStyleBackColor = true;
            this.but_donViTinh.Click += new System.EventHandler(this.but_donViTinh_Click);
            // 
            // but_hangHoa
            // 
            this.but_hangHoa.Location = new System.Drawing.Point(497, 21);
            this.but_hangHoa.Name = "but_hangHoa";
            this.but_hangHoa.Size = new System.Drawing.Size(33, 28);
            this.but_hangHoa.TabIndex = 10;
            this.but_hangHoa.Text = "......";
            this.but_hangHoa.UseVisualStyleBackColor = true;
            this.but_hangHoa.Click += new System.EventHandler(this.but_hangHoa_Click);
            // 
            // but_loaiHang
            // 
            this.but_loaiHang.Location = new System.Drawing.Point(215, 21);
            this.but_loaiHang.Name = "but_loaiHang";
            this.but_loaiHang.Size = new System.Drawing.Size(33, 30);
            this.but_loaiHang.TabIndex = 10;
            this.but_loaiHang.Text = "......";
            this.but_loaiHang.UseVisualStyleBackColor = true;
            this.but_loaiHang.Click += new System.EventHandler(this.but_loaiHang_Click);
            // 
            // cbb_loaiHang
            // 
            this.cbb_loaiHang.DisplayMember = "TenLoaiHang";
            this.cbb_loaiHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_loaiHang.FormattingEnabled = true;
            this.cbb_loaiHang.Location = new System.Drawing.Point(115, 22);
            this.cbb_loaiHang.Name = "cbb_loaiHang";
            this.cbb_loaiHang.Size = new System.Drawing.Size(94, 28);
            this.cbb_loaiHang.TabIndex = 0;
            this.cbb_loaiHang.ValueMember = "MaLoaiHang";
            this.cbb_loaiHang.SelectedIndexChanged += new System.EventHandler(this.cbb_loaiHang_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "Loại hàng";
            // 
            // but_xoa
            // 
            this.but_xoa.Enabled = false;
            this.but_xoa.Image = ((System.Drawing.Image)(resources.GetObject("but_xoa.Image")));
            this.but_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_xoa.Location = new System.Drawing.Point(804, 57);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(113, 32);
            this.but_xoa.TabIndex = 7;
            this.but_xoa.Text = "Xoá";
            this.but_xoa.UseVisualStyleBackColor = true;
            this.but_xoa.Click += new System.EventHandler(this.but_xoa_Click);
            // 
            // but_them
            // 
            this.but_them.Image = ((System.Drawing.Image)(resources.GetObject("but_them.Image")));
            this.but_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_them.Location = new System.Drawing.Point(804, 21);
            this.but_them.Name = "but_them";
            this.but_them.Size = new System.Drawing.Size(113, 32);
            this.but_them.TabIndex = 6;
            this.but_them.Text = "Thêm";
            this.but_them.UseVisualStyleBackColor = true;
            this.but_them.Click += new System.EventHandler(this.but_them_Click);
            // 
            // dgv_chiTietPhieuNhap
            // 
            this.dgv_chiTietPhieuNhap.AllowUserToAddRows = false;
            this.dgv_chiTietPhieuNhap.AllowUserToDeleteRows = false;
            this.dgv_chiTietPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_chiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHangHoa,
            this.TenDonViTinh,
            this.SoLuong,
            this.DonGia,
            this.ChietKhau});
            this.dgv_chiTietPhieuNhap.Location = new System.Drawing.Point(10, 95);
            this.dgv_chiTietPhieuNhap.Name = "dgv_chiTietPhieuNhap";
            this.dgv_chiTietPhieuNhap.ReadOnly = true;
            this.dgv_chiTietPhieuNhap.RowHeadersWidth = 51;
            this.dgv_chiTietPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_chiTietPhieuNhap.Size = new System.Drawing.Size(909, 245);
            this.dgv_chiTietPhieuNhap.TabIndex = 8;
            // 
            // TenHangHoa
            // 
            this.TenHangHoa.DataPropertyName = "TenHangHoa";
            this.TenHangHoa.HeaderText = "Hàng hoá";
            this.TenHangHoa.MinimumWidth = 6;
            this.TenHangHoa.Name = "TenHangHoa";
            this.TenHangHoa.ReadOnly = true;
            this.TenHangHoa.Width = 200;
            // 
            // TenDonViTinh
            // 
            this.TenDonViTinh.DataPropertyName = "TenDonViTinh";
            this.TenDonViTinh.HeaderText = "Đơn vị tính";
            this.TenDonViTinh.MinimumWidth = 6;
            this.TenDonViTinh.Name = "TenDonViTinh";
            this.TenDonViTinh.ReadOnly = true;
            this.TenDonViTinh.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 150;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 150;
            // 
            // ChietKhau
            // 
            this.ChietKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChietKhau.DataPropertyName = "ChietKhau";
            this.ChietKhau.HeaderText = "Chiết khấu";
            this.ChietKhau.MinimumWidth = 6;
            this.ChietKhau.Name = "ChietKhau";
            this.ChietKhau.ReadOnly = true;
            // 
            // cbb_maDonViTinh
            // 
            this.cbb_maDonViTinh.DisplayMember = "TenDonViTinh";
            this.cbb_maDonViTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_maDonViTinh.FormattingEnabled = true;
            this.cbb_maDonViTinh.Location = new System.Drawing.Point(671, 21);
            this.cbb_maDonViTinh.Name = "cbb_maDonViTinh";
            this.cbb_maDonViTinh.Size = new System.Drawing.Size(64, 28);
            this.cbb_maDonViTinh.TabIndex = 2;
            this.cbb_maDonViTinh.ValueMember = "MaDonViTinh";
            // 
            // cbb_maHangHoa
            // 
            this.cbb_maHangHoa.DisplayMember = "TenhangHoa";
            this.cbb_maHangHoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_maHangHoa.FormattingEnabled = true;
            this.cbb_maHangHoa.Location = new System.Drawing.Point(396, 21);
            this.cbb_maHangHoa.Name = "cbb_maHangHoa";
            this.cbb_maHangHoa.Size = new System.Drawing.Size(95, 28);
            this.cbb_maHangHoa.TabIndex = 1;
            this.cbb_maHangHoa.ValueMember = "MaHangHoa";
            this.cbb_maHangHoa.SelectedIndexChanged += new System.EventHandler(this.cbb_maHangHoa_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Hàng hoá";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(303, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Chiết khấu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Đơn giá";
            // 
            // txt_chietKhau
            // 
            this.txt_chietKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_chietKhau.Location = new System.Drawing.Point(396, 58);
            this.txt_chietKhau.Name = "txt_chietKhau";
            this.txt_chietKhau.Size = new System.Drawing.Size(133, 25);
            this.txt_chietKhau.TabIndex = 4;
            this.txt_chietKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_chietKhau_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(585, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Số lượng";
            // 
            // txt_donGia
            // 
            this.txt_donGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_donGia.Location = new System.Drawing.Point(115, 60);
            this.txt_donGia.Name = "txt_donGia";
            this.txt_donGia.Size = new System.Drawing.Size(133, 25);
            this.txt_donGia.TabIndex = 3;
            this.txt_donGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_donGia_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(585, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Đơn vị tính";
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_soLuong.Location = new System.Drawing.Point(671, 58);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(100, 25);
            this.txt_soLuong.TabIndex = 5;
            this.txt_soLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soLuong_KeyPress);
            // 
            // but_luu
            // 
            this.but_luu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.but_luu.Image = ((System.Drawing.Image)(resources.GetObject("but_luu.Image")));
            this.but_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_luu.Location = new System.Drawing.Point(422, 501);
            this.but_luu.Name = "but_luu";
            this.but_luu.Size = new System.Drawing.Size(100, 35);
            this.but_luu.TabIndex = 2;
            this.but_luu.Text = "Lưu";
            this.but_luu.UseVisualStyleBackColor = true;
            this.but_luu.Click += new System.EventHandler(this.but_luu_Click);
            // 
            // erroMes
            // 
            this.erroMes.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(944, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(67, 17);
            this.status.Text = "Thông báo:";
            // 
            // FrmThemPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.but_luu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmThemPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN PHIẾU NHẬP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroMes)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nguoiGiaoHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_maKho;
        private System.Windows.Forms.DateTimePicker dtp_ngayNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nguonNhap;
        private System.Windows.Forms.TextBox txt_ghiChu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_maDonViTinh;
        private System.Windows.Forms.ComboBox cbb_maHangHoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_chietKhau;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_donGia;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.DataGridView dgv_chiTietPhieuNhap;
        private System.Windows.Forms.Button but_luu;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.Button but_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChietKhau;
        private System.Windows.Forms.ComboBox cbb_loaiHang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button but_hangHoa;
        private System.Windows.Forms.Button but_loaiHang;
        private System.Windows.Forms.Button but_donViTinh;
        private System.Windows.Forms.ErrorProvider erroMes;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
    }
}