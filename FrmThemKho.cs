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
    public partial class FrmThemKho : Form
    {
        public FrmThemKho()
        {
            InitializeComponent();
            load_dgvKho();
        }
        private bool checkKho()
        {
            bool result = true;
            errorMess.Clear();
            if(txt_maKho.Text == "")
            {
                result = false;
                errorMess.SetError(txt_maKho, "Không được để trống");
            }
            if(txt_tenKho.Text == "")
            {
                errorMess.SetError(txt_tenKho, "Không được để trống");
                result = false;
            }
            if(txt_thuKho.Text == "")
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

        private void but_luu_Click(object sender, EventArgs e)
        {
            if (this.checkKho() == false)
                return;
            string strCommand = "exec spThemKho @maKho,@tenKho,@diaChi,@thuKho";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maKho", txt_maKho.Text);
            parameter.Add("@tenKho", txt_tenKho.Text);
            parameter.Add("@diaChi", txt_diaChi.Text);
            parameter.Add("@thuKho", txt_thuKho.Text);
            try
            {
                Database.Execute(strCommand, parameter);
                load_dgvKho();
                labMes.Text = "Thông báo: Thêm kho thành công";
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labMes.Text = "Thông báo: Thêm kho thất bại";
            }                               
        }
        private void load_dgvKho()
        {
            dgv_kho.DataSource = Database.Query("select * from Kho", new Dictionary<string, object>());
        }
    }
}
