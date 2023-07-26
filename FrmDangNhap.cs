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
    public partial class FrmDangNhap : Form
    {
        private bool authentication = false;
        public bool getAuthentication
        {
            get { return authentication; }
        }
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void but_dangNhap_Click(object sender, EventArgs e)
        {
            string strCommand = "exec spDangNhap @tenDangNhap, @matKhau";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@tenDangNhap", txt_tenDangNhap.Text);
            parameter.Add("@matKhau", txt_matKhau.Text);
            try
            {
                Database.Execute(strCommand, parameter);
                Program.TenDangNhap = txt_tenDangNhap.Text;
                authentication = true;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void but_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
