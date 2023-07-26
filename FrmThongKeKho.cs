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
    public partial class FrmThongKeKho : Form
    {
        public FrmThongKeKho()
        {
            InitializeComponent();
            loadCbbKho();
            loadCbbHangHoa();
            load_dgvHangHoa();
        }
        private void load_dgvHangHoa()
        {
            string command = "select * from dbo.ufThongKeHangHoa (@maKho,@maHangHoa,@maDonViTinh)";
            Dictionary<string, object> parameter = new Dictionary<string, object>();            
            if (ck_maKho.Checked)
            {
                parameter.Add("@maKho", cbb_kho.SelectedValue);
            }
            else
            {
                parameter.Add("@maKho", "");   
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
            dgv_hangHoaThongKe.DataSource = Database.Query(command, parameter);
            but_xuatExcel.Enabled = dgv_hangHoaThongKe.Rows.Count > 0;
        }
        public void loadCbbKho()
        {
            cbb_kho.DataSource = Database.Query("select * from Kho", new Dictionary<string, object>());
        }
        public void loadCbbHangHoa()
        {
            cbb_hangHoa.DataSource = Database.Query("select * from HangHoa", new Dictionary<string, object>());
        }

        private void cbb_hangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_hangHoa.SelectedIndex != -1)
            {
                string command = "select * from ufLayDonViTinhCuaHangHoa(@maHangHoa)";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                parameter.Add("@maHangHoa", cbb_hangHoa.SelectedValue);
                cbb_donViTinh.DataSource = Database.Query(command, parameter);
            }
        }

        private void ck_maKho_CheckedChanged(object sender, EventArgs e)
        {
            cbb_kho.Enabled = ck_maKho.Checked;
        }

        private void ck_hangHoa_CheckedChanged(object sender, EventArgs e)
        {
            cbb_hangHoa.Enabled = ck_hangHoa.Checked;
        }

        private void ck_donViTinh_CheckedChanged(object sender, EventArgs e)
        {
            cbb_donViTinh.Enabled = ck_donViTinh.Checked;
        }

        private void ck_timKiem_CheckedChanged(object sender, EventArgs e)
        {
            but_timKiem.Enabled = ck_timKiem.Checked;
            load_dgvHangHoa();
        }
        private void but_timKiem_Click(object sender, EventArgs e)
        {
            load_dgvHangHoa();
        }

        private void toExcel(DataGridView dgvChiTiet, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Thống kê hàng hoá còn trong kho";
                // export header trong DataGridView
                for (int i = 0; i < dgvChiTiet.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dgvChiTiet.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dgvChiTiet.RowCount; i++)
                {
                    for (int j = 0; j < dgvChiTiet.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvChiTiet.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!","Thông báo",MessageBoxButtons.OK);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
        private void but_xuatExcel_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dgv_hangHoaThongKe và filename từ SaveFileDialog
                this.toExcel(dgv_hangHoaThongKe, saveFile.FileName);
            }
        }

        private void but_dong_Click(object sender, EventArgs e)
        {
            if (this.TopLevel == false)
                ((TabControl)this.Parent.Parent).TabPages.Remove((TabPage)this.Parent);
            else
                this.Close();
        }

        private void dgv_hangHoaThongKe_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string command = "select * from dbo.ufLayKhoChuaHangHoa(@maHangHoa,@maDonViTinh)";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maHangHoa", dgv_hangHoaThongKe.Rows[e.RowIndex].Cells["MaHangHoa"].Value.ToString());
            parameter.Add("@maDonViTinh", dgv_hangHoaThongKe.Rows[e.RowIndex].Cells["MaDonViTinh"].Value.ToString());
            DataTable danhSachKho = Database.Query(command, parameter);
            tv_danhSachKho.Nodes.Clear();
            TreeNode node = new TreeNode("Danh sách kho: ");
            for(int i = 0; i < danhSachKho.Rows.Count; i++)
            {
                node.Nodes.Add(danhSachKho.Rows[i]["TenKho"].ToString() + ": " + danhSachKho.Rows[i]["SoLuong"].ToString() + " " + danhSachKho.Rows[i]["TenDonViTinh"].ToString());
            }
            node.Expand();
            tv_danhSachKho.Nodes.Add(node);
        }
    }
}
