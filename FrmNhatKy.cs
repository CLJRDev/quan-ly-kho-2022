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
    public partial class FrmNhatKy : Form
    {
        public FrmNhatKy()
        {
            InitializeComponent();
            dgv_nhatKy.AutoGenerateColumns = false;
            dtp_thoiDiemTu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtp_thoiDiemDen.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            load_dgv_nhatKy();
        }
        public void load_dgv_nhatKy()
        {
                string command = "select * from dbo.ufTimKiemNhatKy(@tenDangNhap,@thoiDiemTu,@thoiDiemDen)";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                if (ck_tenDangNhap.Checked)
                {
                    parameter.Add("@tenDangNhap", txt_tenDangNhap.Text);
                }
                else
                {
                    parameter.Add("@tenDangNhap", "");
                }
                if (ck_thoiDiemTu.Checked)
                {
                    parameter.Add("@thoiDiemTu", dtp_thoiDiemTu.Value);
                }
                else
                {
                    parameter.Add("@thoiDiemTu", "");
                }
                if (ck_thoiDiemDen.Checked)
                {
                    parameter.Add("@thoiDiemDen", dtp_thoiDiemDen.Value.AddDays(1));
                }
                else
                {
                    parameter.Add("@thoiDiemDen", "");
                }
                dgv_nhatKy.DataSource = Database.Query(command, parameter);           
        }

        private void but_dong_Click(object sender, EventArgs e)
        {
            if (this.TopLevel == false)
                ((TabControl)this.Parent.Parent).TabPages.Remove((TabPage)this.Parent);
            else
                this.Close();
        }

        private void ck_timKiem_CheckedChanged(object sender, EventArgs e)
        {
            load_dgv_nhatKy();
            but_timKiem.Enabled = ck_timKiem.Checked;
        }

        private void but_timKiem_Click(object sender, EventArgs e)
        {
            load_dgv_nhatKy();           
        }

        private void ck_thoiDiemTu_CheckedChanged(object sender, EventArgs e)
        {
            dtp_thoiDiemTu.Enabled = ck_thoiDiemTu.Checked;
        }

        private void ck_thoiDiemDen_CheckedChanged(object sender, EventArgs e)
        {
            dtp_thoiDiemDen.Enabled = ck_thoiDiemDen.Checked;
        }

        private void ck_tenDangNhap_CheckedChanged(object sender, EventArgs e)
        {
            txt_tenDangNhap.Enabled = ck_tenDangNhap.Checked;
        }
    }
}
