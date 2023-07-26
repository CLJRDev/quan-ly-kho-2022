
namespace QuanLyKho_Tuan1
{
    partial class FrmQuanLyDonViTinhHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyDonViTinhHangHoa));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_donViTinh = new System.Windows.Forms.ComboBox();
            this.txt_hienThiHangHoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_donViTinhHangHoa = new System.Windows.Forms.DataGridView();
            this.TenDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_themDonViTinh = new System.Windows.Forms.Button();
            this.but_xoaDonViTinh = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_donViTinhHangHoa)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐƠN VỊ TÍNH HÀNG HOÁ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_donViTinh);
            this.groupBox1.Controls.Add(this.txt_hienThiHangHoa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // cbb_donViTinh
            // 
            this.cbb_donViTinh.DisplayMember = "TenDonViTinh";
            this.cbb_donViTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_donViTinh.FormattingEnabled = true;
            this.cbb_donViTinh.Location = new System.Drawing.Point(90, 61);
            this.cbb_donViTinh.Name = "cbb_donViTinh";
            this.cbb_donViTinh.Size = new System.Drawing.Size(216, 25);
            this.cbb_donViTinh.TabIndex = 2;
            this.cbb_donViTinh.ValueMember = "MaDonViTinh";
            // 
            // txt_hienThiHangHoa
            // 
            this.txt_hienThiHangHoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hienThiHangHoa.Location = new System.Drawing.Point(90, 26);
            this.txt_hienThiHangHoa.Name = "txt_hienThiHangHoa";
            this.txt_hienThiHangHoa.ReadOnly = true;
            this.txt_hienThiHangHoa.Size = new System.Drawing.Size(216, 25);
            this.txt_hienThiHangHoa.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn vị tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hàng hoá";
            // 
            // dgv_donViTinhHangHoa
            // 
            this.dgv_donViTinhHangHoa.AllowUserToAddRows = false;
            this.dgv_donViTinhHangHoa.AllowUserToDeleteRows = false;
            this.dgv_donViTinhHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_donViTinhHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDonViTinh,
            this.MaDonViTinh});
            this.dgv_donViTinhHangHoa.Location = new System.Drawing.Point(12, 181);
            this.dgv_donViTinhHangHoa.MultiSelect = false;
            this.dgv_donViTinhHangHoa.Name = "dgv_donViTinhHangHoa";
            this.dgv_donViTinhHangHoa.ReadOnly = true;
            this.dgv_donViTinhHangHoa.RowTemplate.Height = 24;
            this.dgv_donViTinhHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_donViTinhHangHoa.Size = new System.Drawing.Size(323, 255);
            this.dgv_donViTinhHangHoa.TabIndex = 2;
            // 
            // TenDonViTinh
            // 
            this.TenDonViTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDonViTinh.DataPropertyName = "TenDonViTinh";
            this.TenDonViTinh.HeaderText = "Đơn vị tính";
            this.TenDonViTinh.Name = "TenDonViTinh";
            this.TenDonViTinh.ReadOnly = true;
            // 
            // MaDonViTinh
            // 
            this.MaDonViTinh.DataPropertyName = "MaDonViTinh";
            this.MaDonViTinh.HeaderText = "Mã Đơn vị tính";
            this.MaDonViTinh.Name = "MaDonViTinh";
            this.MaDonViTinh.ReadOnly = true;
            this.MaDonViTinh.Visible = false;
            // 
            // but_themDonViTinh
            // 
            this.but_themDonViTinh.Image = ((System.Drawing.Image)(resources.GetObject("but_themDonViTinh.Image")));
            this.but_themDonViTinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_themDonViTinh.Location = new System.Drawing.Point(12, 140);
            this.but_themDonViTinh.Name = "but_themDonViTinh";
            this.but_themDonViTinh.Size = new System.Drawing.Size(150, 35);
            this.but_themDonViTinh.TabIndex = 3;
            this.but_themDonViTinh.Text = "Thêm đơn vị tính";
            this.but_themDonViTinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_themDonViTinh.UseVisualStyleBackColor = true;
            this.but_themDonViTinh.Click += new System.EventHandler(this.but_themDonViTinh_Click);
            // 
            // but_xoaDonViTinh
            // 
            this.but_xoaDonViTinh.Image = ((System.Drawing.Image)(resources.GetObject("but_xoaDonViTinh.Image")));
            this.but_xoaDonViTinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_xoaDonViTinh.Location = new System.Drawing.Point(168, 140);
            this.but_xoaDonViTinh.Name = "but_xoaDonViTinh";
            this.but_xoaDonViTinh.Size = new System.Drawing.Size(150, 35);
            this.but_xoaDonViTinh.TabIndex = 3;
            this.but_xoaDonViTinh.Text = "Xoá đơn vị tính";
            this.but_xoaDonViTinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_xoaDonViTinh.UseVisualStyleBackColor = true;
            this.but_xoaDonViTinh.Click += new System.EventHandler(this.but_xoaDonViTinh_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(344, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(67, 17);
            this.status.Text = "Thông báo:";
            // 
            // FrmQuanLyDonViTinhHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.but_xoaDonViTinh);
            this.Controls.Add(this.but_themDonViTinh);
            this.Controls.Add(this.dgv_donViTinhHangHoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQuanLyDonViTinhHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ ĐƠN VỊ TÍNH HÀNG HOÁ";
            this.Load += new System.EventHandler(this.FrmQuanLyDonViTinhHangHoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_donViTinhHangHoa)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_donViTinh;
        private System.Windows.Forms.TextBox txt_hienThiHangHoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_donViTinhHangHoa;
        private System.Windows.Forms.Button but_themDonViTinh;
        private System.Windows.Forms.Button but_xoaDonViTinh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonViTinh;
    }
}