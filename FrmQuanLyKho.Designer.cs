
namespace QuanLyKho_Tuan1
{
    partial class FrmQuanLyKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyKho));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ck_donViTinh = new System.Windows.Forms.CheckBox();
            this.cbb_donViTinh = new System.Windows.Forms.ComboBox();
            this.cbb_hangHoa = new System.Windows.Forms.ComboBox();
            this.ck_hangHoa = new System.Windows.Forms.CheckBox();
            this.ck_soLuong = new System.Windows.Forms.CheckBox();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.cbb_kho = new System.Windows.Forms.ComboBox();
            this.but_timKiem = new System.Windows.Forms.Button();
            this.ck_thuKho = new System.Windows.Forms.CheckBox();
            this.ck_diaChi = new System.Windows.Forms.CheckBox();
            this.ck_maKho = new System.Windows.Forms.CheckBox();
            this.txt_thuKho = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.but_nhapKho = new System.Windows.Forms.Button();
            this.but_xoa = new System.Windows.Forms.Button();
            this.but_sua = new System.Windows.Forms.Button();
            this.but_them = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tv_chiTietKho = new System.Windows.Forms.TreeView();
            this.dgv_quanLyKho = new System.Windows.Forms.DataGridView();
            this.MaKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThuKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ck_timKiem = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.but_dong = new System.Windows.Forms.Button();
            this.but_xuatKho = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanLyKho)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THÔNG TIN KHO";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ck_donViTinh);
            this.groupBox1.Controls.Add(this.cbb_donViTinh);
            this.groupBox1.Controls.Add(this.cbb_hangHoa);
            this.groupBox1.Controls.Add(this.ck_hangHoa);
            this.groupBox1.Controls.Add(this.ck_soLuong);
            this.groupBox1.Controls.Add(this.txt_soLuong);
            this.groupBox1.Controls.Add(this.cbb_kho);
            this.groupBox1.Controls.Add(this.but_timKiem);
            this.groupBox1.Controls.Add(this.ck_thuKho);
            this.groupBox1.Controls.Add(this.ck_diaChi);
            this.groupBox1.Controls.Add(this.ck_maKho);
            this.groupBox1.Controls.Add(this.txt_thuKho);
            this.groupBox1.Controls.Add(this.txt_diaChi);
            this.groupBox1.Location = new System.Drawing.Point(10, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm kho";
            // 
            // ck_donViTinh
            // 
            this.ck_donViTinh.AutoSize = true;
            this.ck_donViTinh.Location = new System.Drawing.Point(259, 56);
            this.ck_donViTinh.Name = "ck_donViTinh";
            this.ck_donViTinh.Size = new System.Drawing.Size(104, 27);
            this.ck_donViTinh.TabIndex = 8;
            this.ck_donViTinh.Text = "Đơn vị tính";
            this.ck_donViTinh.UseVisualStyleBackColor = true;
            this.ck_donViTinh.CheckedChanged += new System.EventHandler(this.ck_donViTinh_CheckedChanged);
            // 
            // cbb_donViTinh
            // 
            this.cbb_donViTinh.DisplayMember = "TenDonViTinh";
            this.cbb_donViTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_donViTinh.Enabled = false;
            this.cbb_donViTinh.FormattingEnabled = true;
            this.cbb_donViTinh.Location = new System.Drawing.Point(352, 54);
            this.cbb_donViTinh.Name = "cbb_donViTinh";
            this.cbb_donViTinh.Size = new System.Drawing.Size(108, 31);
            this.cbb_donViTinh.TabIndex = 9;
            this.cbb_donViTinh.ValueMember = "MaDonViTinh";
            // 
            // cbb_hangHoa
            // 
            this.cbb_hangHoa.DisplayMember = "TenHangHoa";
            this.cbb_hangHoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_hangHoa.Enabled = false;
            this.cbb_hangHoa.FormattingEnabled = true;
            this.cbb_hangHoa.Location = new System.Drawing.Point(104, 54);
            this.cbb_hangHoa.Name = "cbb_hangHoa";
            this.cbb_hangHoa.Size = new System.Drawing.Size(139, 31);
            this.cbb_hangHoa.TabIndex = 7;
            this.cbb_hangHoa.ValueMember = "MaHangHoa";
            this.cbb_hangHoa.SelectedIndexChanged += new System.EventHandler(this.cbb_hangHoa_SelectedIndexChanged);
            // 
            // ck_hangHoa
            // 
            this.ck_hangHoa.AutoSize = true;
            this.ck_hangHoa.Location = new System.Drawing.Point(8, 56);
            this.ck_hangHoa.Name = "ck_hangHoa";
            this.ck_hangHoa.Size = new System.Drawing.Size(101, 27);
            this.ck_hangHoa.TabIndex = 6;
            this.ck_hangHoa.Text = "Hàng hoá";
            this.ck_hangHoa.UseVisualStyleBackColor = true;
            this.ck_hangHoa.CheckedChanged += new System.EventHandler(this.ck_hangHoa_CheckedChanged);
            // 
            // ck_soLuong
            // 
            this.ck_soLuong.AutoSize = true;
            this.ck_soLuong.Location = new System.Drawing.Point(466, 56);
            this.ck_soLuong.Name = "ck_soLuong";
            this.ck_soLuong.Size = new System.Drawing.Size(94, 27);
            this.ck_soLuong.TabIndex = 10;
            this.ck_soLuong.Text = "Số lượng";
            this.ck_soLuong.UseVisualStyleBackColor = true;
            this.ck_soLuong.CheckedChanged += new System.EventHandler(this.ck_soLuong_CheckedChanged);
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_soLuong.Enabled = false;
            this.txt_soLuong.Location = new System.Drawing.Point(554, 55);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(125, 29);
            this.txt_soLuong.TabIndex = 11;
            // 
            // cbb_kho
            // 
            this.cbb_kho.DisplayMember = "TenKHo";
            this.cbb_kho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_kho.Enabled = false;
            this.cbb_kho.FormattingEnabled = true;
            this.cbb_kho.Location = new System.Drawing.Point(104, 20);
            this.cbb_kho.Name = "cbb_kho";
            this.cbb_kho.Size = new System.Drawing.Size(139, 31);
            this.cbb_kho.TabIndex = 1;
            this.cbb_kho.ValueMember = "MaKho";
            // 
            // but_timKiem
            // 
            this.but_timKiem.Enabled = false;
            this.but_timKiem.Image = ((System.Drawing.Image)(resources.GetObject("but_timKiem.Image")));
            this.but_timKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_timKiem.Location = new System.Drawing.Point(766, 51);
            this.but_timKiem.Name = "but_timKiem";
            this.but_timKiem.Size = new System.Drawing.Size(147, 32);
            this.but_timKiem.TabIndex = 12;
            this.but_timKiem.Text = "Tìm kiếm";
            this.but_timKiem.UseVisualStyleBackColor = true;
            this.but_timKiem.Click += new System.EventHandler(this.but_timKiem_Click);
            // 
            // ck_thuKho
            // 
            this.ck_thuKho.AutoSize = true;
            this.ck_thuKho.Location = new System.Drawing.Point(685, 22);
            this.ck_thuKho.Name = "ck_thuKho";
            this.ck_thuKho.Size = new System.Drawing.Size(89, 27);
            this.ck_thuKho.TabIndex = 4;
            this.ck_thuKho.Text = "Thủ kho";
            this.ck_thuKho.UseVisualStyleBackColor = true;
            this.ck_thuKho.CheckedChanged += new System.EventHandler(this.ck_thuKho_CheckedChanged);
            // 
            // ck_diaChi
            // 
            this.ck_diaChi.AutoSize = true;
            this.ck_diaChi.Location = new System.Drawing.Point(259, 22);
            this.ck_diaChi.Name = "ck_diaChi";
            this.ck_diaChi.Size = new System.Drawing.Size(81, 27);
            this.ck_diaChi.TabIndex = 2;
            this.ck_diaChi.Text = "Địa chỉ";
            this.ck_diaChi.UseVisualStyleBackColor = true;
            this.ck_diaChi.CheckedChanged += new System.EventHandler(this.ck_diaChi_CheckedChanged);
            // 
            // ck_maKho
            // 
            this.ck_maKho.AutoSize = true;
            this.ck_maKho.Location = new System.Drawing.Point(8, 22);
            this.ck_maKho.Name = "ck_maKho";
            this.ck_maKho.Size = new System.Drawing.Size(60, 27);
            this.ck_maKho.TabIndex = 0;
            this.ck_maKho.Text = "Kho";
            this.ck_maKho.UseVisualStyleBackColor = true;
            this.ck_maKho.CheckedChanged += new System.EventHandler(this.ck_maKho_CheckedChanged);
            // 
            // txt_thuKho
            // 
            this.txt_thuKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_thuKho.Enabled = false;
            this.txt_thuKho.Location = new System.Drawing.Point(766, 20);
            this.txt_thuKho.Name = "txt_thuKho";
            this.txt_thuKho.Size = new System.Drawing.Size(147, 29);
            this.txt_thuKho.TabIndex = 5;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_diaChi.Enabled = false;
            this.txt_diaChi.Location = new System.Drawing.Point(352, 20);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(327, 29);
            this.txt_diaChi.TabIndex = 3;
            // 
            // but_nhapKho
            // 
            this.but_nhapKho.Image = ((System.Drawing.Image)(resources.GetObject("but_nhapKho.Image")));
            this.but_nhapKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_nhapKho.Location = new System.Drawing.Point(336, 144);
            this.but_nhapKho.Name = "but_nhapKho";
            this.but_nhapKho.Size = new System.Drawing.Size(100, 40);
            this.but_nhapKho.TabIndex = 5;
            this.but_nhapKho.Text = "Nhập kho";
            this.but_nhapKho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_nhapKho.UseVisualStyleBackColor = true;
            this.but_nhapKho.Click += new System.EventHandler(this.but_NhapKho_Click);
            // 
            // but_xoa
            // 
            this.but_xoa.Image = ((System.Drawing.Image)(resources.GetObject("but_xoa.Image")));
            this.but_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_xoa.Location = new System.Drawing.Point(230, 144);
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
            this.but_sua.Location = new System.Drawing.Point(124, 144);
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
            this.but_them.Location = new System.Drawing.Point(18, 144);
            this.but_them.Name = "but_them";
            this.but_them.Size = new System.Drawing.Size(100, 40);
            this.but_them.TabIndex = 2;
            this.but_them.Text = "Thêm kho";
            this.but_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_them.UseVisualStyleBackColor = true;
            this.but_them.Click += new System.EventHandler(this.but_them_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tv_chiTietKho);
            this.groupBox3.Controls.Add(this.dgv_quanLyKho);
            this.groupBox3.Location = new System.Drawing.Point(12, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(918, 338);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin kho";
            // 
            // tv_chiTietKho
            // 
            this.tv_chiTietKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv_chiTietKho.Location = new System.Drawing.Point(683, 20);
            this.tv_chiTietKho.Name = "tv_chiTietKho";
            this.tv_chiTietKho.Size = new System.Drawing.Size(228, 312);
            this.tv_chiTietKho.TabIndex = 1;
            // 
            // dgv_quanLyKho
            // 
            this.dgv_quanLyKho.AllowUserToAddRows = false;
            this.dgv_quanLyKho.AllowUserToDeleteRows = false;
            this.dgv_quanLyKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_quanLyKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_quanLyKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKho,
            this.TenKho,
            this.DiaChi,
            this.ThuKho});
            this.dgv_quanLyKho.Location = new System.Drawing.Point(3, 20);
            this.dgv_quanLyKho.MultiSelect = false;
            this.dgv_quanLyKho.Name = "dgv_quanLyKho";
            this.dgv_quanLyKho.ReadOnly = true;
            this.dgv_quanLyKho.RowHeadersWidth = 51;
            this.dgv_quanLyKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_quanLyKho.Size = new System.Drawing.Size(674, 312);
            this.dgv_quanLyKho.TabIndex = 0;
            this.dgv_quanLyKho.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_quanLyKho_RowEnter);
            // 
            // MaKho
            // 
            this.MaKho.DataPropertyName = "MaKho";
            this.MaKho.Frozen = true;
            this.MaKho.HeaderText = "Mã Kho";
            this.MaKho.MinimumWidth = 6;
            this.MaKho.Name = "MaKho";
            this.MaKho.ReadOnly = true;
            this.MaKho.Width = 125;
            // 
            // TenKho
            // 
            this.TenKho.DataPropertyName = "TenKho";
            this.TenKho.Frozen = true;
            this.TenKho.HeaderText = "Tên Kho";
            this.TenKho.MinimumWidth = 6;
            this.TenKho.Name = "TenKho";
            this.TenKho.ReadOnly = true;
            this.TenKho.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 200;
            // 
            // ThuKho
            // 
            this.ThuKho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThuKho.DataPropertyName = "ThuKho";
            this.ThuKho.HeaderText = "Thủ Kho";
            this.ThuKho.MinimumWidth = 6;
            this.ThuKho.Name = "ThuKho";
            this.ThuKho.ReadOnly = true;
            // 
            // ck_timKiem
            // 
            this.ck_timKiem.AutoSize = true;
            this.ck_timKiem.Location = new System.Drawing.Point(18, 20);
            this.ck_timKiem.Name = "ck_timKiem";
            this.ck_timKiem.Size = new System.Drawing.Size(94, 27);
            this.ck_timKiem.TabIndex = 0;
            this.ck_timKiem.Text = "Tìm kiếm";
            this.ck_timKiem.UseVisualStyleBackColor = true;
            this.ck_timKiem.CheckedChanged += new System.EventHandler(this.ck_timKiem_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(942, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(84, 20);
            this.status.Text = "Thông báo:";
            // 
            // but_dong
            // 
            this.but_dong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_dong.Image = ((System.Drawing.Image)(resources.GetObject("but_dong.Image")));
            this.but_dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_dong.Location = new System.Drawing.Point(823, 144);
            this.but_dong.Name = "but_dong";
            this.but_dong.Size = new System.Drawing.Size(100, 40);
            this.but_dong.TabIndex = 6;
            this.but_dong.Text = "Đóng";
            this.but_dong.UseVisualStyleBackColor = true;
            this.but_dong.Click += new System.EventHandler(this.but_dong_Click);
            // 
            // but_xuatKho
            // 
            this.but_xuatKho.Image = ((System.Drawing.Image)(resources.GetObject("but_xuatKho.Image")));
            this.but_xuatKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_xuatKho.Location = new System.Drawing.Point(442, 144);
            this.but_xuatKho.Name = "but_xuatKho";
            this.but_xuatKho.Size = new System.Drawing.Size(100, 40);
            this.but_xuatKho.TabIndex = 8;
            this.but_xuatKho.Text = "Xuất kho";
            this.but_xuatKho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_xuatKho.UseVisualStyleBackColor = true;
            this.but_xuatKho.Click += new System.EventHandler(this.but_xuatKho_Click);
            // 
            // FrmQuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 553);
            this.Controls.Add(this.but_xuatKho);
            this.Controls.Add(this.but_dong);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.but_xoa);
            this.Controls.Add(this.but_nhapKho);
            this.Controls.Add(this.but_sua);
            this.Controls.Add(this.ck_timKiem);
            this.Controls.Add(this.but_them);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmQuanLyKho";
            this.Text = "QUẢN LÝ KHO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanLyKho)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ck_maKho;
        private System.Windows.Forms.CheckBox ck_thuKho;
        private System.Windows.Forms.CheckBox ck_diaChi;
        private System.Windows.Forms.TextBox txt_thuKho;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.Button but_timKiem;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.Button but_sua;
        private System.Windows.Forms.Button but_them;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_quanLyKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThuKho;
        private System.Windows.Forms.TreeView tv_chiTietKho;
        private System.Windows.Forms.CheckBox ck_timKiem;
        private System.Windows.Forms.ComboBox cbb_kho;
        private System.Windows.Forms.ComboBox cbb_donViTinh;
        private System.Windows.Forms.ComboBox cbb_hangHoa;
        private System.Windows.Forms.CheckBox ck_hangHoa;
        private System.Windows.Forms.CheckBox ck_soLuong;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.CheckBox ck_donViTinh;
        private System.Windows.Forms.Button but_nhapKho;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.Button but_dong;
        private System.Windows.Forms.Button but_xuatKho;
    }
}