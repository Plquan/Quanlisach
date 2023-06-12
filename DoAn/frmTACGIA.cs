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
    public partial class frmTACGIA : Form
    {
        private DataProviders data;
        private DataTable dt;
        private SqlCommand mycommand;
        private bool modenew;
        private string oldname;
        public frmTACGIA()
        {
            InitializeComponent();
        }

        private void frmTACGIA_Load(object sender, EventArgs e)
        {
            txtTENTG.Enabled = false;
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

           txtTENTG.Clear();
            txtSDT.Clear();
            txtDIACHI.Clear();
            dataGridView1.ClearSelection();
           
        }

        private void Display()
        {         
                string ssql = "select * from TACGIA";
                dt = data.RunQuery(ssql);
                dataGridView1.DataSource = dt;         
        }
        private void setcontrols(bool edit)
        {
            txtTENTG.Enabled = !edit;
            txtSDT.Enabled = !edit;
            txtDIACHI.Enabled= !edit;

            btnTHEM.Enabled = edit;
            btnSUA.Enabled = edit;
            btnXOA.Enabled = edit;
            btnLUU.Enabled = !edit;
            btnHUY.Enabled = !edit;
            btnTHOAT.Enabled = edit;
        }
        private void btnTHEM_Click(object sender, EventArgs e)
        {
            txtTENTG.Clear();
            txtSDT.Clear();
            txtDIACHI.Clear();
            
            setcontrols(false);
            txtTENTG.Focus();
            modenew = true;
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {        
            setcontrols(false);
            modenew = false;
            txtTENTG.Focus();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            DialogResult dr;         
                if (dataGridView1.SelectedCells.Count > 0)
                {
                dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) return;

                int r = dataGridView1.CurrentRow.Index;
                string matg = dataGridView1.Rows[r].Cells[0].Value.ToString();

                string ssql1 = "delete PHIEUNHAP from PHIEUNHAP pn join CTPN ct on pn.SOPN = ct.SOPN join sach s on s.MASACH = ct.MASACH where MATG = '" + matg + "'";
                string ssql2 = "delete HOADON from HOADON hd join CHITIETHOADON cthd on cthd.MAHD = hd.MAHD join sach s on  s.MASACH = cthd.MASACH where MATG = '" + matg + "'";          
                string ssql3 = "delete from TACGIA where MATG = '" + matg + "'";
                data.ExecuteNonQuery(ssql1);         
                data.ExecuteNonQuery(ssql2);
                data.ExecuteNonQuery(ssql3);

                Display(); 
                txtTENTG.Clear();
                txtSDT.Clear();
                txtDIACHI.Clear();
            }
                else
                {
                    MessageBox.Show("Vui Lòng Chọn Dòng Để Xóa!", "Thông Báo", MessageBoxButtons.OK);
                    return;
                }           
        }

        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            txtTENTG.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDIACHI.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            oldname = txtTENTG.Text;
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHUY_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            txtTENTG.Clear();
            txtSDT.Clear();
            txtDIACHI.Clear();
            setcontrols(true);
    
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            if (txtTENTG.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa  nhập tên tác giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTENTG.Focus();
                setcontrols(false);
                return;
            }
            if (txtTENTG.Text.Trim().Length > 50)
            {
                MessageBox.Show("Kí tự nhập vao vượt quá số lượng cho phép!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTENTG.Focus();
                return;
            }


            if ((modenew == true) || ((modenew == false) && (txtTENTG.Text != oldname)))
            {          
                string ssql = "SELECT TENTG FROM TACGIA WHERE TENTG = N'" + txtTENTG.Text + "'";
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
                string ssql = " exec THEMTACGIA N'" + txtTENTG.Text + "','" + txtSDT.Text + "',N'" + txtDIACHI.Text + "'";              
              data.ExecuteNonQuery(ssql);


            }
            if(modenew == false)
            {
                int r = dataGridView1.CurrentRow.Index;
                string tacgia = dataGridView1.Rows[r].Cells[0].Value.ToString();
                string ssql = " exec update_tacgia '" + tacgia + "',N'" + txtTENTG.Text + "','" + txtSDT.Text + "',N'" + txtDIACHI.Text + "'";
                data.ExecuteNonQuery(ssql);

             
            }

            Display();
            setcontrols(true);
            dataGridView1.ClearSelection();

            txtTENTG.Clear();
            txtSDT.Clear();
            txtDIACHI.Clear();
        }

        private void frmTACGIA_DoubleClick(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            txtTENTG.Clear();
            txtSDT.Clear();
            txtDIACHI.Clear();
            txtTIMKIEM.Focus();
        }

        private void txtTIMKIEM_TextChanged(object sender, EventArgs e)
        {
            string ssql = " select * from tacgia where TENTG LIKE N'" + txtTIMKIEM.Text + "%'";
            dt = data.RunQuery(ssql);
            dataGridView1.DataSource = dt;
        }

    
    }
}
