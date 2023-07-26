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
    public partial class FrmQuanLyNguoiDung : Form
    {
        public FrmQuanLyNguoiDung()
        {
            InitializeComponent();
            load_dgvNguoiDung();
        }
        public void load_dgvNguoiDung()
        {
            string strCommand = "select TenDangNhap,TrangThai from NguoiDung";
            dgv_nguoiDung.DataSource = Database.Query(strCommand, new Dictionary<string, object>());
        }
        
        private void lamMoi()
        {
            ck_quanLyKiemKho.Checked = ck_quanLyNguoiDung.Checked = ck_quanLyLoaiHang.Checked = ck_quanLyKho.Checked = ck_quanLyHangHoa.Checked = ck_quanLyPhieuNhap.Checked = ck_quanLyPhieuXuat.Checked = ck_quanLyDonViTinh.Checked = false;
            txt_tenDangNhap.Text = txt_matKhau1.Text = txt_matKhau2.Text = "";
            rb_true.Checked = true;
            status.Text = "Thông báo:";
            errorMess.Clear();
        }
        private bool checkTaoTaiKhoan()
        {
            bool result = true;
            errorMess.Clear();
            if(txt_tenDangNhap.Text.Trim().Length > 30 || txt_tenDangNhap.Text == "")
            {
                errorMess.SetError(txt_tenDangNhap, "Loi dinh dang ten dang nhap");
                result = false;
            }
            if (txt_matKhau1.Text.Trim().Length > 128 || txt_matKhau1.Text == "")
            {
                errorMess.SetError(txt_matKhau1, "Loi dinh dang mat khau");
                result = false;
            }
            if (txt_matKhau2.Text.Trim().Length > 128 || txt_matKhau2.Text == "")
            {
                errorMess.SetError(txt_matKhau2, "Loi dinh dang mat khau");
                result = false;
            }
            if(String.Compare(txt_matKhau1.Text,txt_matKhau2.Text) != 0)
            {
                errorMess.SetError(txt_matKhau2, "Mat khau chua khop");
                result = false;
            }
            status.Text = "Thông báo: Lỗi cập nhập dữ liệu";
            return result;
        }
        private bool checkDoiMatKhau()
        {
            bool result = true;
            if (txt_matKhau1.Text.Trim().Length > 128 || txt_matKhau1.Text == "")
            {
                errorMess.SetError(txt_matKhau1, "Loi dinh dang mat khau");
                result = false;
            }
            if (txt_matKhau2.Text.Trim().Length > 128 || txt_matKhau2.Text == "")
            {
                errorMess.SetError(txt_matKhau2, "Loi dinh dang mat khau");
                result = false;
            }
            if (String.Compare(txt_matKhau1.Text, txt_matKhau2.Text) != 0)
            {
                errorMess.SetError(txt_matKhau2, "Mat khau chua khop");
                result = false;
            }
            status.Text = "Thông báo: Lỗi cập nhập dữ liệu";
            return result;
        }
        private void but_themTaiKhoan_Click(object sender, EventArgs e)
        {
            if(checkTaoTaiKhoan() == false)
                return;
            string strCommand = "exec spThemNguoiDung @tenDangNhap,@matKhau,@trangThai";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            bool trangThai = rb_true.Checked ? true : false;
            parameter.Add("@tenDangNhap", txt_tenDangNhap.Text);
            parameter.Add("@matKhau", txt_matKhau2.Text);
            parameter.Add("@trangThai", trangThai);          
            try
            {
                Database.Execute(strCommand, parameter);
                List<int> maChucNang = new List<int>();
                if (ck_quanLyLoaiHang.Checked)
                    maChucNang.Add(1);
                if (ck_quanLyDonViTinh.Checked)
                    maChucNang.Add(2);
                if (ck_quanLyKho.Checked)
                    maChucNang.Add(3);
                if (ck_quanLyPhieuNhap.Checked)
                    maChucNang.Add(4);
                if (ck_quanLyPhieuXuat.Checked)
                    maChucNang.Add(5);
                if (ck_quanLyNguoiDung.Checked)
                    maChucNang.Add(6);
                if (ck_quanLyHangHoa.Checked)
                    maChucNang.Add(7);
                if (ck_quanLyKiemKho.Checked)
                    maChucNang.Add(9);
                if(maChucNang.Count > 0)
                {
                    strCommand = "exec spPhanQuyen @tenDangNhap, @maChucNang";
                    foreach (int index in maChucNang)
                    {
                        parameter.Clear();
                        parameter.Add("@tenDangNhap", txt_tenDangNhap.Text);
                        parameter.Add("@maChucNang", index);
                        Database.Execute(strCommand, parameter);
                    }
                }             
                load_dgvNguoiDung();
                lamMoi();
                status.Text = "Thông báo: Cập nhập dữ liệu thành công";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void but_suaTaiKhoan_Click(object sender, EventArgs e)
        {
            string command = "exec spDoiMatKhau @tenDangNhap, @matKhau";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            if (!String.IsNullOrEmpty(txt_matKhau1.Text))
            {
                DialogResult result = MessageBox.Show("Xác nhận thay đổi mật khẩu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result != DialogResult.OK)
                    return;
                if (this.checkDoiMatKhau() == false)
                    return;
                parameter.Add("@tenDangNhap", dgv_nguoiDung.CurrentRow.Cells["TenDangNhap"].Value.ToString());
                parameter.Add("@matKhau", txt_matKhau1.Text);
                Database.Execute(command, parameter);
            }
            parameter.Clear();
            command = "exec spDoiTrangThai @tenDangNhap, @trangThai";
            bool trangThai = rb_true.Checked ? true : false;
            parameter.Add("@tenDangNhap", dgv_nguoiDung.CurrentRow.Cells["TenDangNhap"].Value.ToString());
            parameter.Add("@trangThai", trangThai);
            Database.Execute(command, parameter);
            dgv_nguoiDung.CurrentRow.Cells["TrangThai"].Value = trangThai;
            if (trangThai == false)
                return;
            List<int> maChucNangCheck = new List<int>();
            if (ck_quanLyLoaiHang.Checked)
                maChucNangCheck.Add(1);
            if (ck_quanLyDonViTinh.Checked)
                maChucNangCheck.Add(2);
            if (ck_quanLyKho.Checked)
                maChucNangCheck.Add(3);
            if (ck_quanLyPhieuNhap.Checked)
                maChucNangCheck.Add(4);
            if (ck_quanLyPhieuXuat.Checked)
                maChucNangCheck.Add(5);
            if (ck_quanLyNguoiDung.Checked)
                maChucNangCheck.Add(6);
            if (ck_quanLyHangHoa.Checked)
                maChucNangCheck.Add(7);
            if (ck_quanLyKiemKho.Checked)
                maChucNangCheck.Add(9);
            command = "select * from dbo.ufLayPhanQuyen(@tenDangNhap)";
            DataTable chucNang = Database.Query(command, parameter);
            command = "exec spXoaPhanQuyen @tenDangNhap, @maChucNang";        
            for(int i = 0; i < chucNang.Rows.Count; i++)
            {
                parameter.Clear();
                parameter.Add("@tenDangNhap", dgv_nguoiDung.CurrentRow.Cells["TenDangNhap"].Value.ToString());
                parameter.Add("@maChucNang", (int)chucNang.Rows[i]["MaChucNang"]);
                Database.Execute(command, parameter);
            }
            command = "exec spPhanQuyen @tenDangNhap, @maChucNang";
            foreach(int index in maChucNangCheck)
            {
                parameter.Clear();
                parameter.Add("@tenDangNhap", dgv_nguoiDung.CurrentRow.Cells["TenDangNhap"].Value.ToString());
                parameter.Add("@maChucNang", index);
                Database.Execute(command, parameter);
            }
            load_dgvNguoiDung();
            status.Text = "Thông báo: Cập nhập dữ liệu thành công";
        }
        private void but_xoaTaiKhoan_Click(object sender, EventArgs e)
        {
            string command = "exec spXoaNguoiDung @tenDangNhap";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@tenDangNhap", dgv_nguoiDung.CurrentRow.Cells["TenDangNhap"].Value.ToString());
            try
            {
                Database.Execute(command, parameter);
                load_dgvNguoiDung();
                status.Text = "Thông báo: Cập nhập dữ liệu thành công";

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgv_nguoiDung_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string strCommand = "select * from dbo.ufLayPhanQuyen(@tenDangNhap)";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@tenDangNhap", dgv_nguoiDung.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString());
            DataTable danhSachChucNang = Database.Query(strCommand, parameter);
            tv_chucNang.Nodes.Clear();
            TreeNode node = new TreeNode("Danh sách chức năng quản lý:");
            for (int i = 0; i < danhSachChucNang.Rows.Count; i++)
            {
                node.Nodes.Add(danhSachChucNang.Rows[i]["TenChucNang"].ToString());
            }
            node.Expand();
            tv_chucNang.Nodes.Add(node);
            List<string> listChucNang = new List<string>();
            for(int i = 0; i < danhSachChucNang.Rows.Count; i++)
            {
                listChucNang.Add(danhSachChucNang.Rows[i]["TenChucNang"].ToString());
            }
            ck_quanLyNguoiDung.Checked = listChucNang.Contains("QuanLyNguoiDung");
            ck_quanLyLoaiHang.Checked = listChucNang.Contains("QuanLyLoaiHang");
            ck_quanLyKho.Checked = listChucNang.Contains("QuanLyKho");
            ck_quanLyHangHoa.Checked = listChucNang.Contains("QuanLyHangHoa");
            ck_quanLyPhieuNhap.Checked = listChucNang.Contains("QuanLyPhieuNhap");
            ck_quanLyPhieuXuat.Checked = listChucNang.Contains("QuanLyPhieuXuat");
            ck_quanLyDonViTinh.Checked = listChucNang.Contains("QuanLyDonViTinh");
            ck_quanLyKiemKho.Checked = listChucNang.Contains("ThongKeHangHoa");
            
        }

        private void but_lamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
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
