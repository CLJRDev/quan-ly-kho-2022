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
    public partial class FrmQuanLyDonViTinhHangHoa : Form
    {
        private string maHangHoa;
        public FrmQuanLyDonViTinhHangHoa(string maHangHoa)
        {
            InitializeComponent();
            this.maHangHoa = maHangHoa;
            dgv_donViTinhHangHoa.AutoGenerateColumns = false;
            loadCbbDonViTinh();
            load_dgvDonViTinhHangHoa();
        }
        private void load_dgvDonViTinhHangHoa()
        {
            string command = "select * from dbo.ufLayDonViTinhCuaHangHoa(@maHangHoa)";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maHangHoa", maHangHoa);
            dgv_donViTinhHangHoa.DataSource = Database.Query(command, parameter);
            but_xoaDonViTinh.Enabled = dgv_donViTinhHangHoa.Rows.Count > 0;
        }
        private void loadCbbDonViTinh()
        {
            cbb_donViTinh.DataSource = Database.Query("select * from DonViTinh", new Dictionary<string, object>());
            but_xoaDonViTinh.Enabled = dgv_donViTinhHangHoa.Rows.Count > 0;
        }
        private void FrmQuanLyDonViTinhHangHoa_Load(object sender, EventArgs e)
        {
            string command = "select TenHangHoa from HangHoa where MaHangHoa=@maHangHoa";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maHangHoa", this.maHangHoa);
            txt_hienThiHangHoa.Text = Database.Query(command, parameter).Rows[0][0].ToString();
        }

        private void but_themDonViTinh_Click(object sender, EventArgs e)
        {
            string command = "exec spThemDonViTinhHangHoa @maHangHoa,@maDonViTinh,@nguoiSua";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maHangHoa", this.maHangHoa);
            parameter.Add("@maDonViTinh", cbb_donViTinh.SelectedValue);
            parameter.Add("@nguoiSua", Program.TenDangNhap);
            try
            {
                Database.Execute(command, parameter);
                load_dgvDonViTinhHangHoa();
                status.Text = "Thông báo: Thêm đơn vị tính thành công";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status.Text = "Thông báo: Thêm đơn vị tính thất bại";
            }
            
        }

        private void but_xoaDonViTinh_Click(object sender, EventArgs e)
        {
            string command = "exec spXoaDonViTinhHangHoa @maHangHoa, @maDonViTinh,@nguoiSua";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maHangHoa", this.maHangHoa);
            parameter.Add("@maDonViTinh", dgv_donViTinhHangHoa.CurrentRow.Cells["MaDonViTinh"].Value.ToString());
            parameter.Add("@nguoiSua", Program.TenDangNhap);
            Database.Execute(command, parameter);
            load_dgvDonViTinhHangHoa();
            status.Text = "Thông báo: Xoá đơn vị tính thành công";
            but_xoaDonViTinh.Enabled = dgv_donViTinhHangHoa.Rows.Count > 0;
        }
    }
}
