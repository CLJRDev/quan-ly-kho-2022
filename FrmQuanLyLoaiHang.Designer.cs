
namespace QuanLyKho_Tuan1
{
    partial class FrmQuanLyLoaiHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyLoaiHang));
            this.txt_maLoaiHang = new System.Windows.Forms.TextBox();
            this.txt_tenLoaiHang = new System.Windows.Forms.TextBox();
            this.but_them = new System.Windows.Forms.Button();
            this.dgv_LoaiHang = new System.Windows.Forms.DataGridView();
            this.MaLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_sua = new System.Windows.Forms.Button();
            this.but_xoa = new System.Windows.Forms.Button();
            this.errorMes = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ck_tenLoaiHang = new System.Windows.Forms.CheckBox();
            this.ck_maLoaiHang = new System.Windows.Forms.CheckBox();
            this.status = new System.Windows.Forms.StatusStrip();
            this.labMes = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.ck_timKiem = new System.Windows.Forms.CheckBox();
            this.but_timKiem = new System.Windows.Forms.Button();
            this.tv_hangHoa = new System.Windows.Forms.TreeView();
            this.but_dong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_maLoaiHang
            // 
            this.txt_maLoaiHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_maLoaiHang.Location = new System.Drawing.Point(120, 27);
            this.txt_maLoaiHang.MaxLength = 3;
            this.txt_maLoaiHang.Name = "txt_maLoaiHang";
            this.txt_maLoaiHang.Size = new System.Drawing.Size(206, 24);
            this.txt_maLoaiHang.TabIndex = 1;
            // 
            // txt_tenLoaiHang
            // 
            this.txt_tenLoaiHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tenLoaiHang.Location = new System.Drawing.Point(120, 57);
            this.txt_tenLoaiHang.Name = "txt_tenLoaiHang";
            this.txt_tenLoaiHang.Size = new System.Drawing.Size(206, 24);
            this.txt_tenLoaiHang.TabIndex = 3;
            // 
            // but_them
            // 
            this.but_them.Image = ((System.Drawing.Image)(resources.GetObject("but_them.Image")));
            this.but_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_them.Location = new System.Drawing.Point(106, 142);
            this.but_them.Name = "but_them";
            this.but_them.Size = new System.Drawing.Size(100, 40);
            this.but_them.TabIndex = 2;
            this.but_them.Text = "Thêm";
            this.but_them.UseVisualStyleBackColor = true;
            this.but_them.Click += new System.EventHandler(this.but_them_Click);
            // 
            // dgv_LoaiHang
            // 
            this.dgv_LoaiHang.AllowUserToAddRows = false;
            this.dgv_LoaiHang.AllowUserToDeleteRows = false;
            this.dgv_LoaiHang.AllowUserToResizeColumns = false;
            this.dgv_LoaiHang.AllowUserToResizeRows = false;
            this.dgv_LoaiHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_LoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiHang,
            this.TenLoaiHang});
            this.dgv_LoaiHang.Location = new System.Drawing.Point(12, 188);
            this.dgv_LoaiHang.MultiSelect = false;
            this.dgv_LoaiHang.Name = "dgv_LoaiHang";
            this.dgv_LoaiHang.ReadOnly = true;
            this.dgv_LoaiHang.RowHeadersWidth = 51;
            this.dgv_LoaiHang.RowTemplate.Height = 24;
            this.dgv_LoaiHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LoaiHang.Size = new System.Drawing.Size(681, 348);
            this.dgv_LoaiHang.TabIndex = 6;
            this.dgv_LoaiHang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LoaiHang_RowEnter);
            // 
            // MaLoaiHang
            // 
            this.MaLoaiHang.DataPropertyName = "MaLoaiHang";
            this.MaLoaiHang.HeaderText = "Mã loại hàng";
            this.MaLoaiHang.MinimumWidth = 6;
            this.MaLoaiHang.Name = "MaLoaiHang";
            this.MaLoaiHang.ReadOnly = true;
            this.MaLoaiHang.Width = 200;
            // 
            // TenLoaiHang
            // 
            this.TenLoaiHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLoaiHang.DataPropertyName = "TenLoaiHang";
            this.TenLoaiHang.HeaderText = "Tên loại hàng";
            this.TenLoaiHang.MinimumWidth = 6;
            this.TenLoaiHang.Name = "TenLoaiHang";
            this.TenLoaiHang.ReadOnly = true;
            // 
            // but_sua
            // 
            this.but_sua.Image = ((System.Drawing.Image)(resources.GetObject("but_sua.Image")));
            this.but_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_sua.Location = new System.Drawing.Point(212, 142);
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
            this.but_xoa.Location = new System.Drawing.Point(318, 142);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(100, 40);
            this.but_xoa.TabIndex = 4;
            this.but_xoa.Text = "Xoá";
            this.but_xoa.UseVisualStyleBackColor = true;
            this.but_xoa.Click += new System.EventHandler(this.but_xoa_Click);
            // 
            // errorMes
            // 
            this.errorMes.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ck_tenLoaiHang);
            this.groupBox1.Controls.Add(this.ck_maLoaiHang);
            this.groupBox1.Controls.Add(this.txt_maLoaiHang);
            this.groupBox1.Controls.Add(this.txt_tenLoaiHang);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại hàng";
            // 
            // ck_tenLoaiHang
            // 
            this.ck_tenLoaiHang.AutoSize = true;
            this.ck_tenLoaiHang.Location = new System.Drawing.Point(6, 56);
            this.ck_tenLoaiHang.Name = "ck_tenLoaiHang";
            this.ck_tenLoaiHang.Size = new System.Drawing.Size(106, 24);
            this.ck_tenLoaiHang.TabIndex = 2;
            this.ck_tenLoaiHang.Text = "Tên loại hàng";
            this.ck_tenLoaiHang.UseVisualStyleBackColor = true;
            // 
            // ck_maLoaiHang
            // 
            this.ck_maLoaiHang.AutoSize = true;
            this.ck_maLoaiHang.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_maLoaiHang.Location = new System.Drawing.Point(6, 28);
            this.ck_maLoaiHang.Name = "ck_maLoaiHang";
            this.ck_maLoaiHang.Size = new System.Drawing.Size(108, 21);
            this.ck_maLoaiHang.TabIndex = 0;
            this.ck_maLoaiHang.Text = "Mã loại hàng";
            this.ck_maLoaiHang.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labMes});
            this.status.Location = new System.Drawing.Point(0, 539);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(944, 22);
            this.status.TabIndex = 5;
            this.status.Text = "statusStrip1";
            // 
            // labMes
            // 
            this.labMes.Name = "labMes";
            this.labMes.Size = new System.Drawing.Size(64, 17);
            this.labMes.Text = "Thông báo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(502, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "THÔNG TIN DANH SÁCH LOẠI HÀNG";
            // 
            // ck_timKiem
            // 
            this.ck_timKiem.AutoSize = true;
            this.ck_timKiem.Location = new System.Drawing.Point(18, 151);
            this.ck_timKiem.Name = "ck_timKiem";
            this.ck_timKiem.Size = new System.Drawing.Size(82, 24);
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
            this.but_timKiem.Location = new System.Drawing.Point(424, 142);
            this.but_timKiem.Name = "but_timKiem";
            this.but_timKiem.Size = new System.Drawing.Size(100, 40);
            this.but_timKiem.TabIndex = 5;
            this.but_timKiem.Text = "Tìm";
            this.but_timKiem.UseVisualStyleBackColor = true;
            this.but_timKiem.Click += new System.EventHandler(this.but_timKiem_Click);
            // 
            // tv_hangHoa
            // 
            this.tv_hangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv_hangHoa.Location = new System.Drawing.Point(699, 188);
            this.tv_hangHoa.Name = "tv_hangHoa";
            this.tv_hangHoa.Size = new System.Drawing.Size(233, 348);
            this.tv_hangHoa.TabIndex = 7;
            // 
            // but_dong
            // 
            this.but_dong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_dong.Image = ((System.Drawing.Image)(resources.GetObject("but_dong.Image")));
            this.but_dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_dong.Location = new System.Drawing.Point(832, 142);
            this.but_dong.Name = "but_dong";
            this.but_dong.Size = new System.Drawing.Size(100, 40);
            this.but_dong.TabIndex = 8;
            this.but_dong.Text = "Đóng";
            this.but_dong.UseVisualStyleBackColor = true;
            this.but_dong.Click += new System.EventHandler(this.but_dong_Click);
            // 
            // FrmQuanLyLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.but_dong);
            this.Controls.Add(this.tv_hangHoa);
            this.Controls.Add(this.ck_timKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.status);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_LoaiHang);
            this.Controls.Add(this.but_timKiem);
            this.Controls.Add(this.but_xoa);
            this.Controls.Add(this.but_sua);
            this.Controls.Add(this.but_them);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmQuanLyLoaiHang";
            this.Text = "QUẢN LÝ LOẠI HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_maLoaiHang;
        private System.Windows.Forms.TextBox txt_tenLoaiHang;
        private System.Windows.Forms.Button but_them;
        private System.Windows.Forms.DataGridView dgv_LoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiHang;
        private System.Windows.Forms.Button but_sua;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.ErrorProvider errorMes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel labMes;
        private System.Windows.Forms.CheckBox ck_timKiem;
        private System.Windows.Forms.CheckBox ck_tenLoaiHang;
        private System.Windows.Forms.CheckBox ck_maLoaiHang;
        private System.Windows.Forms.Button but_timKiem;
        private System.Windows.Forms.TreeView tv_hangHoa;
        private System.Windows.Forms.Button but_dong;
    }
}

