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
    public partial class FrmQuanLyKho : Form
    {
        public FrmQuanLyKho()
        {
            InitializeComponent();
            loadDgvKho();
            loadCbbKho();
            loadCbbHangHoa();           
        }

        public void loadDgvKho()
        {
            if (ck_timKiem.Checked)
            {
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                string command = "select * from dbo.ufTimKiemKho(@maKho,@diaChi,@thuKho,@maHangHoa,@maDonViTinh,@soLuong)";
                if (ck_maKho.Checked)
                {
                    parameter.Add("@maKho", cbb_kho.SelectedValue);
                }
                else
                {
                    parameter.Add("@maKho", "");
                }
                if (ck_diaChi.Checked)
                {
                    parameter.Add("@diaChi", txt_diaChi.Text);
                }
                else
                {
                    parameter.Add("@diaChi", "");
                }
                if (ck_thuKho.Checked)
                {
                    parameter.Add("@thuKho", txt_thuKho.Text);
                }
                else
                {
                    parameter.Add("@thuKho", "");
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
                if (ck_soLuong.Checked)
                {
                    try{parameter.Add("@soLuong", Convert.ToDouble(txt_soLuong.Text));
                    }catch(Exception ex) { parameter.Add("@soLuong", 0); }
                }
                else
                {
                    parameter.Add("@soLuong", "");
                }
                dgv_quanLyKho.DataSource = Database.Query(command, parameter);
            }
            else
            {
                dgv_quanLyKho.DataSource = Database.Query("select * from Kho", new Dictionary<string, object>());
            }           
        }
        private void loadCbbKho()
        {
            cbb_kho.DataSource = Database.Query("select * from Kho", new Dictionary<string, object>());
        }
        private void loadCbbHangHoa()
        {
            cbb_hangHoa.DataSource = Database.Query("select * from HangHoa", new Dictionary<string, object>());
        }
        private void cbb_hangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_hangHoa.Text != "")
            {
                string command = "select * from dbo.ufLayDonViTinhCuaHangHoa(@maHangHoa)";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                parameter.Add("@maHangHoa", cbb_hangHoa.SelectedValue);
                cbb_donViTinh.DataSource = Database.Query(command, parameter);
            }
        }
        
        private void but_them_Click(object sender, EventArgs e)
        {
            FrmThemKho form = new FrmThemKho();
            form.ShowDialog();
            loadDgvKho();
        }

        private void dgv_quanLyKho_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string strQuery = "select * from dbo.ufLayChiTietKho(@maKho)";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maKho", dgv_quanLyKho.Rows[e.RowIndex].Cells["MaKho"].Value.ToString());
            DataTable chiTietKhos = Database.Query(strQuery, parameter);
            strQuery = "select * from dbo.ufLayChietTietHangHoaTrongKho(@maKho,@maHangHoa)";            
            tv_chiTietKho.Nodes.Clear();
            for(int i = 0; i < chiTietKhos.Rows.Count; i++)
            {
                TreeNode node = new TreeNode(chiTietKhos.Rows[i]["TenHangHoa"].ToString());
                parameter.Clear();
                parameter.Add("@maKho", dgv_quanLyKho.Rows[e.RowIndex].Cells["MaKho"].Value.ToString());
                parameter.Add("@maHangHoa", chiTietKhos.Rows[i]["MaHangHoa"].ToString());
                DataTable chiTietHangHoaTrongKho = Database.Query(strQuery, parameter);
                for(int j = 0; j < chiTietHangHoaTrongKho.Rows.Count; j++)
                {
                    if(chiTietHangHoaTrongKho.Rows[j]["SoLuong"].ToString() != "0")                   
                        node.Nodes.Add(chiTietHangHoaTrongKho.Rows[j]["SoLuong"].ToString() + " " + chiTietHangHoaTrongKho.Rows[j]["TenDonViTinh"].ToString());               
                }               
                node.Expand();
                tv_chiTietKho.Nodes.Add(node);
            }
        }
        private void ck_timKiem_CheckedChanged(object sender, EventArgs e)
        {
            loadDgvKho();
            but_timKiem.Enabled = ck_timKiem.Checked;
        }

        private void but_timKiem_Click(object sender, EventArgs e)
        {
            loadDgvKho();
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

        private void ck_maKho_CheckedChanged(object sender, EventArgs e)
        {
            cbb_kho.Enabled = ck_maKho.Checked;
        }

        private void ck_diaChi_CheckedChanged(object sender, EventArgs e)
        {
            txt_diaChi.Enabled = ck_diaChi.Checked;
        }

        private void ck_thuKho_CheckedChanged(object sender, EventArgs e)
        {
            txt_thuKho.Enabled = ck_thuKho.Checked;
        }

        private void but_NhapKho_Click(object sender, EventArgs e)
        {
            FrmThemPhieuNhap form = new FrmThemPhieuNhap(dgv_quanLyKho.CurrentRow.Cells["MaKho"].Value.ToString());
            form.ShowDialog();
            loadDgvKho();
        }

        private void but_sua_Click(object sender, EventArgs e)
        {
            FrmSuaKho form = new FrmSuaKho();
            form.ShowDialog();
            loadDgvKho();
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            string command = "exec spXoaKho @maKho";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maKho", dgv_quanLyKho.CurrentRow.Cells["MaKho"].Value.ToString());
            try
            {
                Database.Execute(command, parameter);
                status.Text = "Thông báo: Xoá kho thành công";
                loadDgvKho();
                but_xoa.Enabled = dgv_quanLyKho.Rows.Count > 0;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status.Text = "Thông báo: Xoá kho thất bại";
            }
        }

        private void but_dong_Click(object sender, EventArgs e)
        {
            if (this.TopLevel == false)
                ((TabControl)this.Parent.Parent).TabPages.Remove((TabPage)this.Parent);
            else
                this.Close();
        }

        private void but_xuatKho_Click(object sender, EventArgs e)
        {
            FrmThemPhieuXuat form = new FrmThemPhieuXuat(dgv_quanLyKho.CurrentRow.Cells["MaKho"].Value.ToString());
            form.ShowDialog();
            loadDgvKho();
        }
    }
}
