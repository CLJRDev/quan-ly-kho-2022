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
    public partial class FrmThemPhieuXuat : Form
    {
        private DataTable chiTietPhieuXuats;
        public FrmThemPhieuXuat()
        {
            InitializeComponent();
            chiTietPhieuXuats = new DataTable();
            dgv_chiTietPhieuXuat.AutoGenerateColumns = false;
            chiTietPhieuXuats.Columns.Add("MaHangHoa");
            chiTietPhieuXuats.Columns.Add("TenHangHoa");
            chiTietPhieuXuats.Columns.Add("MaDonViTinh");
            chiTietPhieuXuats.Columns.Add("TenDonViTinh");
            chiTietPhieuXuats.Columns.Add("SoLuong");
            chiTietPhieuXuats.Columns.Add("DonGia");
            chiTietPhieuXuats.Columns.Add("ChietKhau");
            loadKho();
            loadLoaiHang();
            but_xoa.Enabled = dgv_chiTietPhieuXuat.Rows.Count > 0;
        }
        public FrmThemPhieuXuat(string selectedMaKho)
        {
            InitializeComponent();
            chiTietPhieuXuats = new DataTable();
            dgv_chiTietPhieuXuat.AutoGenerateColumns = false;
            chiTietPhieuXuats.Columns.Add("MaHangHoa");
            chiTietPhieuXuats.Columns.Add("TenHangHoa");
            chiTietPhieuXuats.Columns.Add("MaDonViTinh");
            chiTietPhieuXuats.Columns.Add("TenDonViTinh");
            chiTietPhieuXuats.Columns.Add("SoLuong");
            chiTietPhieuXuats.Columns.Add("DonGia");
            chiTietPhieuXuats.Columns.Add("ChietKhau");
            loadKho();
            loadLoaiHang();
            cbb_maKho.SelectedValue = selectedMaKho;
            but_xoa.Enabled = dgv_chiTietPhieuXuat.Rows.Count > 0;
        }
        private void loadKho()
        {
            cbb_maKho.DataSource = Database.Query("select * from Kho", new Dictionary<string, object>());
        }
        private void loadLoaiHang()
        {
            cbb_loaiHang.DataSource = Database.Query("select * from LoaiHang", new Dictionary<string, object>());
        }
        private void cbb_loaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_loaiHang.Text != "")
            {
                string strCommand = "select * from dbo.ufLayHangHoaTheoMaLoaiHang(@maLoaiHang)";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                parameter.Add("@maLoaiHang", cbb_loaiHang.SelectedValue);
                cbb_maHangHoa.DataSource = Database.Query(strCommand, parameter);
            }
        }
        private void cbb_maHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_maHangHoa.Text != "")
            {
                string strCommand = "select * from dbo.ufLayDonViTinhCuaHangHoa(@maHangHoa)";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                parameter.Add("@maHangHoa", cbb_maHangHoa.SelectedValue);
                cbb_maDonViTinh.DataSource = Database.Query(strCommand, parameter);
            }
        }
        private bool checkPhieuXuat()
        {
            bool result = true;
            erroMes.Clear();
            string noiNhan = txt_noiNhan.Text.Trim();
            string nguoiNhanHang = txt_nguoiNhanHang.Text.Trim();
            if(noiNhan == "" || noiNhan.Length > 100)
            {
                erroMes.SetError(txt_noiNhan, "Lỗi định dạng nơi nhận");
                result = false;
            }
            if(nguoiNhanHang.Length > 50 || nguoiNhanHang == "")
            {
                erroMes.SetError(txt_nguoiNhanHang, "Lỗi định dạng người nhận hàng");
                result = false;
            }
            status.Text = "Thông báo: Lỗi cập nhập dữ liệu";
            return result;
        }

        private bool checkChiTietPhieuXuat()
        {
            bool result = true;
            erroMes.Clear();
            if (String.IsNullOrEmpty(cbb_maHangHoa.Text))
            {
                erroMes.SetError(cbb_maHangHoa, "Thiếu mã hàng hoá");
                result = false;
            }
            if (String.IsNullOrEmpty(cbb_maDonViTinh.Text))
            {
                erroMes.SetError(cbb_maDonViTinh, "Thiếu đơn vị tính");
                result = false;
            }
            if (String.IsNullOrEmpty(txt_soLuong.Text))
            {
                erroMes.SetError(txt_soLuong, "Thiếu số lượng");
                result = false;
            }
            if (String.IsNullOrEmpty(txt_donGia.Text))
            {
                erroMes.SetError(txt_donGia, "Thiếu đơn giá");
                result = false;
            }
            if (String.IsNullOrEmpty(txt_chietKhau.Text))
            {
                erroMes.SetError(txt_chietKhau, "Thiếu chiết khấu");
                result = false;
            }
            status.Text = "Thông báo: Lỗi cập nhập dữ liệu";
            return result;
        }

        private void but_them_Click(object sender, EventArgs e)
        {
            if (this.checkChiTietPhieuXuat() == false)
                return;
            for (int i = 0; i < dgv_chiTietPhieuXuat.Rows.Count; i++)
            {
                if (cbb_maHangHoa.SelectedValue.ToString() == chiTietPhieuXuats.Rows[i]["MaHangHoa"].ToString() && cbb_maDonViTinh.SelectedValue.ToString() == chiTietPhieuXuats.Rows[i]["MaDonViTinh"].ToString())
                    return;
            }
            DataRow chiTietPhieuXuat = chiTietPhieuXuats.NewRow();
            chiTietPhieuXuat["MaHangHoa"] = cbb_maHangHoa.SelectedValue;
            chiTietPhieuXuat["TenHangHoa"] = cbb_maHangHoa.Text;
            chiTietPhieuXuat["MaDonViTinh"] = cbb_maDonViTinh.SelectedValue;
            chiTietPhieuXuat["TenDonViTinh"] = cbb_maDonViTinh.Text;
            chiTietPhieuXuat["SoLuong"] = Convert.ToDouble(txt_soLuong.Text);
            chiTietPhieuXuat["DonGia"] = Convert.ToDouble(txt_donGia.Text);
            chiTietPhieuXuat["ChietKhau"] = Convert.ToDouble(txt_chietKhau.Text);
            chiTietPhieuXuats.Rows.Add(chiTietPhieuXuat);
            dgv_chiTietPhieuXuat.DataSource = chiTietPhieuXuats;
            but_xoa.Enabled = dgv_chiTietPhieuXuat.Rows.Count > 0;
            status.Text = "Thông báo: Cập nhập dữ liệu thành công";
        }

        private void but_luu_Click(object sender, EventArgs e)
        {
            if (this.checkPhieuXuat() == false || dgv_chiTietPhieuXuat.Rows.Count < 1)
                return;
            //Them phieu xuat               
            string strCommand = "exec spThemPhieuXuat @ngayXuat,@nguoiNhanHang,@noiNhan,@maKho,@ghiChu";
            Dictionary<string, object> parameter = new Dictionary<string, object>();          
            parameter.Add("@ngayXuat", dtp_ngayXuat.Value);
            parameter.Add("@nguoiNhanHang", txt_nguoiNhanHang.Text);
            parameter.Add("@noiNhan", txt_noiNhan.Text);
            parameter.Add("@maKho", cbb_maKho.SelectedValue);
            parameter.Add("@ghiChu", txt_ghiChu.Text);
            Database.Execute(strCommand, parameter);
            //Them n chi tiet phieu xuat
            strCommand = "exec spThemChiTietPhieuXuat @maHangHoa,@maDonViTinh,@soLuong,@donGia,@chietKhau";
            for(int i = 0; i < chiTietPhieuXuats.Rows.Count; i++)
            {
                parameter.Clear();
                parameter.Add("@maHangHoa", chiTietPhieuXuats.Rows[i]["MaHangHoa"]);
                parameter.Add("@maDonViTinh", chiTietPhieuXuats.Rows[i]["MaDonViTinh"]);
                parameter.Add("@soLuong", Convert.ToDouble(chiTietPhieuXuats.Rows[i]["SoLuong"]));
                parameter.Add("@donGia", Convert.ToDouble(chiTietPhieuXuats.Rows[i]["DonGia"]));
                parameter.Add("@chietKhau", Convert.ToDouble(chiTietPhieuXuats.Rows[i]["ChietKhau"]));
                try
                {
                    Database.Execute(strCommand, parameter);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            this.Close();
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            int index = dgv_chiTietPhieuXuat.CurrentRow.Index;
            chiTietPhieuXuats.Rows.RemoveAt(index);
            dgv_chiTietPhieuXuat.DataSource = chiTietPhieuXuats;
            but_xoa.Enabled = dgv_chiTietPhieuXuat.Rows.Count > 0;
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

        private void txt_soLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
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

        private void but_donViTinh_Click(object sender, EventArgs e)
        {
            FrmQuanLyDonViTinh form = new FrmQuanLyDonViTinh();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
    }
}
