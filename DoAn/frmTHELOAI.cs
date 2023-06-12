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
    public partial class frmTHELOAI : Form
    {
        private DataProviders data;
        private DataTable dt;
        private SqlCommand mycommand;
        private bool modenew;
        private string oldname;
        public frmTHELOAI()
        {
            InitializeComponent();
        }

        private void frmTHELOAI_Load(object sender, EventArgs e)
        {
            txtTENTL.Enabled = false;
            txtMOTATL.Enabled = false;

            btnTHEM.Enabled = true;
            btnSUA.Enabled = true;
            btnXOA.Enabled = true;
            btnLUU.Enabled = false;
            btnHUY.Enabled = false;
            btnTHOAT.Enabled = true;

            btnTHEM.Focus();
            data = new DataProviders();
            data.OpenDB();
            Display();

            txtTENTL.Clear();
            txtMOTATL.Clear();
            dataGridView1.ClearSelection();
        }

        private void Display()
        {      
                string ssql = "select * from THELOAI";
                dt = data.RunQuery(ssql);

                dataGridView1.DataSource = dt;
        }

        private void setcontrols(bool edit)
        {
            txtTENTL.Enabled = !edit;
            txtMOTATL.Enabled = !edit;

            btnTHEM.Enabled = edit;
            btnSUA.Enabled = edit;
            btnXOA.Enabled = edit;
            btnLUU.Enabled = !edit;
            btnHUY.Enabled = !edit;
            btnTHOAT.Enabled = edit;
        }

        private void btnTHEM_Click_1(object sender, EventArgs e)
        {
            txtTENTL.Clear();
            txtMOTATL.Clear();         
            setcontrols(false);
            txtTENTL.Focus();
            modenew = true;
        }
        private void btnSUA_Click(object sender, EventArgs e)
        {
            setcontrols(false);
            txtTENTL.Focus();
            modenew = false;
        }
        private void btnXOA_Click(object sender, EventArgs e)
        {
            DialogResult dr;
        
            if (dataGridView1.SelectedCells.Count > 0)
            {
                dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) return;
                int r = dataGridView1.CurrentRow.Index;
                string Maloai = dataGridView1.Rows[r].Cells[0].Value.ToString();

                string ssql1 = "delete PHIEUNHAP from PHIEUNHAP pn join CTPN ct on pn.SOPN = ct.SOPN join sach s on s.MASACH = ct.MASACH where MALOAI = '" + Maloai + "'";
                string ssql2 = "delete HOADON from HOADON hd join CHITIETHOADON cthd on cthd.MAHD = hd.MAHD join sach s on  s.MASACH = cthd.MASACH where MALOAI = '" + Maloai + "'";             
                string ssql3 = "delete from THELOAI where MALOAI = '" + Maloai + "'";

                data.ExecuteNonQuery(ssql1);   
                data.ExecuteNonQuery(ssql2);
                data.ExecuteNonQuery(ssql3);

                txtTENTL.Clear();
                txtMOTATL.Clear();
                Display();
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Dòng Để Xóa!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }

        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtTENTL.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMOTATL.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            oldname = txtTENTL.Text;
        }

        private void btnTHOAT_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHUY_Click(object sender, EventArgs e)
        {
         setcontrols(true);
            dataGridView1.ClearSelection();
            txtTENTL.Clear();
            txtMOTATL.Clear();
        }


        private void btnLUU_Click_1(object sender, EventArgs e)
        {
            if (txtTENTL.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa  nhập tên thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTENTL.Focus();
                setcontrols(false);
                return;
            }
            if (txtTENTL.Text.Trim().Length > 50)
            {
                MessageBox.Show("Kí tự nhập vao vượt quá số lượng cho phép!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTENTL.Focus();
                return;
            }


            if ((modenew == true) || ((modenew == false) && (txtTENTL.Text != oldname)))
            {

                string ssql = "SELECT TENTHELOAI FROM THELOAI  WHERE TENTHELOAI  = N'" + txtTENTL.Text + "'";
                dt = data.RunQuery(ssql);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đã nhập/sửa trùng tên thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTENTL.Clear();
                    txtTENTL.Focus();
                    return;
                }
            }


            if (modenew == true)
            {
                string ssql = " exec THEMTHELOAI N'" + txtTENTL.Text + "',N'" + txtMOTATL.Text + "'";
                data.ExecuteNonQuery(ssql);


            }
            else
            {
                int r = dataGridView1.CurrentRow.Index;
                string Maloai = dataGridView1.Rows[r].Cells[0].Value.ToString();

                string ssql = " exec update_theloai '" + Maloai + "',N'" + txtTENTL.Text + "',N'" + txtMOTATL.Text + "'";
                data.ExecuteNonQuery(ssql);


            }
            Display();
            setcontrols(true);
            txtTENTL.Clear();
            txtMOTATL.Clear();
            dataGridView1.ClearSelection();
        }

        private void txtTIMKIEM_TextChanged(object sender, EventArgs e)
        {
            string ssql = " select * from THELOAI  where TENTHELOAI LIKE N'" + txtTIMKIEM.Text + "%'";
            dt = data.RunQuery(ssql);
            dataGridView1.DataSource = dt;
        }

        private void frmTHELOAI_DoubleClick(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            txtTENTL.Clear();
            txtMOTATL.Clear();
            txtTIMKIEM.Clear();       
            txtTIMKIEM.Focus();
        }
    }
}
