
namespace QuanLyKho_Tuan1
{
    partial class FrmQuanLyDonViTinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyDonViTinh));
            this.ck_timKiem = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labMes = new System.Windows.Forms.ToolStripStatusLabel();
            this.status = new System.Windows.Forms.StatusStrip();
            this.ck_tenDonViTinh = new System.Windows.Forms.CheckBox();
            this.ck_maDonViTinh = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_maDonViTinh = new System.Windows.Forms.TextBox();
            this.txt_tenDonViTinh = new System.Windows.Forms.TextBox();
            this.but_timKiem = new System.Windows.Forms.Button();
            this.errorMes = new System.Windows.Forms.ErrorProvider(this.components);
            this.but_xoa = new System.Windows.Forms.Button();
            this.but_sua = new System.Windows.Forms.Button();
            this.dgv_DonViTinh = new System.Windows.Forms.DataGridView();
            this.MaDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_them = new System.Windows.Forms.Button();
            this.tv_danhSachHangHoa = new System.Windows.Forms.TreeView();
            this.but_dong = new System.Windows.Forms.Button();
            this.status.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonViTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // ck_timKiem
            // 
            this.ck_timKiem.AutoSize = true;
            this.ck_timKiem.Location = new System.Drawing.Point(12, 157);
            this.ck_timKiem.Name = "ck_timKiem";
            this.ck_timKiem.Size = new System.Drawing.Size(82, 24);
            this.ck_timKiem.TabIndex = 1;
            this.ck_timKiem.Text = "Tìm kiếm";
            this.ck_timKiem.UseVisualStyleBackColor = true;
            this.ck_timKiem.CheckedChanged += new System.EventHandler(this.ck_timKiem_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(520, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "THÔNG TIN DANH SÁCH ĐƠN VỊ TÍNH";
            // 
            // labMes
            // 
            this.labMes.Name = "labMes";
            this.labMes.Size = new System.Drawing.Size(67, 17);
            this.labMes.Text = "Thông báo:";
            // 
            // status
            // 
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labMes});
            this.status.Location = new System.Drawing.Point(0, 531);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(942, 22);
            this.status.TabIndex = 16;
            this.status.Text = "statusStrip1";
            // 
            // ck_tenDonViTinh
            // 
            this.ck_tenDonViTinh.AutoSize = true;
            this.ck_tenDonViTinh.Location = new System.Drawing.Point(6, 61);
            this.ck_tenDonViTinh.Name = "ck_tenDonViTinh";
            this.ck_tenDonViTinh.Size = new System.Drawing.Size(111, 24);
            this.ck_tenDonViTinh.TabIndex = 2;
            this.ck_tenDonViTinh.Text = "Tên đơn vị tính";
            this.ck_tenDonViTinh.UseVisualStyleBackColor = true;
            // 
            // ck_maDonViTinh
            // 
            this.ck_maDonViTinh.AutoSize = true;
            this.ck_maDonViTinh.Location = new System.Drawing.Point(6, 27);
            this.ck_maDonViTinh.Name = "ck_maDonViTinh";
            this.ck_maDonViTinh.Size = new System.Drawing.Size(106, 24);
            this.ck_maDonViTinh.TabIndex = 0;
            this.ck_maDonViTinh.Text = "Mã đơn vị tính";
            this.ck_maDonViTinh.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ck_tenDonViTinh);
            this.groupBox1.Controls.Add(this.ck_maDonViTinh);
            this.groupBox1.Controls.Add(this.txt_maDonViTinh);
            this.groupBox1.Controls.Add(this.txt_tenDonViTinh);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại hàng";
            // 
            // txt_maDonViTinh
            // 
            this.txt_maDonViTinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_maDonViTinh.Location = new System.Drawing.Point(118, 27);
            this.txt_maDonViTinh.MaxLength = 3;
            this.txt_maDonViTinh.Name = "txt_maDonViTinh";
            this.txt_maDonViTinh.Size = new System.Drawing.Size(206, 24);
            this.txt_maDonViTinh.TabIndex = 1;
            // 
            // txt_tenDonViTinh
            // 
            this.txt_tenDonViTinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tenDonViTinh.Location = new System.Drawing.Point(118, 61);
            this.txt_tenDonViTinh.Name = "txt_tenDonViTinh";
            this.txt_tenDonViTinh.Size = new System.Drawing.Size(206, 24);
            this.txt_tenDonViTinh.TabIndex = 3;
            // 
            // but_timKiem
            // 
            this.but_timKiem.Enabled = false;
            this.but_timKiem.Image = ((System.Drawing.Image)(resources.GetObject("but_timKiem.Image")));
            this.but_timKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_timKiem.Location = new System.Drawing.Point(418, 148);
            this.but_timKiem.Name = "but_timKiem";
            this.but_timKiem.Size = new System.Drawing.Size(100, 40);
            this.but_timKiem.TabIndex = 5;
            this.but_timKiem.Text = "Tìm";
            this.but_timKiem.UseVisualStyleBackColor = true;
            this.but_timKiem.Click += new System.EventHandler(this.but_timKiem_Click);
            // 
            // errorMes
            // 
            this.errorMes.ContainerControl = this;
            // 
            // but_xoa
            // 
            this.but_xoa.Image = ((System.Drawing.Image)(resources.GetObject("but_xoa.Image")));
            this.but_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_xoa.Location = new System.Drawing.Point(312, 148);
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
            this.but_sua.Location = new System.Drawing.Point(206, 148);
            this.but_sua.Name = "but_sua";
            this.but_sua.Size = new System.Drawing.Size(100, 40);
            this.but_sua.TabIndex = 3;
            this.but_sua.Text = "Sửa";
            this.but_sua.UseVisualStyleBackColor = true;
            this.but_sua.Click += new System.EventHandler(this.but_sua_Click);
            // 
            // dgv_DonViTinh
            // 
            this.dgv_DonViTinh.AllowUserToAddRows = false;
            this.dgv_DonViTinh.AllowUserToDeleteRows = false;
            this.dgv_DonViTinh.AllowUserToResizeColumns = false;
            this.dgv_DonViTinh.AllowUserToResizeRows = false;
            this.dgv_DonViTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DonViTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DonViTinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDonViTinh,
            this.TenDonViTinh});
            this.dgv_DonViTinh.Location = new System.Drawing.Point(12, 194);
            this.dgv_DonViTinh.MultiSelect = false;
            this.dgv_DonViTinh.Name = "dgv_DonViTinh";
            this.dgv_DonViTinh.ReadOnly = true;
            this.dgv_DonViTinh.RowHeadersWidth = 51;
            this.dgv_DonViTinh.RowTemplate.Height = 24;
            this.dgv_DonViTinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DonViTinh.Size = new System.Drawing.Size(675, 330);
            this.dgv_DonViTinh.TabIndex = 6;
            this.dgv_DonViTinh.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DonViTinh_RowEnter);
            // 
            // MaDonViTinh
            // 
            this.MaDonViTinh.DataPropertyName = "MaDonViTinh";
            this.MaDonViTinh.HeaderText = "Mã đơn vị tính";
            this.MaDonViTinh.MinimumWidth = 6;
            this.MaDonViTinh.Name = "MaDonViTinh";
            this.MaDonViTinh.ReadOnly = true;
            this.MaDonViTinh.Width = 200;
            // 
            // TenDonViTinh
            // 
            this.TenDonViTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDonViTinh.DataPropertyName = "TenDonViTinh";
            this.TenDonViTinh.HeaderText = "Tên đơn vị tính";
            this.TenDonViTinh.MinimumWidth = 6;
            this.TenDonViTinh.Name = "TenDonViTinh";
            this.TenDonViTinh.ReadOnly = true;
            // 
            // but_them
            // 
            this.but_them.Image = ((System.Drawing.Image)(resources.GetObject("but_them.Image")));
            this.but_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_them.Location = new System.Drawing.Point(100, 148);
            this.but_them.Name = "but_them";
            this.but_them.Size = new System.Drawing.Size(100, 40);
            this.but_them.TabIndex = 2;
            this.but_them.Text = "Thêm";
            this.but_them.UseVisualStyleBackColor = true;
            this.but_them.Click += new System.EventHandler(this.but_them_Click);
            // 
            // tv_danhSachHangHoa
            // 
            this.tv_danhSachHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv_danhSachHangHoa.Location = new System.Drawing.Point(693, 194);
            this.tv_danhSachHangHoa.Name = "tv_danhSachHangHoa";
            this.tv_danhSachHangHoa.Size = new System.Drawing.Size(237, 330);
            this.tv_danhSachHangHoa.TabIndex = 7;
            // 
            // but_dong
            // 
            this.but_dong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_dong.Image = ((System.Drawing.Image)(resources.GetObject("but_dong.Image")));
            this.but_dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_dong.Location = new System.Drawing.Point(830, 148);
            this.but_dong.Name = "but_dong";
            this.but_dong.Size = new System.Drawing.Size(100, 40);
            this.but_dong.TabIndex = 8;
            this.but_dong.Text = "Đóng";
            this.but_dong.UseVisualStyleBackColor = true;
            this.but_dong.Click += new System.EventHandler(this.but_dong_Click);
            // 
            // FrmQuanLyDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 553);
            this.Controls.Add(this.but_dong);
            this.Controls.Add(this.tv_danhSachHangHoa);
            this.Controls.Add(this.ck_timKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.status);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.but_timKiem);
            this.Controls.Add(this.but_xoa);
            this.Controls.Add(this.but_sua);
            this.Controls.Add(this.dgv_DonViTinh);
            this.Controls.Add(this.but_them);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmQuanLyDonViTinh";
            this.Text = "QUẢN LÝ ĐƠN VỊ TÍNH";
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonViTinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ck_timKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel labMes;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.CheckBox ck_tenDonViTinh;
        private System.Windows.Forms.CheckBox ck_maDonViTinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_maDonViTinh;
        private System.Windows.Forms.TextBox txt_tenDonViTinh;
        private System.Windows.Forms.Button but_timKiem;
        private System.Windows.Forms.ErrorProvider errorMes;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.Button but_sua;
        private System.Windows.Forms.DataGridView dgv_DonViTinh;
        private System.Windows.Forms.Button but_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDonViTinh;
        private System.Windows.Forms.TreeView tv_danhSachHangHoa;
        private System.Windows.Forms.Button but_dong;
    }
}