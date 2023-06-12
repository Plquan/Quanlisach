using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frmNXB : Form
    {
        private BookEntity book;
        private DataProviders data;
        private DataTable dt;
        private bool modenew;
        private string oldname;
        public frmNXB()
        {          
            InitializeComponent();
        }

        private void frmNXB_Load(object sender, EventArgs e)
        {
            txtTENNXB.Enabled = false;
            txtDIACHI.Enabled = false;

            btnTHEM.Enabled = true;
            btnSUA.Enabled = true;
            btnXOA.Enabled = true;
            btnLUU.Enabled = false;
            btnHUY.Enabled = false;
            btnTHOAT.Enabled = true;

            btnTHEM.Focus();
            data = new DataProviders();
            data.OpenDB();
           
            book = new BookEntity();
            Display();

            txtTENNXB.Clear();
            txtDIACHI.Clear();
            dataGridView1.ClearSelection();

        }
        private void Display()
        {

            var query = from i in book.NHAXUATBANs
                        select new {                     
                            i.MANXB,
                            i.TENNXB,
                            i.DIACHI
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtTENNXB.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDIACHI.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            oldname = txtTENNXB.Text;
        }
        private void setcontrols(bool edit){
            txtTENNXB.Enabled = !edit;
            txtDIACHI.Enabled = !edit;

                btnTHEM.Enabled = edit;
                btnSUA.Enabled = edit;
                btnXOA.Enabled = edit;
                btnLUU.Enabled = !edit;
                btnHUY.Enabled = !edit;
                btnTHOAT.Enabled = edit;
            }

        private void btnTHEM_Click_1(object sender, EventArgs e)
        {
            txtTENNXB.Clear();
            txtDIACHI.Clear();
            setcontrols(false);
            modenew = true;
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            txtTENNXB.Focus();
            setcontrols(false);
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
                string MaNXB = dataGridView1.Rows[r].Cells[0].Value.ToString();
                var delete = new BookEntity();

                var query1 = (from i in book.PHIEUNHAPs
                             where (i.MANXB == MaNXB)
                             select i);             
                book.PHIEUNHAPs.RemoveRange(query1);
                

                var query2 = from i in book.HOADONs
                             join j in book.CHITIETHOADONs on i.MAHD equals j.MAHD
                             join f in book.SACHes on j.MASACH equals f.MASACH
                             where (f.MANXB == MaNXB)
                             select i;                             
                   book.HOADONs.RemoveRange(query2);
                    
                              
                

                var query4 = from i in book.NHAXUATBANs
                             where (i.MANXB == MaNXB)
                             select i;
                book.NHAXUATBANs.Remove(query4.FirstOrDefault());

                book.SaveChanges();              
                Display();
                txtTENNXB.Clear();
                txtDIACHI.Clear();
                dataGridView1.ClearSelection();
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
            dataGridView1.ClearSelection();
            txtTENNXB.Clear();
            txtDIACHI.Clear();
          
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNXB_DoubleClick(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            txtTENNXB.Clear();
            txtDIACHI.Clear();
            txtTIMKIEM.Clear();
            txtTIMKIEM.Focus();
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            if (txtTENNXB.Text.Trim() == "")
            {
                MessageBox.Show("Vui Lòng Nhập Tên Nhà Xuất Bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTENNXB.Focus();
                return;
            }
            if (txtTENNXB.Text.Trim().Length > 50)
            {
                MessageBox.Show("Kí tự nhập vao vượt quá số lượng cho phép!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTENNXB.Focus();
                return;
            }
            if(modenew == true || modenew == false && oldname != txtTENNXB.Text)
            {
                var query = from i in book.NHAXUATBANs
                            where i.TENNXB == txtTENNXB.Text
                            select i;
                if(query.Count() > 0)
                {
                    MessageBox.Show("Đã nhập/sửa trùng tên thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTENNXB.Clear();
                    txtTENNXB.Focus();
                    return;
                }
            }
            if(modenew == true)
            {
                book.THEMNXB(txtTENNXB.Text, txtDIACHI.Text);
                
            }
            if(modenew == false)
            {
                int r = dataGridView1.CurrentRow.Index;
                string MaNXB = dataGridView1.Rows[r].Cells[0].Value.ToString();
                book.update_nhaxuatban(MaNXB,txtTENNXB.Text,txtDIACHI.Text);
            }

            Display();
            setcontrols(true);
            
            dataGridView1.ClearSelection();
            txtTENNXB.Clear();
            txtDIACHI.Clear();
            txtTIMKIEM.Clear();

        }

  
        private void txtTIMKIEM_TextChanged_1(object sender, EventArgs e)
        {
            string ssql = " select * from NHAXUATBAN where TENNXB LIKE N'" + txtTIMKIEM.Text + "%'";
            dt = data.RunQuery(ssql);
            dataGridView1.DataSource = dt;
        }
    }
}
