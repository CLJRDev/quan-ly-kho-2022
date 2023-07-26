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
    public partial class FrmQuanLyHangHoa : Form
    {
        public FrmQuanLyHangHoa()
        {
            InitializeComponent();
            dgv_hangHoa.AutoGenerateColumns = false;
            loadDgvHangHoa();
        }
        private bool check()
        {
            bool result = true;
            errorMess.Clear();
            if(txt_maHangHoa.Text == "")
            {
                errorMess.SetError(txt_maHangHoa, "Không được để trống mã hàng hoá");
                result = false;
            }
            if(txt_tenHangHoa.Text == "")
            {
                errorMess.SetError(txt_tenHangHoa, "Không được để trống tên hàng hoá");
                result = false;
            }
            status.Text = "Thông báo: Lỗi cập nhập dữ liệu";
            return result;
        }

        public void loadDgvHangHoa()
        {
            if (ck_timKiem.Checked == false)
            {
                dgv_hangHoa.DataSource = Database.Query("select * from HangHoa", new Dictionary<string, object>());
            }
            else
            {
                string command = "select * from dbo.ufTimKiemHangHoa(@maHangHoa,@tenHangHoa)";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                if (ck_maHangHoa.Checked)
                {
                    parameter.Add("@maHangHoa", txt_maHangHoa.Text);
                }
                else
                {
                    parameter.Add("@maHangHoa", "");
                }
                if (ck_tenHangHoa.Checked)
                {
                    parameter.Add("@tenHangHoa", txt_tenHangHoa.Text);
                }
                else
                {
                    parameter.Add("@tenHangHoa", "");
                }
                dgv_hangHoa.DataSource = Database.Query(command, parameter);
            }
            but_sua.Enabled = but_xoa.Enabled = dgv_hangHoa.Rows.Count > 0;
        }
        private void but_them_Click(object sender, EventArgs e)
        {
            if (this.check() == false)
                return;
            string command = "exec spThemHangHoa @maHangHoa, @tenHangHoa, @nguoiSua";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maHangHoa", txt_maHangHoa.Text);
            parameter.Add("@tenHangHoa", txt_tenHangHoa.Text);
            parameter.Add("@nguoiSua", Program.TenDangNhap);
            try
            {
                Database.Execute(command, parameter);
                loadDgvHangHoa();
                status.Text = "Thông báo: Cập nhập dữ liệu thành công";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status.Text = "Thông báo: Lỗi cập nhập dữ liệu";
            }
        }

        private void but_sua_Click(object sender, EventArgs e)
        {
            if (this.check() == false)
                return;
            string command = "exec spSuaHangHoa @maHangHoa, @tenHangHoa, @nguoiSua";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maHangHoa", dgv_hangHoa.CurrentRow.Cells["MaHangHoa"].Value.ToString());
            parameter.Add("@tenHangHoa", txt_tenHangHoa.Text);
            parameter.Add("@nguoiSua", Program.TenDangNhap);
            try
            {
                Database.Execute(command, parameter);
                loadDgvHangHoa();
                status.Text = "Thông báo: Cập nhập hành hoá thành công";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status.Text = "Thông báo: Lỗi cập nhập hàng hoá";
            }
        }

        private void dgv_hangHoa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                txt_maHangHoa.Text = dgv_hangHoa.Rows[e.RowIndex].Cells["MaHangHoa"].Value.ToString();
                txt_tenHangHoa.Text = dgv_hangHoa.Rows[e.RowIndex].Cells["TenHangHoa"].Value.ToString();
                //Load Tree View chi tiet hang hoa
                tv_chiTietHangHoa.Nodes.Clear();
                string command = "select * from dbo.ufLayDonViTinhCuaHangHoa(@maHangHoa)";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                parameter.Add("@maHangHoa", dgv_hangHoa.Rows[e.RowIndex].Cells["MaHangHoa"].Value.ToString());
                DataTable donViTinh = Database.Query(command, parameter);
                command = "select * from dbo.ufLayLoaiHangTheoMaHangHoa(@maHangHoa)";
                DataTable loaiHang = Database.Query(command, parameter);
                TreeNode nodeDonViTinh = new TreeNode("Đơn vị tính:");
                TreeNode nodeLoaiHang = new TreeNode("Loại hàng:");
                for (int i = 0; i < donViTinh.Rows.Count; i++)
                    nodeDonViTinh.Nodes.Add(donViTinh.Rows[i]["TenDonViTinh"].ToString());
                for(int i = 0; i < loaiHang.Rows.Count; i++)                
                    nodeLoaiHang.Nodes.Add(loaiHang.Rows[i]["TenLoaiHang"].ToString());
                nodeDonViTinh.Expand();
                tv_chiTietHangHoa.Nodes.Add(nodeDonViTinh);
                nodeLoaiHang.Expand();
                tv_chiTietHangHoa.Nodes.Add(nodeLoaiHang);
            }
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            string command = "exec spXoaHangHoa @maHangHoa,@nguoiSua";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maHangHoa", txt_maHangHoa.Text);
            parameter.Add("@nguoiSua", Program.TenDangNhap);
            try
            {
                Database.Execute(command, parameter);
                loadDgvHangHoa();
                status.Text = "Thông báo: Xoá hàng hoá thành công";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status.Text = "Thông báo: Lỗi cập nhập hàng hoá";
            }
            
        }

        private void but_timKiem_Click(object sender, EventArgs e)
        {
            loadDgvHangHoa();
        }

        private void ck_timKiem_CheckedChanged(object sender, EventArgs e)
        {
            loadDgvHangHoa();
            but_timKiem.Enabled = ck_timKiem.Checked;
        }

        private void but_donViTinh_Click(object sender, EventArgs e)
        {
            string maHangHoa = dgv_hangHoa.CurrentRow.Cells["MaHangHoa"].Value.ToString();
            FrmQuanLyDonViTinhHangHoa form = new FrmQuanLyDonViTinhHangHoa(maHangHoa);
            form.ShowDialog();
            loadDgvHangHoa();
        }

        private void but_loaiHang_Click(object sender, EventArgs e)
        {
            string maHangHoa = dgv_hangHoa.CurrentRow.Cells["MaHangHoa"].Value.ToString();
            FrmQuanLyLoaiHangHangHoa form = new FrmQuanLyLoaiHangHangHoa(maHangHoa);
            form.ShowDialog();
            loadDgvHangHoa();
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
