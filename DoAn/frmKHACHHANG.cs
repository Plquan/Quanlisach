using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frmKHACHHANG : Form
    {
        private DataProviders data;
        private DataTable dt;
        private SqlCommand mycommand;
        private bool modenew;
        private string oldphone;
        public frmKHACHHANG()
        {
            InitializeComponent();
        }

        private void frmKHACHHANG_Load(object sender, EventArgs e)
        {
            txtTENKH.Enabled = false;
            txtSDT.Enabled = false;
            txtDIACHI.Enabled = false;

            btnTHEM.Enabled = true;
            btnSUA.Enabled = true;
            btnXOA.Enabled = true;
            btnLUU.Enabled = false;
            btnHUY.Enabled = false;
            btnTHOAT.Enabled = true;

           data = new DataProviders();
            data.OpenDB();
            Display();

            txtTENKH.Clear();
            txtDIACHI.Clear();
            txtSDT.Clear();
            dataGridView1.ClearSelection();
        }
        private void Display()
        {
            string ssql = "select * from khachhang";
            dt = data.RunQuery(ssql);

            dataGridView1.DataSource = dt;
        }
     
        private void setcontrols(bool edit)
        {
            txtTENKH.Enabled = !edit;
            txtSDT.Enabled = !edit;
            txtDIACHI.Enabled = !edit;

            btnTHEM.Enabled = edit;
            btnSUA.Enabled = edit;
            btnXOA.Enabled = edit;
            btnLUU.Enabled = !edit;
            btnHUY.Enabled = !edit;
            btnTHOAT.Enabled = edit;
        }
        private void btnTHEM_Click(object sender, EventArgs e)
        {
  
            txtTENKH.Clear();
            txtDIACHI.Clear();
            txtSDT.Clear();
            setcontrols(false);
            txtTENKH.Focus();         
            modenew = true;
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {           
             txtTENKH.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDIACHI.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            oldphone = txtSDT.Text;
        }
        private void btnSUA_Click(object sender, EventArgs e)
        {
            setcontrols(false);
            modenew = false;
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int r = dataGridView1.CurrentRow.Index;
                string khachhang = dataGridView1.Rows[r].Cells[0].Value.ToString();

                string ssql = "select MAKH from HOADON where MAKH = '" + khachhang + "'";
                dt = data.RunQuery(ssql);
                if (dt.Rows.Count > 0)
                {
                    dr = MessageBox.Show("Thông Tin khách hàng tồn tại trong hóa đơn! \r\n\r\n Bạn chắc chắn muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No) return;
                    string ssql0 = "delete from HOADON where MAKH = '" + khachhang + "'";
                    data.ExecuteNonQuery(ssql0);
                }

      
                string ssql2 = "delete from KHACHHANG where MAKH = '" + khachhang + "'";
                data.ExecuteNonQuery(ssql2);
                Display();
                txtTENKH.Clear();
                txtDIACHI.Clear();
                txtSDT.Clear();
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Dòng Để Xóa!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }



        }
        private void btnHUY_Click(object sender, EventArgs e)
        {
            setcontrols(true);
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {

            if ((modenew == true) || ((modenew == false) && (txtSDT.Text != oldphone)))
            {
                if (txtTENKH.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa  nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTENKH.Focus();
                    setcontrols(false);
                    return;
                }
                if (txtTENKH.Text.Trim().Length > 50)
                {
                    MessageBox.Show("Kí tự nhập vao vượt quá số lượng cho phép!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTENKH.Focus();
                    return;
                }

                string ssql = "SELECT SDT FROM KHACHHANG WHERE SDT = N'" + txtSDT.Text + "'";
                dt = data.RunQuery(ssql);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đã nhập/sửa trùng số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSDT.Clear();
                    txtSDT.Focus();
                    return;
                }
            }

            if (modenew == true)
            {
                string ssql = " exec THEMKH N'" + txtTENKH.Text + "',N'" + txtSDT.Text + "',N'" + txtDIACHI.Text + "'";
                data.ExecuteNonQuery(ssql);


            }
            else
            {
                int r = dataGridView1.CurrentRow.Index;
                string khachhang = dataGridView1.Rows[r].Cells[0].Value.ToString();

                string ssql = " exec update_khachhang '" + khachhang + "',N'" + txtTENKH.Text + "',N'" + txtSDT.Text + "',N'" + txtDIACHI.Text + "'";
                data.ExecuteNonQuery(ssql);
            }
            Display();
            setcontrols(true);
            txtTENKH.Clear();
            txtSDT.Clear();
            txtDIACHI.Clear();
            dataGridView1.ClearSelection();

        }

        private void txtTIMKIEM_TextChanged(object sender, EventArgs e)
        {
            string ssql = " select * from khachhang where TENKH LIKE'" + txtTIMKIEM.Text + "%'";
            dt = data.RunQuery(ssql);

            dataGridView1.DataSource = dt;
        }

        private void frmKHACHHANG_DoubleClick(object sender, EventArgs e)
        {
            txtTENKH.Clear();
            txtSDT.Clear();
            txtDIACHI.Clear();
            dataGridView1.ClearSelection();
            txtTIMKIEM.Focus();
        }
    }
}
