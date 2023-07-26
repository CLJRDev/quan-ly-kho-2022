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
    public partial class FrmSuaPhieuXuat : Form
    {
        private DataTable chiTietXoas;
        private DataTable chiTietThems;
        private DataTable chiTietHangHoas;
        private int maPhieuXuat;
        private bool checkPhieuXuat()
        {
            bool result = true;
            string nguoiNhanHang = txt_nguoiNhanHang.Text.Trim();
            string noiNhan = txt_noiNhan.Text.Trim();
            erroMes.Clear();
            if (nguoiNhanHang == "" || nguoiNhanHang.Length > 50)
            {
                result = false;
                erroMes.SetError(txt_nguoiNhanHang, "Lỗi định dạng người nhận hàng");
            }
            if (noiNhan == "" || noiNhan.Length > 100)
            {
                result = false;
                erroMes.SetError(txt_noiNhan, "Lỗi định dạng nơi nhận");
            }
            status.Text = "Thông báo: Lỗi cập nhập dữ liệu";
            return result;
        }
        private bool checkChiTietPhieuXuat()
        {
            bool result = true;
            erroMes.Clear();
            if (String.IsNullOrEmpty(txt_donGia.Text))
            {
                erroMes.SetError(txt_donGia, "Đơn giá phải lớn hơn 0");
                result = false;
            }
            if (String.IsNullOrEmpty(txt_chietKhau.Text))
            {
                erroMes.SetError(txt_chietKhau, "Không được để trống");
                result = false;
            }
            if (String.IsNullOrEmpty(txt_soLuong.Text))
            {
                erroMes.SetError(txt_soLuong, "Số lượng phải lớn hơn 0");
                result = false;
            }
            status.Text = "Thông báo: Lỗi cập nhập dữ liệu";
            return result;
        }
        public FrmSuaPhieuXuat(int maPhieuXuat)
        {
            InitializeComponent();
            dgv_chiTietPhieuXuat.AutoGenerateColumns = false;
            chiTietThems = new DataTable();
            chiTietThems.Columns.Add("MaHangHoa");
            chiTietThems.Columns.Add("MaDonViTinh");
            chiTietThems.Columns.Add("SoLuong");
            chiTietThems.Columns.Add("DonGia");
            chiTietThems.Columns.Add("ChietKhau");
            chiTietXoas = new DataTable();
            chiTietXoas.Columns.Add("MaHangHoa");
            chiTietXoas.Columns.Add("MaDonViTinh");
            this.maPhieuXuat = maPhieuXuat;
            loadCbbLoaiHang();
            loadDgvChiTietPhieuXuat();
        }
        private void loadDgvChiTietPhieuXuat()
        {
            string command = "select * from dbo.ufLayChiTietPhieuXuat(@maPhieuXuat)";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maPhieuXuat", maPhieuXuat);
            dgv_chiTietPhieuXuat.DataSource = Database.Query(command, parameter);
            chiTietHangHoas = Database.Query(command, parameter);
        }
        private void loadCbbLoaiHang()
        {
            cbb_loaiHang.DataSource = Database.Query("select * from LoaiHang", new Dictionary<string, object>());
        }

        private void cbb_loaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string command = "select * from dbo.ufLayHangHoaTheoMaLoaiHang(@maLoaiHang)";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maLoaiHang", cbb_loaiHang.SelectedValue);
            cbb_hangHoa.DataSource = Database.Query(command, parameter);
        }

        private void cbb_hangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string command = "select * from dbo.ufLayDonViTinhCuaHangHoa(@maHangHoa)";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maHangHoa", cbb_hangHoa.SelectedValue);
            cbb_donViTinh.DataSource = Database.Query(command, parameter);
        }

        private void but_them_Click(object sender, EventArgs e)
        {
            if (this.checkChiTietPhieuXuat() == false)
                return;
            for (int i = 0; i < dgv_chiTietPhieuXuat.Rows.Count; i++)
            {
                if (cbb_hangHoa.SelectedValue.ToString() == chiTietHangHoas.Rows[i]["MaHangHoa"].ToString() && cbb_donViTinh.SelectedValue.ToString() == chiTietHangHoas.Rows[i]["MaDonViTinh"].ToString())
                    return;
            }
            DataRow chiTietThem = chiTietThems.NewRow();
            chiTietThem["MaHangHoa"] = cbb_hangHoa.SelectedValue;
            chiTietThem["MaDonViTinh"] = cbb_donViTinh.SelectedValue;
            chiTietThem["SoLuong"] = txt_soLuong.Text;
            chiTietThem["DonGia"] = txt_donGia.Text;
            chiTietThem["ChietKhau"] = txt_chietKhau.Text;
            chiTietThems.Rows.Add(chiTietThem);
            DataRow chiTietHangHoa = chiTietHangHoas.NewRow();
            chiTietHangHoa["MaHangHoa"] = cbb_hangHoa.SelectedValue;
            chiTietHangHoa["TenHangHoa"] = cbb_hangHoa.Text;
            chiTietHangHoa["MaDonViTinh"] = cbb_donViTinh.SelectedValue;
            chiTietHangHoa["TenDonViTinh"] = cbb_donViTinh.Text;
            chiTietHangHoa["SoLuong"] = txt_soLuong.Text;
            chiTietHangHoa["DonGia"] = txt_donGia.Text;
            chiTietHangHoa["ChietKhau"] = txt_chietKhau.Text;
            chiTietHangHoas.Rows.Add(chiTietHangHoa);
            dgv_chiTietPhieuXuat.DataSource = chiTietHangHoas;
            but_xoa.Enabled = dgv_chiTietPhieuXuat.Rows.Count > 0;
            status.Text = "Thông báo: Cập nhập dữ liệu thành công";
        }

        private void but_luu_Click(object sender, EventArgs e)
        {
            if (this.checkPhieuXuat() == false)
                return;
            //Sua phieu xuat
            string command = "exec spSuaPhieuXuat @maPhieuXuat, @ngayXuat, @nguoiNhanHang, @NoiNhan, @ghiChu";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maPhieuXuat", maPhieuXuat);
            parameter.Add("@ngayXuat", dtp_ngayXuat.Value);
            parameter.Add("@nguoiNhanHang", txt_nguoiNhanHang.Text);
            parameter.Add("@NoiNhan", txt_noiNhan.Text);
            parameter.Add("@ghiChu", txt_ghiChu.Text);
            Database.Execute(command, parameter);
            //Xoa n hang hoa da xoa o chi tiet phieu xuat
            command = "exec spXoaChiTietPhieuXuat @maPhieuXuat,@maHangHoa, @maDonViTinh";
            for (int i = 0; i < chiTietXoas.Rows.Count; i++)
            {
                parameter.Clear();
                parameter.Add("@maPhieuXuat", this.maPhieuXuat);
                parameter.Add("@maHangHoa", chiTietXoas.Rows[i]["MaHangHoa"].ToString());
                parameter.Add("@maDonViTinh", chiTietXoas.Rows[i]["MaDonViTinh"].ToString());
                try
                {
                    Database.Execute(command, parameter);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    status.Text = "Thông báo: Cập nhập dữ liệu thất bại";
                }
            }
            //Them n hang hoa đã thêm ở chi tiết phiếu xuất
            command = "exec spThemChiTietPhieuXuatDuocSua @maPhieuXuat,@maHangHoa,@maDonViTinh,@soLuong,@donGia,@chietKhau";
            for (int i = 0; i < chiTietThems.Rows.Count; i++)
            {
                parameter.Clear();
                parameter.Add("@maPhieuXuat", this.maPhieuXuat);
                parameter.Add("@maHangHoa", chiTietThems.Rows[i]["MaHangHoa"].ToString());
                parameter.Add("@maDonViTinh", chiTietThems.Rows[i]["MaDonViTinh"].ToString());
                parameter.Add("@soLuong", chiTietThems.Rows[i]["SoLuong"].ToString());
                parameter.Add("@donGia", chiTietThems.Rows[i]["DonGia"].ToString());
                parameter.Add("@chietKhau", chiTietThems.Rows[i]["ChietKhau"].ToString());
                Database.Execute(command, parameter);
            }
            status.Text = "Thông báo: Cập nhập dữ liệu thành công";
            this.Close();
        }

        private void dgv_chiTietPhieuXuat_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txt_chietKhau.Text = dgv_chiTietPhieuXuat.Rows[e.RowIndex].Cells["ChietKhau"].Value.ToString();
                txt_donGia.Text = dgv_chiTietPhieuXuat.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
                txt_soLuong.Text = dgv_chiTietPhieuXuat.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
            }
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            DataRow chiTietXoa = chiTietXoas.NewRow();
            chiTietXoa["MaHangHoa"] = dgv_chiTietPhieuXuat.CurrentRow.Cells["MaHangHoa"].Value.ToString();
            chiTietXoa["MaDonViTinh"] = dgv_chiTietPhieuXuat.CurrentRow.Cells["MaDonViTinh"].Value.ToString();
            chiTietXoas.Rows.Add(chiTietXoa);
            int index = dgv_chiTietPhieuXuat.CurrentRow.Index;
            chiTietHangHoas.Rows.RemoveAt(index);
            dgv_chiTietPhieuXuat.DataSource = chiTietHangHoas;
            but_xoa.Enabled = dgv_chiTietPhieuXuat.Rows.Count > 0;
        }

        private void txt_donGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_soLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_chietKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void FrmSuaPhieuXuat_Load(object sender, EventArgs e)
        {
            string command = "select * from PhieuXuat where MaPhieuXuat = @maPhieuXuat";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maPhieuXuat", this.maPhieuXuat);
            DataTable phieuXuat = Database.Query(command, parameter);
            dtp_ngayXuat.Value = (DateTime)phieuXuat.Rows[0]["NgayXuat"];
            txt_noiNhan.Text = phieuXuat.Rows[0]["NoiNhan"].ToString();
            txt_nguoiNhanHang.Text = phieuXuat.Rows[0]["NguoiNhanHang"].ToString();
            txt_ghiChu.Text = phieuXuat.Rows[0]["GhiChu"].ToString();
            command = "select TenKho from Kho where MaKho = @maKho";
            parameter.Clear();
            parameter.Add("@maKho", phieuXuat.Rows[0]["MaKho"].ToString());
            string tenKho = Database.Query(command, parameter).Rows[0][0].ToString();
            txt_kho.Text = tenKho;
        }

        private void but_loaiHang_Click(object sender, EventArgs e)
        {
            FrmQuanLyLoaiHang form = new FrmQuanLyLoaiHang();
            form.ShowDialog();
        }

        private void but_hangHoa_Click(object sender, EventArgs e)
        {
            FrmQuanLyHangHoa form = new FrmQuanLyHangHoa();
            form.ShowDialog();
        }

        private void but_donViTinh_Click(object sender, EventArgs e)
        {
            FrmQuanLyDonViTinh form = new FrmQuanLyDonViTinh();
            form.ShowDialog();
        }
    }
}
