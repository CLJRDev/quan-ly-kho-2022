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
    public partial class FrmQuanLyDonViTinh : Form
    {
        public FrmQuanLyDonViTinh()
        {
            InitializeComponent();
            dgv_DonViTinh.AutoGenerateColumns = false;
            Load_Dgv_DonViTinh();
        }

        private bool check()
        {
            bool result = true;
            errorMes.Clear();
            if(txt_maDonViTinh.Text == "")
            {
                result = false;
                errorMes.SetError(txt_maDonViTinh, "Không được để trống mã đơn vị tính");
            }
            if(txt_tenDonViTinh.Text == "")
            {
                result = false;
                errorMes.SetError(txt_tenDonViTinh, "Không được để trống tên đơn vị tính");
            }
            labMes.Text = "Status: Loi cap nhap du lieu";
            return result;
        }
        public void Load_Dgv_DonViTinh()
        {
            if (ck_timKiem.Checked == false)
            {
                string strCommand = "select * from DonViTinh";
                dgv_DonViTinh.DataSource = Database.Query(strCommand, new Dictionary<string, object>());
            }
            else
            {
                string strSelect = "select * from dbo.ufTimKiemDonViTinh(@maDonViTinh,@tenDonViTinh)";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                if (ck_maDonViTinh.Checked)
                {
                    parameter.Add("@maDonViTinh", txt_maDonViTinh.Text);
                }
                else
                {
                    parameter.Add("@maDonViTinh", "");
                }
                if (ck_tenDonViTinh.Checked)
                {
                    parameter.Add("@tenDonViTinh", txt_tenDonViTinh.Text);
                }
                else
                {
                    parameter.Add("@tenDonViTinh", "");
                }
                dgv_DonViTinh.DataSource = Database.Query(strSelect, parameter);
            }
            but_sua.Enabled = but_xoa.Enabled = dgv_DonViTinh.Rows.Count > 0;
        }
        private void but_them_Click(object sender, EventArgs e)
        {
            if (this.check() == false)
                return;
            errorMes.Clear();
            string strCommand = "exec spThemDonViTinh @maDonViTinh,@tenDonViTinh,@nguoiSua";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maDonViTinh", txt_maDonViTinh.Text);
            parameter.Add("@tenDonViTinh", txt_tenDonViTinh.Text);
            parameter.Add("@nguoiSua", Program.TenDangNhap);
            try
            {
                Database.Execute(strCommand, parameter);
                labMes.Text = "Thông báo: Cập nhập dữ liệu thành công";
                Load_Dgv_DonViTinh();
            }
            catch(Exception ex)
            {
                if(ex.Message == "Trùng mã đơn vị tính")
                {
                    errorMes.SetError(txt_maDonViTinh, ex.Message);
                }
                if(ex.Message == "Trùng tên đơn vị tính")
                {
                    errorMes.SetError(txt_tenDonViTinh, ex.Message);
                }
                labMes.Text = "Thông báo: Lỗi trùng lặp dữ liệu";
            }         
        }

        private void but_sua_Click(object sender, EventArgs e)
        {
            if (this.check() == false)
                return;
            string strCommand = "exec spSuaDonViTinh @maDonViTinh, @tenDonViTinh, @nguoiSua";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maDonViTinh", dgv_DonViTinh.CurrentRow.Cells["MaDonViTinh"].Value.ToString());
            parameter.Add("@tenDonViTinh", txt_tenDonViTinh.Text);
            parameter.Add("@nguoiSua", Program.TenDangNhap);
            errorMes.Clear();
            try
            {
                Database.Execute(strCommand, parameter);               
                Load_Dgv_DonViTinh();
                labMes.Text = "Thông báo: Cập nhập dữ liệu thành công";
            }
            catch (Exception ex)
            {
                errorMes.SetError(txt_tenDonViTinh, ex.Message);
                labMes.Text = "Thông báo: Cập nhập dữ liệu thất bại";
            }
            
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            string strDelete = "exec spXoaDonViTinh @maDonViTinh,@nguoiSua";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maDonViTinh", dgv_DonViTinh.CurrentRow.Cells["MaDonViTinh"].Value.ToString());
            parameter.Add("@nguoiSua", Program.TenDangNhap);
            errorMes.Clear();
            try
            {
                Database.Execute(strDelete, parameter);               
                Load_Dgv_DonViTinh();
                labMes.Text = "Thông báo: Xoá dữ liệu thành công";
            }
            catch(Exception ex)
            {
                labMes.Text = "Thông báo: Lỗi xoá dữ liệu";
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            
        }

        private void dgv_DonViTinh_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                txt_maDonViTinh.Text = dgv_DonViTinh.Rows[e.RowIndex].Cells["MaDonViTinh"].Value.ToString();
                txt_tenDonViTinh.Text = dgv_DonViTinh.Rows[e.RowIndex].Cells["TenDonViTinh"].Value.ToString();
                //Lay danh sach hang hoa theo ma don vi tinh vua lay
                string strCommand = "select * from dbo.ufLayHangHoaTheoDonViTinh(@maDonViTinh)";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                parameter.Add("@maDonViTinh", dgv_DonViTinh.Rows[e.RowIndex].Cells["MaDonViTinh"].Value.ToString());
                DataTable danhSachHangHoas = Database.Query(strCommand, parameter);
                //Day danh sach hang hoa len tree view
                tv_danhSachHangHoa.Nodes.Clear();
                TreeNode node = new TreeNode("Danh sách hàng hoá: ");
                for(int i = 0; i < danhSachHangHoas.Rows.Count; i++)
                {
                    node.Nodes.Add(danhSachHangHoas.Rows[i]["TenHangHoa"].ToString());
                }
                node.Expand();
                tv_danhSachHangHoa.Nodes.Add(node);
            }
        }

        private void ck_timKiem_CheckedChanged(object sender, EventArgs e)
        {
            but_timKiem.Enabled = ck_timKiem.Checked;
            Load_Dgv_DonViTinh();
        }
        private void but_timKiem_Click(object sender, EventArgs e)
        {
            Load_Dgv_DonViTinh();
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
