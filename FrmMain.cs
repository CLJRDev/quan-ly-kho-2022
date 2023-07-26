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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmDangNhap form = new FrmDangNhap();
            form.ShowDialog();
            if(form.getAuthentication == false)
            {
                Application.Exit();
            }
            else
            {
                string strQuery = "select * from dbo.ufLayPhanQuyen(@tenDangNhap)";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                parameter.Add("@tenDangNhap", Program.TenDangNhap);
                DataTable chucNangs = Database.Query(strQuery, parameter);
                List<string> listChucNangs = new List<string>();
                for(int i = 0; i < chucNangs.Rows.Count; i++)
                {
                    listChucNangs.Add(chucNangs.Rows[i]["TenChucNang"].ToString());
                }
                mni_DonViTinh.Enabled = listChucNangs.Contains("QuanLyDonViTinh");
                mni_LoaiHang.Enabled = listChucNangs.Contains("QuanLyLoaiHang");
                mni_quanLyPhieuNhap.Enabled = listChucNangs.Contains("QuanLyPhieuNhap");
                mni_quanLyPhieuXuat.Enabled = listChucNangs.Contains("QuanLyPhieuXuat");
                mni_quanLyKho.Enabled = listChucNangs.Contains("QuanLyKho");
                mniQuanLyNguoiDung.Enabled = listChucNangs.Contains("QuanLyNguoiDung");
                mni_quanLyHangHoa.Enabled = listChucNangs.Contains("QuanLyHangHoa");
                mniNhatKyHeThong.Enabled = listChucNangs.Contains("QuanLyNhatKy");
                mni_KiemKho.Enabled = listChucNangs.Contains("ThongKeHangHoa");
            }
        }

        private void mni_quanLyPhieuXuat_Click(object sender, EventArgs e)
        {
            FrmQuanLyPhieuXuat form = new FrmQuanLyPhieuXuat();
            openTabForm(form);
        }

        private void mni_quanLyPhieuNhap_Click(object sender, EventArgs e)
        {
            FrmQuanLyPhieuNhap form = new FrmQuanLyPhieuNhap();
            openTabForm(form);
        }

        private void mni_DonViTinh_Click(object sender, EventArgs e)
        {
            FrmQuanLyDonViTinh form = new FrmQuanLyDonViTinh();
            openTabForm(form);
        }

        private void mni_LoaiHang_Click(object sender, EventArgs e)
        {
            FrmQuanLyLoaiHang form = new FrmQuanLyLoaiHang();
            openTabForm(form);
        }

        private void mni_quanLyHangHoa_Click(object sender, EventArgs e)
        {
            FrmQuanLyHangHoa form = new FrmQuanLyHangHoa();
            openTabForm(form);
        }

        private void mniQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            FrmQuanLyNguoiDung form = new FrmQuanLyNguoiDung();
            openTabForm(form);
        }

        private void openTabForm(Form form)
        {
            for (int i = 0; i < tbcFrame.TabPages.Count; i++)
            {
                if (tbcFrame.TabPages[i].Text == form.Text)
                {
                    tbcFrame.SelectedTab = tbcFrame.TabPages[i];                    
                    return;
                }
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Visible = true;
            form.Dock = DockStyle.Fill;            
            TabPage page = new TabPage(form.Text);
            page.Controls.Add(form);
            tbcFrame.TabPages.Add(page);
            tbcFrame.SelectedTab = page;
        }

        private void mni_quanLyKho_Click(object sender, EventArgs e)
        {
            FrmQuanLyKho form = new FrmQuanLyKho();
            openTabForm(form);
        }

        private void mniNhatKyHeThong_Click(object sender, EventArgs e)
        {
            FrmNhatKy form = new FrmNhatKy();
            openTabForm(form);
        }

        private void mni_KiemKho_Click(object sender, EventArgs e)
        {
            FrmThongKeKho form = new FrmThongKeKho();
            openTabForm(form);
        }
    }
}
