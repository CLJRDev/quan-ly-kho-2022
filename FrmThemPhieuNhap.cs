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
    public partial class FrmThemPhieuNhap : Form
    {
        private string selectedMaKho = "";
        private DataTable chiTietPhieuNhaps;
        private bool checkPieuNhap()
        {
            bool result = true;
            string nguoiGiaoHang = txt_nguoiGiaoHang.Text.Trim();
            string nguonNhap = txt_nguonNhap.Text.Trim();
            erroMes.Clear();
            if(nguoiGiaoHang == "" || nguoiGiaoHang.Length > 50)
            {
                result = false;
                erroMes.SetError(txt_nguoiGiaoHang, "Lỗi định dạng người giao hàng");
            }
            if(nguonNhap == "" || nguonNhap.Length > 100)
            {
                result = false;
                erroMes.SetError(txt_nguonNhap, "Lỗi định dạng nguồn nhập");
            }
            status.Text = "Thông báo: Lỗi cập nhập dữ liệu";
            return result;
        }
        private bool checkChiTietPhieuNhap()
        {
            bool result = true;
            erroMes.Clear();            
            if (String.IsNullOrEmpty(txt_donGia.Text))
            {
                erroMes.SetError(txt_donGia, "Đơn giá phải lớn hơn 0");
                result = false;
            }
            if(String.IsNullOrEmpty(txt_chietKhau.Text))
            {
                erroMes.SetError(txt_chietKhau, "Chiết khấu phải lớn hơn 0");
                result = false;
            }
            if(String.IsNullOrEmpty(txt_soLuong.Text))
            {
                erroMes.SetError(txt_soLuong, "Số lượng phải lớn hơn 0");
                result = false;
            }
            status.Text = "Thông báo: Lỗi cập nhập dữ liệu";
            return result;
        }
        private void loadMaKho()
        {
            string strSelect = "select * from Kho";
            DataTable table = Database.Query(strSelect, new Dictionary<string, object>());
            cbb_maKho.DataSource = table;
        }
        private void loadMaLoaiHang()
        {
            cbb_loaiHang.DataSource = Database.Query("select * from LoaiHang", new Dictionary<string, object>());
        }
        public FrmThemPhieuNhap()
        {
            InitializeComponent();
            dgv_chiTietPhieuNhap.AutoGenerateColumns = false;
            chiTietPhieuNhaps = new DataTable();
            chiTietPhieuNhaps.Columns.Add("MaHangHoa");
            chiTietPhieuNhaps.Columns.Add("TenHangHoa");
            chiTietPhieuNhaps.Columns.Add("MaDonViTinh");
            chiTietPhieuNhaps.Columns.Add("TenDonViTinh");
            chiTietPhieuNhaps.Columns.Add("SoLuong");
            chiTietPhieuNhaps.Columns.Add("DonGia");
            chiTietPhieuNhaps.Columns.Add("ChietKhau");
            loadMaLoaiHang();
            loadMaKho();
            //loadMaHangHoa();
        }

        public FrmThemPhieuNhap(string selectedMaKho)
        {
            InitializeComponent();
            dgv_chiTietPhieuNhap.AutoGenerateColumns = false;
            chiTietPhieuNhaps = new DataTable();
            chiTietPhieuNhaps.Columns.Add("MaHangHoa");
            chiTietPhieuNhaps.Columns.Add("TenHangHoa");
            chiTietPhieuNhaps.Columns.Add("MaDonViTinh");
            chiTietPhieuNhaps.Columns.Add("TenDonViTinh");
            chiTietPhieuNhaps.Columns.Add("SoLuong");
            chiTietPhieuNhaps.Columns.Add("DonGia");
            chiTietPhieuNhaps.Columns.Add("ChietKhau");
            loadMaLoaiHang();
            loadMaKho();
            cbb_maKho.SelectedValue = selectedMaKho;
        }

        private void but_them_Click(object sender, EventArgs e)
        {
            if (this.checkChiTietPhieuNhap() == false)
                return;
            for(int i = 0; i < dgv_chiTietPhieuNhap.Rows.Count; i++)
            {
                if(cbb_maHangHoa.SelectedValue.ToString() == chiTietPhieuNhaps.Rows[i]["MaHangHoa"].ToString() && cbb_maDonViTinh.SelectedValue.ToString() == chiTietPhieuNhaps.Rows[i]["MaDonViTinh"].ToString())
                    return;
            }
            DataRow chiTietPhieuNhap = chiTietPhieuNhaps.NewRow();
            chiTietPhieuNhap["MaHangHoa"] = cbb_maHangHoa.SelectedValue.ToString();
            chiTietPhieuNhap["TenHangHoa"] = cbb_maHangHoa.Text;
            chiTietPhieuNhap["MaDonViTinh"] = cbb_maDonViTinh.SelectedValue.ToString();
            chiTietPhieuNhap["TenDonViTinh"] = cbb_maDonViTinh.Text;
            chiTietPhieuNhap["SoLuong"] = Convert.ToDouble(txt_soLuong.Text);
            chiTietPhieuNhap["DonGia"] = Convert.ToDouble(txt_donGia.Text);
            chiTietPhieuNhap["ChietKhau"] = Convert.ToDouble(txt_chietKhau.Text);
            chiTietPhieuNhaps.Rows.Add(chiTietPhieuNhap);
            dgv_chiTietPhieuNhap.DataSource = chiTietPhieuNhaps;
            but_xoa.Enabled = dgv_chiTietPhieuNhap.Rows.Count > 0;
            status.Text = "Thông báo: Cập nhập dữ liệu thành công";
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            int index = dgv_chiTietPhieuNhap.CurrentRow.Index;
            chiTietPhieuNhaps.Rows.RemoveAt(index);
            dgv_chiTietPhieuNhap.DataSource = chiTietPhieuNhaps;
            but_xoa.Enabled = dgv_chiTietPhieuNhap.Rows.Count > 0;
        }

        private void but_luu_Click(object sender, EventArgs e)
        {
            //Buoc 1: them phieu nhap
            if (this.checkPieuNhap() == false || dgv_chiTietPhieuNhap.Rows.Count == 0)
                return;
            string strCommand = "exec spThemPhieuNhap @ngayNhap,@nguoiGiaoHang,@nguonNhap,@maKho,@ghiChu";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@ngayNhap", dtp_ngayNhap.Value);
            parameter.Add("@nguoiGiaoHang", txt_nguoiGiaoHang.Text);
            parameter.Add("@nguonNhap", txt_nguonNhap.Text);
            parameter.Add("@maKho", cbb_maKho.SelectedValue);
            parameter.Add("@ghiChu", txt_ghiChu.Text);
            Database.Execute(strCommand, parameter);
            //Buoc 2: them n hang hoa vao bang chi tiet phieu nhap
            string strInsert = "exec spThemChiTietPhieuNhap @maHangHoa,@maDonViTinh,@soLuong,@donGia,@chietKhau";
            for(int i = 0; i < chiTietPhieuNhaps.Rows.Count; i++)
            {
                parameter.Clear();           
                parameter.Add("@maHangHoa", chiTietPhieuNhaps.Rows[i]["MaHangHoa"]);
                parameter.Add("@maDonViTinh", chiTietPhieuNhaps.Rows[i]["MaDonViTinh"]);
                parameter.Add("@soLuong", Convert.ToDouble(chiTietPhieuNhaps.Rows[i]["SoLuong"]));
                parameter.Add("@donGia", Convert.ToDouble(chiTietPhieuNhaps.Rows[i]["DonGia"]));
                parameter.Add("@chietKhau", Convert.ToDouble(chiTietPhieuNhaps.Rows[i]["ChietKhau"]));
                Database.Execute(strInsert, parameter);                
            }
            status.Text = "Thông báo: Cập nhập dữ liệu thành công";
            this.Close();
        }

        private void txt_donGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_chietKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_soLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void but_loaiHang_Click(object sender, EventArgs e)
        {
            FrmQuanLyLoaiHang form = new FrmQuanLyLoaiHang();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void but_hangHoa_Click(object sender, EventArgs e)
        {
            FrmQuanLyHangHoa form = new FrmQuanLyHangHoa();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
        private void cbb_loaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_loaiHang.Text != "")
            {
                string strSelect = "select * from dbo.ufLayHangHoaTheoMaLoaiHang(@maLoaiHang)";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                parameter.Add("@maLoaiHang", cbb_loaiHang.SelectedValue);
                cbb_maHangHoa.DataSource = Database.Query(strSelect, parameter);
            }
        }
        private void cbb_maHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_maHangHoa.Text != "")
            {
                string strSelect = "select * from dbo.ufLayDonViTinhTheoMaHangHoa(@maHangHoa)";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                parameter.Add("@maHangHoa", cbb_maHangHoa.SelectedValue);
                cbb_maDonViTinh.DataSource = Database.Query(strSelect, parameter);
            }
        }
        private void but_donViTinh_Click(object sender, EventArgs e)
        {
            FrmQuanLyDonViTinh form = new FrmQuanLyDonViTinh();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void cbb_maKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMaKho = cbb_maKho.SelectedValue.ToString();
        }
    }
}
