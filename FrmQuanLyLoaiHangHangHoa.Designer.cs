
namespace QuanLyKho_Tuan1
{
    partial class FrmQuanLyLoaiHangHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyLoaiHangHangHoa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_loaiHang = new System.Windows.Forms.ComboBox();
            this.txt_hienThiHangHoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_loaiHangHangHoa = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.but_xoaLoaiHang = new System.Windows.Forms.Button();
            this.but_themLoaiHang = new System.Windows.Forms.Button();
            this.TenLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiHangHangHoa)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_loaiHang);
            this.groupBox1.Controls.Add(this.txt_hienThiHangHoa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // cbb_loaiHang
            // 
            this.cbb_loaiHang.DisplayMember = "TenLoaiHang";
            this.cbb_loaiHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_loaiHang.FormattingEnabled = true;
            this.cbb_loaiHang.Location = new System.Drawing.Point(90, 61);
            this.cbb_loaiHang.Name = "cbb_loaiHang";
            this.cbb_loaiHang.Size = new System.Drawing.Size(216, 25);
            this.cbb_loaiHang.TabIndex = 2;
            this.cbb_loaiHang.ValueMember = "MaLoaiHang";
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
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại hàng";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUẢN LÝ LOẠI HÀNG HÀNG HOÁ";
            // 
            // dgv_loaiHangHangHoa
            // 
            this.dgv_loaiHangHangHoa.AllowUserToAddRows = false;
            this.dgv_loaiHangHangHoa.AllowUserToDeleteRows = false;
            this.dgv_loaiHangHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loaiHangHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenLoaiHang,
            this.MaLoaiHang});
            this.dgv_loaiHangHangHoa.Location = new System.Drawing.Point(12, 177);
            this.dgv_loaiHangHangHoa.MultiSelect = false;
            this.dgv_loaiHangHangHoa.Name = "dgv_loaiHangHangHoa";
            this.dgv_loaiHangHangHoa.ReadOnly = true;
            this.dgv_loaiHangHangHoa.RowTemplate.Height = 24;
            this.dgv_loaiHangHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_loaiHangHangHoa.Size = new System.Drawing.Size(323, 255);
            this.dgv_loaiHangHangHoa.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(344, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(67, 17);
            this.status.Text = "Thông báo:";
            // 
            // but_xoaLoaiHang
            // 
            this.but_xoaLoaiHang.Image = ((System.Drawing.Image)(resources.GetObject("but_xoaLoaiHang.Image")));
            this.but_xoaLoaiHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_xoaLoaiHang.Location = new System.Drawing.Point(168, 136);
            this.but_xoaLoaiHang.Name = "but_xoaLoaiHang";
            this.but_xoaLoaiHang.Size = new System.Drawing.Size(150, 35);
            this.but_xoaLoaiHang.TabIndex = 8;
            this.but_xoaLoaiHang.Text = "Xoá loại hàng";
            this.but_xoaLoaiHang.UseVisualStyleBackColor = true;
            this.but_xoaLoaiHang.Click += new System.EventHandler(this.but_xoaLoaiHang_Click);
            // 
            // but_themLoaiHang
            // 
            this.but_themLoaiHang.Image = ((System.Drawing.Image)(resources.GetObject("but_themLoaiHang.Image")));
            this.but_themLoaiHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_themLoaiHang.Location = new System.Drawing.Point(12, 136);
            this.but_themLoaiHang.Name = "but_themLoaiHang";
            this.but_themLoaiHang.Size = new System.Drawing.Size(150, 35);
            this.but_themLoaiHang.TabIndex = 9;
            this.but_themLoaiHang.Text = "Thêm loại hàng";
            this.but_themLoaiHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_themLoaiHang.UseVisualStyleBackColor = true;
            this.but_themLoaiHang.Click += new System.EventHandler(this.but_themLoaiHang_Click);
            // 
            // TenLoaiHang
            // 
            this.TenLoaiHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLoaiHang.DataPropertyName = "TenLoaiHang";
            this.TenLoaiHang.HeaderText = "Loại hàng";
            this.TenLoaiHang.Name = "TenLoaiHang";
            this.TenLoaiHang.ReadOnly = true;
            // 
            // MaLoaiHang
            // 
            this.MaLoaiHang.DataPropertyName = "MaLoaiHang";
            this.MaLoaiHang.HeaderText = "";
            this.MaLoaiHang.Name = "MaLoaiHang";
            this.MaLoaiHang.ReadOnly = true;
            this.MaLoaiHang.Visible = false;
            // 
            // FrmQuanLyLoaiHangHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_loaiHangHangHoa);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.but_xoaLoaiHang);
            this.Controls.Add(this.but_themLoaiHang);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQuanLyLoaiHangHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ LOẠI HÀNG HÀNG HOÁ";
            this.Load += new System.EventHandler(this.FrmQuanLyLoaiHangHangHoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiHangHangHoa)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_loaiHang;
        private System.Windows.Forms.TextBox txt_hienThiHangHoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_loaiHangHangHoa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.Button but_xoaLoaiHang;
        private System.Windows.Forms.Button but_themLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiHang;
    }
}