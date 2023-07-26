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
    public partial class FrmQuanLyPhieuXuat : Form
    {
        public FrmQuanLyPhieuXuat()
        {
            InitializeComponent();
            dtp_ngayXuatTu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtp_ngayXuatDen.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            load_ccbKho();
            load_cbbHangHoa();
            load_dgvPhieuXuat();
        }
        private void load_ccbKho()
        {
            string select = "select * from Kho";
            DataTable table = Database.Query(select, new Dictionary<string, object>());
            cbb_kho.DataSource = table;
        }
        private void load_cbbHangHoa()
        {
            cbb_hangHoa.DataSource = Database.Query("select * from HangHoa", new Dictionary<string, object>());
        }
        public void load_dgvPhieuXuat()
        {
            string command = "select * from dbo.ufTimKiemPhieuXuat(@maPhieuXuat,@ngayXuatTu,@ngayXuatDen,@nguoiNhanHang,@noiNhan,@maKho,@thuKho,@ghiChu,@maHangHoa,@maDonViTinh,@soLuong,@donGia,@chietKhau)";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            if (ck_maPhieuXuat.Checked)
            {
                parameter.Add("@maPhieuXuat", txt_maPhieuXuat.Text);
            }
            else
            {
                parameter.Add("@maPhieuXuat", "");
            }
            if (ck_ngayXuatTu.Checked)
            {
                parameter.Add("@ngayXuatTu", dtp_ngayXuatTu.Value);
            }
            else
            {
                parameter.Add("@ngayXuatTu", "");
            }
            if (ck_ngayXuatDen.Checked)
            {
                parameter.Add("@ngayXuatDen", dtp_ngayXuatDen.Value);
            }
            else
            {
                parameter.Add("@ngayXuatDen", dtp_ngayXuatDen.Value);
            }
            if (ck_nguoiNhanHang.Checked)
            {
                parameter.Add("@nguoiNhanHang", txt_nguoiNhanHang.Text);
            }
            else
            {
                parameter.Add("@nguoiNhanHang", "");
            }
            if (ck_noiNhan.Checked)
            {
                parameter.Add("@noiNhan", txt_noiNhan.Text);
            }
            else
            {
                parameter.Add("@noiNhan", "");
            }
            if (ck_maKho.Checked)
            {
                parameter.Add("@maKho", cbb_kho.SelectedValue);
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
            dgv_phieuXuat.DataSource = Database.Query(command, parameter);
            but_sua.Enabled = tv_chiTietPhieuXuat.Visible = but_xoa.Enabled = dgv_phieuXuat.Rows.Count > 0;
        }

        private void but_them_Click(object sender, EventArgs e)
        {
            FrmThemPhieuXuat form = new FrmThemPhieuXuat();
            form.ShowDialog();
            load_dgvPhieuXuat();
        }

        private void ck_maPhieuXuat_CheckedChanged(object sender, EventArgs e)
        {
            txt_maPhieuXuat.Enabled = ck_maPhieuXuat.Checked;
        }

        private void ck_ngayXuatTu_CheckedChanged(object sender, EventArgs e)
        {
            dtp_ngayXuatTu.Enabled = ck_ngayXuatTu.Checked;
        }

        private void ck_ngayXuatDen_CheckedChanged(object sender, EventArgs e)
        {
            dtp_ngayXuatDen.Enabled = ck_ngayXuatDen.Checked;
        }

        private void ck_nguoiNhanHang_CheckedChanged(object sender, EventArgs e)
        {
            txt_nguoiNhanHang.Enabled = ck_nguoiNhanHang.Checked;
        }

        private void ck_noiNhan_CheckedChanged(object sender, EventArgs e)
        {
            txt_noiNhan.Enabled = ck_noiNhan.Checked;
        }

        private void ck_maKho_CheckedChanged(object sender, EventArgs e)
        {
            cbb_kho.Enabled = ck_maKho.Checked;
        }

        private void ck_thuKho_CheckedChanged(object sender, EventArgs e)
        {
            txt_thuKho.Enabled = ck_thuKho.Checked;
        }

        private void ck_ghiChu_CheckedChanged(object sender, EventArgs e)
        {
            txt_ghiChu.Enabled = ck_ghiChu.Checked;
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

        private void ck_timKiem_CheckedChanged(object sender, EventArgs e)
        {
            but_timKiem.Enabled = ck_timKiem.Checked;
        }

        private void ck_hienThiNguoiNhanHang_CheckedChanged(object sender, EventArgs e)
        {
            dgv_phieuXuat.Columns["NguoiNhanHang"].Visible = ck_hienThiNguoiNhanHang.Checked;
        }

        private void ck_hienThiNoiNhan_CheckedChanged(object sender, EventArgs e)
        {
            dgv_phieuXuat.Columns["NoiNhan"].Visible = ck_hienThiNoiNhan.Checked;
        }

        private void ck_hienThiKho_CheckedChanged(object sender, EventArgs e)
        {
            dgv_phieuXuat.Columns["TenKho"].Visible = ck_hienThiKho.Checked;
        }

        private void ck_hienThiThuKho_CheckedChanged(object sender, EventArgs e)
        {
            dgv_phieuXuat.Columns["ThuKho"].Visible = ck_hienThiThuKho.Checked;
        }

        private void ck_hienThiGhiChu_CheckedChanged(object sender, EventArgs e)
        {
            dgv_phieuXuat.Columns["GhiChu"].Visible = ck_hienThiGhiChu.Checked;
        }
        private void dgv_phieuXuat_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy ra mã phiếu xuất của phiếu đang chọn
            int maPhieuXuat = (int)dgv_phieuXuat.Rows[e.RowIndex].Cells["MaPhieuXuat"].Value;
            //Lấy ra các chi tiết phiếu xuất có mã phiếu ứng với mã phiếu xuất vừa lấy
            string command = "select * from dbo.ufLayChiTietPhieuXuat(@maPhieuXuat)";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maPhieuXuat", maPhieuXuat);
            DataTable chiTietPhieuXuats = Database.Query(command, parameter);
            //Đẩy tất cả các chi tiết đó vào tree view
            tv_chiTietPhieuXuat.Nodes.Clear();
            for (int i = 0; i < chiTietPhieuXuats.Rows.Count; i++)
            {
                TreeNode node = new TreeNode(chiTietPhieuXuats.Rows[i]["TenHanghoa"].ToString());
                node.Nodes.Add("Số lượng: " + chiTietPhieuXuats.Rows[i]["SoLuong"].ToString() + " " + chiTietPhieuXuats.Rows[i]["TenDonViTinh"].ToString());
                node.Nodes.Add("Đơn giá: " + chiTietPhieuXuats.Rows[i]["DonGia"].ToString());
                node.Nodes.Add("Chiết khấu: " + chiTietPhieuXuats.Rows[i]["ChietKhau"].ToString());
                node.Expand();
                tv_chiTietPhieuXuat.Nodes.Add(node);
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
            int maPhieuXuat = (int)dgv_phieuXuat.CurrentRow.Cells["MaPhieuXuat"].Value;
            FrmSuaPhieuXuat form = new FrmSuaPhieuXuat(maPhieuXuat);
            form.ShowDialog();
            load_dgvPhieuXuat();
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            string command = "select * from dbo.ufLayChiTietPhieuXuat(@maPhieuXuat)";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maPhieuXuat", (int)dgv_phieuXuat.CurrentRow.Cells["MaPhieuXuat"].Value);
            DataTable chiTietPhieuXuat = Database.Query(command, parameter);
            command = "exec spXoaChiTietPhieuXuat @maPhieuXuat,@maHangHoa,@maDonViTinh";
            for (int i = 0; i < chiTietPhieuXuat.Rows.Count; i++)
            {
                parameter.Clear();
                parameter.Add("@maPhieuXuat", (int)dgv_phieuXuat.CurrentRow.Cells["MaPhieuXuat"].Value);
                parameter.Add("@maHangHoa", chiTietPhieuXuat.Rows[i]["MaHangHoa"].ToString());
                parameter.Add("@maDonViTinh", chiTietPhieuXuat.Rows[i]["MaDonViTInh"].ToString());
                try
                {
                    Database.Execute(command, parameter);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            command = "exec spXoaPhieuXuat @maPhieuXuat";
            try
            {
                Database.Execute(command, parameter);
                load_dgvPhieuXuat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void but_timKiem_Click(object sender, EventArgs e)
        {
            load_dgvPhieuXuat();
        }

        private void but_dong_Click(object sender, EventArgs e)
        {
            if (this.TopLevel == false)
                ((TabControl)this.Parent.Parent).TabPages.Remove((TabPage)this.Parent);
            else
                this.Close();
        }

        private void cbb_hangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_hangHoa.SelectedIndex != -1)
            {
                string commnad = "select * from dbo.ufLayDonViTinhCuaHangHoa(@maHangHoa)";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                parameter.Add("@maHangHoa", cbb_hangHoa.SelectedValue);
                cbb_donViTinh.DataSource = Database.Query(commnad, parameter);
            }
        }
    }
}
