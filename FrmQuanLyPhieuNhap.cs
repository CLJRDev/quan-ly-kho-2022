using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho_Tuan1
{
    public partial class FrmQuanLyPhieuNhap : Form
    {
        private void loadMaKho()
        {
            string select = "select * from Kho";
            DataTable table = Database.Query(select,new Dictionary<string, object>());
            cbb_maKho.DataSource = table; 
        }
        private void loadHangHoa()
        {
            cbb_hangHoa.DataSource = Database.Query("select * from HangHoa", new Dictionary<string, object>());
        }
        public void loadDgvPhieuNhap()
        {         
                string strCommand = "select * from dbo.ufTimKiemPhieuNhap(@maPhieuNhap,@ngayNhapTu,@ngayNhapDen,@nguoiGiaoHang,@nguonNhap,@maKho,@thuKho,@ghiChu,@maHangHoa,@maDonViTinh,@soLuong,@donGia,@chietKhau)";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                if (ck_maPhieuNhap.Checked)
                {
                    parameter.Add("@maPhieuNhap", Convert.ToDouble(txt_maPhieuNhap.Text));
                }
                else
                {
                    parameter.Add("@maPhieuNhap", "");
                }
                if (ck_ngayNhapTu.Checked)
                {
                    parameter.Add("@ngayNhapTu", dtp_ngayNhapTu.Value);
                }
                else
                {
                    parameter.Add("@ngayNhapTu", "");
                }
                if (ck_ngayNhapDen.Checked)
                {
                    parameter.Add("@ngayNhapDen", dtp_ngayNhapDen.Value);
                }
                else
                {
                    parameter.Add("@ngayNhapDen", "");
                }
                if (ck_nguoiGiaoHang.Checked)
                {
                    parameter.Add("@nguoiGiaoHang", txt_nguoiGiaoHang.Text);
                }
                else
                {
                    parameter.Add("@nguoiGiaoHang", "");
                }
                if (ck_nguonNhap.Checked)
                {
                    parameter.Add("@nguonNhap", txt_nguonNhap.Text);
                }
                else 
                {
                    parameter.Add("@nguonNhap", "");
                }
                if (ck_maKho.Checked)
                {                    
                    parameter.Add("@maKho", cbb_maKho.SelectedValue);
                }
                else
                {
                    parameter.Add("@maKho", "");
                }
                if (ck_thuKho.Checked)
                {                    
                    parameter.Add("@thuKho", txt_thuKho.Text);
                }
                else
                {
                    parameter.Add("@thuKho", "");
                }
                if (ck_ghiChu.Checked)
                {                   
                    parameter.Add("@ghiChu", txt_ghiChu.Text);
                }
                else
                {
                    parameter.Add("@ghiChu", "");
                }
                if (ck_hangHoa.Checked)
                {                    
                    parameter.Add("@maHangHoa", cbb_hangHoa.SelectedValue);
                }
                else
                {
                    parameter.Add("@maHangHoa", "");
                }
                if (ck_donViTinh.Checked)
                {                    
                    parameter.Add("@maDonViTinh", cbb_donViTinh.SelectedValue);
                }
                else
                {
                    parameter.Add("@maDonViTinh", "");
                }
                if (ck_soLuong.Checked && !String.IsNullOrEmpty(txt_soLuong.Text))
                {                    
                    parameter.Add("@soLuong", Convert.ToDouble(txt_soLuong.Text));
                }
                else
                {
                    parameter.Add("@soLuong", "");
                }
                if (ck_donGia.Checked && !String.IsNullOrEmpty(txt_donGia.Text))
                {                    
                    parameter.Add("@donGia", Convert.ToDouble(txt_donGia.Text));
                }
                else
                {
                    parameter.Add("@donGia", "");
                }
                if (ck_chietKhau.Checked && !String.IsNullOrEmpty(txt_chietKhau.Text))
                {                    
                    parameter.Add("@chietKhau", Convert.ToDouble(txt_chietKhau.Text));
                }
                else
                {
                    parameter.Add("@chietKhau", "");
                }               
                dgv_phieuNhap.DataSource = Database.Query(strCommand, parameter);           
                but_sua.Enabled = tv_chiTietPhieuNhap.Visible = but_xoa.Enabled = dgv_phieuNhap.Rows.Count > 0;
        }
        public FrmQuanLyPhieuNhap()
        {
            InitializeComponent();
            dtp_ngayNhapTu.Value = new DateTime(DateTime.Now.Year,DateTime.Now.Month,1);
            dtp_ngayNhapDen.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            loadDgvPhieuNhap();
            loadHangHoa();
            loadMaKho();
        }

        private void but_them_Click(object sender, EventArgs e)
        {
            FrmThemPhieuNhap form = new FrmThemPhieuNhap();
            form.ShowDialog();
            loadDgvPhieuNhap();
        }

        private void ck_maPhieuNhap_CheckedChanged(object sender, EventArgs e)
        {
            txt_maPhieuNhap.Enabled = ck_maPhieuNhap.Checked;
        }

        private void ck_ngayNhapTu_CheckedChanged(object sender, EventArgs e)
        {
            dtp_ngayNhapTu.Enabled = ck_ngayNhapTu.Checked;
        }

        private void ck_ngayNhapDen_CheckedChanged(object sender, EventArgs e)
        {
            dtp_ngayNhapDen.Enabled = ck_ngayNhapDen.Checked;
        }

        private void ck_nguoiGiaoHang_CheckedChanged(object sender, EventArgs e)
        {
            txt_nguoiGiaoHang.Enabled = ck_nguoiGiaoHang.Checked;
        }

        private void ck_nguonNhap_CheckedChanged(object sender, EventArgs e)
        {
            txt_nguonNhap.Enabled = ck_nguonNhap.Checked;
        }

        private void ck_maKho_CheckedChanged(object sender, EventArgs e)
        {
            cbb_maKho.Enabled = ck_maKho.Checked;
        }

        private void ck_thuKho_CheckedChanged(object sender, EventArgs e)
        {
            txt_thuKho.Enabled = ck_thuKho.Checked;
        }

        private void ck_ghiChu_CheckedChanged(object sender, EventArgs e)
        {
            txt_ghiChu.Enabled = ck_ghiChu.Checked;
        }

        private void dgv_phieuNhap_RowEnter(object sender, DataGridViewCellEventArgs e)
        {           
            //Lấy ra mã phiếu nhập của phiếu đang chọn
            int maPhieuNhap = (int)dgv_phieuNhap.Rows[e.RowIndex].Cells["MaPhieuNhap"].Value;
            //Lấy ra các chi tiết phiếu nhập có mã phiếu ứng với mã phiếu nhập vừa lấy
            string strQuery = "select * from vwChiTietPhieuNhap where MaPhieuNhap = @maPhieuNhap";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maPhieuNhap", maPhieuNhap);
            DataTable chiTietPhieuNhaps = Database.Query(strQuery, parameter);
            //Đẩy tất cả các chi tiết đó vào tree view
            tv_chiTietPhieuNhap.Nodes.Clear();
            for(int i = 0; i < chiTietPhieuNhaps.Rows.Count; i++)
            {
                TreeNode node = new TreeNode(chiTietPhieuNhaps.Rows[i]["TenHanghoa"].ToString());
                node.Nodes.Add("Số lượng: " + chiTietPhieuNhaps.Rows[i]["SoLuong"].ToString() + " " + chiTietPhieuNhaps.Rows[i]["TenDonViTinh"].ToString());
                node.Nodes.Add("Đơn giá: " + chiTietPhieuNhaps.Rows[i]["DonGia"].ToString());
                node.Nodes.Add("Chiết khấu: " + chiTietPhieuNhaps.Rows[i]["ChietKhau"].ToString());
                node.Expand();
                tv_chiTietPhieuNhap.Nodes.Add(node);
            }
        }

        private void ck_hienThiNguoiGiaoHang_CheckedChanged(object sender, EventArgs e)
        {
            dgv_phieuNhap.Columns["NguoiGiaoHang"].Visible = ck_hienThiNguoiGiaoHang.Checked;
        }

        private void ck_hienThiNguonNhap_CheckedChanged(object sender, EventArgs e)
        {
            dgv_phieuNhap.Columns["NguonNhap"].Visible = ck_hienThiNguonNhap.Checked;
        }

        private void ck_hienThiThuKho_CheckedChanged(object sender, EventArgs e)
        {
            dgv_phieuNhap.Columns["ThuKho"].Visible = ck_hienThiThuKho.Checked;
        }

        private void ck_hienThiGhiChu_CheckedChanged(object sender, EventArgs e)
        {
            dgv_phieuNhap.Columns["GhiChu"].Visible = ck_hienThiGhiChu.Checked;
        }

        private void ck_hienThiKho_CheckedChanged(object sender, EventArgs e)
        {
            dgv_phieuNhap.Columns["TenKho"].Visible = ck_hienThiKho.Checked;
        }

        private void ck_timKiem_CheckedChanged(object sender, EventArgs e)
        {
            loadDgvPhieuNhap();
            but_timKiem.Enabled = ck_timKiem.Checked;
        }

        private void but_timKiem_Click_1(object sender, EventArgs e)
        {
            loadDgvPhieuNhap();
        }

        private void ck_hangHoa_CheckedChanged(object sender, EventArgs e)
        {
            cbb_hangHoa.Enabled = ck_hangHoa.Checked;
        }

        private void ck_donViTinh_CheckedChanged(object sender, EventArgs e)
        {
            cbb_donViTinh.Enabled = ck_donViTinh.Checked;
        }

        private void ck_soLuong_CheckedChanged(object sender, EventArgs e)
        {
            txt_soLuong.Enabled = ck_soLuong.Checked;
        }

        private void ck_donGia_CheckedChanged(object sender, EventArgs e)
        {
            txt_donGia.Enabled = ck_donGia.Checked;
        }

        private void ck_chietKhau_CheckedChanged(object sender, EventArgs e)
        {
            txt_chietKhau.Enabled = ck_chietKhau.Checked;
        }

        private void cbb_hangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_hangHoa.Text != "")
            {
                string strQuery = "select * from dbo.ufLayDonViTinhCuaHangHoa(@maHangHoa)";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                parameter.Add("@maHangHoa", cbb_hangHoa.SelectedValue);
                cbb_donViTinh.DataSource = Database.Query(strQuery, parameter);
            }
        }

        private void txt_soLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_donGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_chietKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void but_sua_Click(object sender, EventArgs e)
        {
            int maPhieuNhap = (int)dgv_phieuNhap.CurrentRow.Cells["MaPhieuNhap"].Value;
            FrmSuaPhieuNhap form = new FrmSuaPhieuNhap(maPhieuNhap);
            form.ShowDialog();
            loadDgvPhieuNhap();
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            string command = "select * from dbo.ufLayChiTietPhieuNhap(@maPhieuNhap)";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maPhieuNhap", (int)dgv_phieuNhap.CurrentRow.Cells["MaPhieuNhap"].Value);
            DataTable chiTietPhieuNhap = Database.Query(command, parameter);           
            command = "exec spXoaChiTietPhieuNhap @maPhieuNhap,@maHangHoa,@maDonViTinh";
            for(int i = 0; i < chiTietPhieuNhap.Rows.Count; i++)
            {
                parameter.Clear();
                parameter.Add("@maPhieuNhap", (int)dgv_phieuNhap.CurrentRow.Cells["MaPhieuNhap"].Value);
                parameter.Add("@maHangHoa", chiTietPhieuNhap.Rows[i]["MaHangHoa"].ToString());
                parameter.Add("@maDonViTinh", chiTietPhieuNhap.Rows[i]["MaDonViTInh"].ToString());
                try
                {
                    Database.Execute(command, parameter);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }  
            command = "exec spXoaPhieuNhap @maPhieuNhap";
            try
            {
                Database.Execute(command, parameter);             
                loadDgvPhieuNhap();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void but_dong_Click(object sender, EventArgs e)
        {
            if (this.TopLevel == false)
                ((TabControl)this.Parent.Parent).TabPages.Remove((TabPage)this.Parent);
            else
                this.Close();
        }
    }
}
