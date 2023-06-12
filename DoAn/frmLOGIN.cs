using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frmLOGIN : Form
    {
        private DataProviders data;
        private DataTable dt;
        public string a;
        public frmLOGIN()
        {
            InitializeComponent();
        }

        private void frmLOGIN_Load(object sender, EventArgs e)
        {
          data = new DataProviders();
            data.OpenDB();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Thông tin tài khoản đăng nhập chưa được điền!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtUserName.Focus();
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Thông tin mật khẩu chưa được điền!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return;
            }
            data = new DataProviders();
            if (data.OpenDB() == false) return;

            string ssql = "select * from TAIKHOAN where Name = '" + txtUserName.Text + "'AND Pass ='" + txtPassword.Text + "'";
            DataTable   dt = data.RunQuery(ssql);
            if(dt.Rows.Count == 0) {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng! Vui lòng nhập lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Focus();
                return;
            }
            frmMain form = new frmMain();
            form.ShowDialog();
            this.Hide();

        }


  
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            if (checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
                    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(null, null);
        }
    }
}

