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
    public partial class FrmSuaKho : Form
    {
        public FrmSuaKho()
        {
            InitializeComponent();
            load_dgvKho();
        }
        private bool checkKho()
        {
            bool result = true;
            errorMess.Clear();
            if (txt_maKho.Text == "")
            {
                result = false;
                errorMess.SetError(txt_maKho, "Không được để trống");
            }
            if (txt_tenKho.Text == "")
            {
                errorMess.SetError(txt_tenKho, "Không được để trống");
                result = false;
            }
            if (txt_thuKho.Text == "")
            {
                errorMess.SetError(txt_thuKho, "Không được để trống");
                result = false;
            }
            if (txt_diaChi.Text == "")
            {
                errorMess.SetError(txt_diaChi, "Không được để trống");
                result = false;
            }
            labMes.Text = "Status: Loi cap nhap du lieu";
            return result;
        }

        private void load_dgvKho()
        {
            dgv_kho.DataSource = Database.Query("select * from Kho", new Dictionary<string, object>());
            but_luu.Enabled = dgv_kho.Rows.Count > 0;
        }

        private void dgv_kho_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                string command = "select * from Kho where MaKho = @maKho";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                string maKho = dgv_kho.Rows[e.RowIndex].Cells["MaKho"].Value.ToString();
                parameter.Add("@maKho", maKho);
                DataTable kho = Database.Query(command, parameter);
                txt_maKho.Text = maKho;
                txt_tenKho.Text = kho.Rows[0]["TenKho"].ToString();
                txt_diaChi.Text = kho.Rows[0]["DiaChi"].ToString();
                txt_thuKho.Text = kho.Rows[0]["ThuKho"].ToString();
            }            
        }

        private void but_luu_Click(object sender, EventArgs e)
        {
            if (this.checkKho() == false)
                return;
            string command = "exec spSuaKho @maKho,@tenKho,@diaChi,@thuKho";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maKho", txt_maKho.Text);
            parameter.Add("@tenKho", txt_tenKho.Text);
            parameter.Add("@diaChi", txt_diaChi.Text);
            parameter.Add("@thuKho", txt_thuKho.Text);
            try
            {
                Database.Execute(command, parameter);
                load_dgvKho();
                labMes.Text = "Thông báo: Sửa kho thành công";
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labMes.Text = "Thông báo: Sửa kho thất bại";
            }
;        }
    }
}
