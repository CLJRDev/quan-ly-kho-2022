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
    public partial class FrmQuanLyLoaiHangHangHoa : Form
    {
        private string maHangHoa;
        public FrmQuanLyLoaiHangHangHoa(string maHangHoa)
        {
            InitializeComponent();
            this.maHangHoa = maHangHoa;
            loadCbbLoaiHang();
            load_dgvLoaiHangHangHoa();
        }
        private void load_dgvLoaiHangHangHoa()
        {
            string command = "select * from dbo.ufLayLoaiHangTheoMaHangHoa(@maHangHoa)";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maHangHoa", this.maHangHoa);
            dgv_loaiHangHangHoa.DataSource = Database.Query(command, parameter);
            but_xoaLoaiHang.Enabled = dgv_loaiHangHangHoa.Rows.Count > 0;
        }
        private void loadCbbLoaiHang()
        {
            cbb_loaiHang.DataSource = Database.Query("select * from LoaiHang", new Dictionary<string, object>());            
        }

        private void but_themLoaiHang_Click(object sender, EventArgs e)
        {
            string command = "exec spThemLoaiHangHangHoa @maLoaiHang,@maHangHoa,@nguoiSua";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maLoaiHang", cbb_loaiHang.SelectedValue);
            parameter.Add("@maHangHoa", this.maHangHoa);
            parameter.Add("@nguoiSua", Program.TenDangNhap);
            try
            {
                Database.Execute(command, parameter);
                load_dgvLoaiHangHangHoa();
                status.Text = "Thông báo: Thêm loại hàng thành công";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status.Text = "Thông báo: Xoá loại hàng thất bại";
            }
        }

        private void but_xoaLoaiHang_Click(object sender, EventArgs e)
        {
            string command = "exec spXoaLoaiHangHangHoa @maLoaiHang,@maHangHoa,@nguoiSua";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maLoaiHang", dgv_loaiHangHangHoa.CurrentRow.Cells["MaLoaiHang"].Value.ToString());
            parameter.Add("@maHangHoa", this.maHangHoa);
            parameter.Add("@nguoiSua", Program.TenDangNhap);
            Database.Execute(command, parameter);
            load_dgvLoaiHangHangHoa();
            status.Text = "Thông báo: Xoá loại hàng thành công";
            but_xoaLoaiHang.Enabled = dgv_loaiHangHangHoa.Rows.Count > 0;
            
        }

        private void FrmQuanLyLoaiHangHangHoa_Load(object sender, EventArgs e)
        {
            string command = "select TenHangHoa from HangHoa where MaHangHoa = @maHangHoa";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maHangHoa", this.maHangHoa);
            txt_hienThiHangHoa.Text = Database.Query(command, parameter).Rows[0][0].ToString();
        }
    }
}
