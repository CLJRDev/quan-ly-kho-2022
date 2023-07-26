
namespace QuanLyKho_Tuan1
{
    partial class FrmThongKeKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKeKho));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ck_donViTinh = new System.Windows.Forms.CheckBox();
            this.cbb_donViTinh = new System.Windows.Forms.ComboBox();
            this.cbb_hangHoa = new System.Windows.Forms.ComboBox();
            this.ck_hangHoa = new System.Windows.Forms.CheckBox();
            this.cbb_kho = new System.Windows.Forms.ComboBox();
            this.ck_maKho = new System.Windows.Forms.CheckBox();
            this.ck_timKiem = new System.Windows.Forms.CheckBox();
            this.but_timKiem = new System.Windows.Forms.Button();
            this.dgv_hangHoaThongKe = new System.Windows.Forms.DataGridView();
            this.but_xuatExcel = new System.Windows.Forms.Button();
            this.but_dong = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.tv_danhSachKho = new System.Windows.Forms.TreeView();
            this.MaHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hangHoaThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ HÀNG HOÁ TRONG KHO";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ck_donViTinh);
            this.groupBox1.Controls.Add(this.cbb_donViTinh);
            this.groupBox1.Controls.Add(this.cbb_hangHoa);
            this.groupBox1.Controls.Add(this.ck_hangHoa);
            this.groupBox1.Controls.Add(this.cbb_kho);
            this.groupBox1.Controls.Add(this.ck_maKho);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // ck_donViTinh
            // 
            this.ck_donViTinh.AutoSize = true;
            this.ck_donViTinh.Location = new System.Drawing.Point(532, 24);
            this.ck_donViTinh.Name = "ck_donViTinh";
            this.ck_donViTinh.Size = new System.Drawing.Size(97, 21);
            this.ck_donViTinh.TabIndex = 17;
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
            this.cbb_donViTinh.Location = new System.Drawing.Point(635, 22);
            this.cbb_donViTinh.Name = "cbb_donViTinh";
            this.cbb_donViTinh.Size = new System.Drawing.Size(180, 25);
            this.cbb_donViTinh.TabIndex = 2;
            this.cbb_donViTinh.ValueMember = "MaDonViTinh";
            // 
            // cbb_hangHoa
            // 
            this.cbb_hangHoa.DisplayMember = "TenHangHoa";
            this.cbb_hangHoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_hangHoa.Enabled = false;
            this.cbb_hangHoa.FormattingEnabled = true;
            this.cbb_hangHoa.Location = new System.Drawing.Point(346, 22);
            this.cbb_hangHoa.Name = "cbb_hangHoa";
            this.cbb_hangHoa.Size = new System.Drawing.Size(180, 25);
            this.cbb_hangHoa.TabIndex = 1;
            this.cbb_hangHoa.ValueMember = "MaHangHoa";
            this.cbb_hangHoa.SelectedIndexChanged += new System.EventHandler(this.cbb_hangHoa_SelectedIndexChanged);
            // 
            // ck_hangHoa
            // 
            this.ck_hangHoa.AutoSize = true;
            this.ck_hangHoa.Location = new System.Drawing.Point(251, 24);
            this.ck_hangHoa.Name = "ck_hangHoa";
            this.ck_hangHoa.Size = new System.Drawing.Size(89, 21);
            this.ck_hangHoa.TabIndex = 14;
            this.ck_hangHoa.Text = "Hàng hoá";
            this.ck_hangHoa.UseVisualStyleBackColor = true;
            this.ck_hangHoa.CheckedChanged += new System.EventHandler(this.ck_hangHoa_CheckedChanged);
            // 
            // cbb_kho
            // 
            this.cbb_kho.DisplayMember = "TenKHo";
            this.cbb_kho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_kho.Enabled = false;
            this.cbb_kho.FormattingEnabled = true;
            this.cbb_kho.Location = new System.Drawing.Point(65, 22);
            this.cbb_kho.Name = "cbb_kho";
            this.cbb_kho.Size = new System.Drawing.Size(180, 25);
            this.cbb_kho.TabIndex = 0;
            this.cbb_kho.ValueMember = "MaKho";
            // 
            // ck_maKho
            // 
            this.ck_maKho.AutoSize = true;
            this.ck_maKho.Location = new System.Drawing.Point(6, 24);
            this.ck_maKho.Name = "ck_maKho";
            this.ck_maKho.Size = new System.Drawing.Size(53, 21);
            this.ck_maKho.TabIndex = 7;
            this.ck_maKho.Text = "Kho";
            this.ck_maKho.UseVisualStyleBackColor = true;
            this.ck_maKho.CheckedChanged += new System.EventHandler(this.ck_maKho_CheckedChanged);
            // 
            // ck_timKiem
            // 
            this.ck_timKiem.AutoSize = true;
            this.ck_timKiem.Location = new System.Drawing.Point(12, 130);
            this.ck_timKiem.Name = "ck_timKiem";
            this.ck_timKiem.Size = new System.Drawing.Size(87, 21);
            this.ck_timKiem.TabIndex = 1;
            this.ck_timKiem.Text = "Tìm kiếm";
            this.ck_timKiem.UseVisualStyleBackColor = true;
            this.ck_timKiem.CheckedChanged += new System.EventHandler(this.ck_timKiem_CheckedChanged);
            // 
            // but_timKiem
            // 
            this.but_timKiem.Enabled = false;
            this.but_timKiem.Image = ((System.Drawing.Image)(resources.GetObject("but_timKiem.Image")));
            this.but_timKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_timKiem.Location = new System.Drawing.Point(105, 119);
            this.but_timKiem.Name = "but_timKiem";
            this.but_timKiem.Size = new System.Drawing.Size(129, 40);
            this.but_timKiem.TabIndex = 2;
            this.but_timKiem.Text = "Tìm kiếm";
            this.but_timKiem.UseVisualStyleBackColor = true;
            this.but_timKiem.Click += new System.EventHandler(this.but_timKiem_Click);
            // 
            // dgv_hangHoaThongKe
            // 
            this.dgv_hangHoaThongKe.AllowUserToAddRows = false;
            this.dgv_hangHoaThongKe.AllowUserToDeleteRows = false;
            this.dgv_hangHoaThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_hangHoaThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hangHoaThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHangHoa,
            this.TenHangHoa,
            this.MaDonViTinh,
            this.TenDonViTinh,
            this.SoLuong});
            this.dgv_hangHoaThongKe.Location = new System.Drawing.Point(12, 165);
            this.dgv_hangHoaThongKe.MultiSelect = false;
            this.dgv_hangHoaThongKe.Name = "dgv_hangHoaThongKe";
            this.dgv_hangHoaThongKe.ReadOnly = true;
            this.dgv_hangHoaThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hangHoaThongKe.Size = new System.Drawing.Size(663, 384);
            this.dgv_hangHoaThongKe.TabIndex = 4;
            this.dgv_hangHoaThongKe.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hangHoaThongKe_RowEnter);
            // 
            // but_xuatExcel
            // 
            this.but_xuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("but_xuatExcel.Image")));
            this.but_xuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_xuatExcel.Location = new System.Drawing.Point(240, 119);
            this.but_xuatExcel.Name = "but_xuatExcel";
            this.but_xuatExcel.Size = new System.Drawing.Size(129, 40);
            this.but_xuatExcel.TabIndex = 3;
            this.but_xuatExcel.Text = "Xuất file excel";
            this.but_xuatExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_xuatExcel.UseVisualStyleBackColor = true;
            this.but_xuatExcel.Click += new System.EventHandler(this.but_xuatExcel_Click);
            // 
            // but_dong
            // 
            this.but_dong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_dong.Image = ((System.Drawing.Image)(resources.GetObject("but_dong.Image")));
            this.but_dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_dong.Location = new System.Drawing.Point(832, 119);
            this.but_dong.Name = "but_dong";
            this.but_dong.Size = new System.Drawing.Size(100, 40);
            this.but_dong.TabIndex = 6;
            this.but_dong.Text = "Đóng";
            this.but_dong.UseVisualStyleBackColor = true;
            this.but_dong.Click += new System.EventHandler(this.but_dong_Click);
            // 
            // tv_danhSachKho
            // 
            this.tv_danhSachKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv_danhSachKho.Location = new System.Drawing.Point(681, 165);
            this.tv_danhSachKho.Name = "tv_danhSachKho";
            this.tv_danhSachKho.Size = new System.Drawing.Size(251, 384);
            this.tv_danhSachKho.TabIndex = 5;
            // 
            // MaHangHoa
            // 
            this.MaHangHoa.DataPropertyName = "MaHangHoa";
            this.MaHangHoa.HeaderText = "Mã hàng hoá";
            this.MaHangHoa.Name = "MaHangHoa";
            this.MaHangHoa.ReadOnly = true;
            this.MaHangHoa.Width = 125;
            // 
            // TenHangHoa
            // 
            this.TenHangHoa.DataPropertyName = "TenHangHoa";
            this.TenHangHoa.HeaderText = "Hàng hoá";
            this.TenHangHoa.Name = "TenHangHoa";
            this.TenHangHoa.ReadOnly = true;
            this.TenHangHoa.Width = 140;
            // 
            // MaDonViTinh
            // 
            this.MaDonViTinh.DataPropertyName = "MaDonViTinh";
            this.MaDonViTinh.HeaderText = "Mã đơn vị tính";
            this.MaDonViTinh.Name = "MaDonViTinh";
            this.MaDonViTinh.ReadOnly = true;
            this.MaDonViTinh.Width = 125;
            // 
            // TenDonViTinh
            // 
            this.TenDonViTinh.DataPropertyName = "TenDonViTinh";
            this.TenDonViTinh.HeaderText = "Đơn vị tính";
            this.TenDonViTinh.Name = "TenDonViTinh";
            this.TenDonViTinh.ReadOnly = true;
            this.TenDonViTinh.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // FrmThongKeKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.tv_danhSachKho);
            this.Controls.Add(this.but_dong);
            this.Controls.Add(this.dgv_hangHoaThongKe);
            this.Controls.Add(this.but_xuatExcel);
            this.Controls.Add(this.but_timKiem);
            this.Controls.Add(this.ck_timKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmThongKeKho";
            this.Text = "THỐNG KÊ KHO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hangHoaThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_kho;
        private System.Windows.Forms.CheckBox ck_maKho;
        private System.Windows.Forms.ComboBox cbb_hangHoa;
        private System.Windows.Forms.CheckBox ck_hangHoa;
        private System.Windows.Forms.CheckBox ck_donViTinh;
        private System.Windows.Forms.ComboBox cbb_donViTinh;
        private System.Windows.Forms.CheckBox ck_timKiem;
        private System.Windows.Forms.Button but_timKiem;
        private System.Windows.Forms.DataGridView dgv_hangHoaThongKe;
        private System.Windows.Forms.Button but_xuatExcel;
        private System.Windows.Forms.Button but_dong;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.TreeView tv_danhSachKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}