using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DoAn
{
    public partial class frmCTPN : Form
    {
        private DataProviders data;
        private DataTable dt;
        private bool timkiem = true;
        public frmCTPN()
        {
            InitializeComponent();
        }

        private void frmCTPN_Load(object sender, EventArgs e)
        {
            data = new DataProviders();
            data.OpenDB();

            Display();
            dataGridView1.ClearSelection();
        }
        private void Display()
        {
            string ssql = "select SOPN,TENNXB,NGAYNHAP,TONGTIEN from PHIEUNHAP pn join NHAXUATBAN nxb on pn.MANXB = nxb.MANXB";
            dt = data.RunQuery(ssql);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int r = dataGridView1.CurrentRow.Index;
                int sopn = Convert.ToInt32(dataGridView1.Rows[r].Cells[0].Value.ToString());
                string ssql1 = "select ct.MASACH, TENSACH, TENTG, ct.SOLUONG, GIANHAP\r\nfrom SACH s join TACGIA tg on s.MATG = tg.MATG\r\njoin CTPN ct on ct.MASACH = s.MASACH where SOPN = " + sopn;
                dt = data.RunQuery(ssql1);
                dataGridView2.DataSource = dt;
            }
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTIMKIEM_Click(object sender, EventArgs e)
        {
            if (txtTIMKIEM.Text.Trim() == "")
            {
                return;
            }
            if (timkiem == false)
            {
                string ssql1 = "select * from PHIEUNHAP";
                dt = data.RunQuery(ssql1);
                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = null;
                txtTIMKIEM.Text = "";
                btnTIMKIEM.Text = "Tìm Kiếm";
                timkiem = true;
                return;
            }
            string ssql = "select * from PHIEUNHAP where SOPN =" + int.Parse(txtTIMKIEM.Text);
            dt = data.RunQuery(ssql);

            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = null;
            btnTIMKIEM.Text = "Hủy";
            timkiem = false;
        }

        private void btnLAP_Click(object sender, EventArgs e)
        {
            frmPHIEUNHAP frmPHIEUNHAP = new frmPHIEUNHAP();
            frmPHIEUNHAP.FormClosing += new FormClosingEventHandler(frmCTPN_Load);
            frmPHIEUNHAP.ShowDialog();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                dr = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) return;

                int r = dataGridView1.CurrentRow.Index;
                int SOPN = Convert.ToInt32(dataGridView1.Rows[r].Cells[0].Value);
                string ssql1 = "delete from PHIEUNHAP where SOPN = " + SOPN;
                data.ExecuteNonQuery(ssql1);

                Display();

                dataGridView1.ClearSelection();
                dataGridView2.DataSource = null;
            }
            else
            {
                MessageBox.Show("Chọn Dòng Để Xóa!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void frmCTPN_DoubleClick(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView2.DataSource = null;
            txtTIMKIEM.Focus();
        }
    }
}
