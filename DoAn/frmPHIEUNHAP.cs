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
    public partial class frmPHIEUNHAP : Form
    {
        public string tennxb {get;set;}
        public string tensach { get;set;}

        private DataProviders data;
        private DataTable dt;
        public frmPHIEUNHAP()
        {
            InitializeComponent();
        }

        private void PHIEUNHAP_Load(object sender, EventArgs e)
        {
            data = new DataProviders();
            data.OpenDB();

            string ssql = "select * from NHAXUATBAN";
            dt = data.RunQuery(ssql);
            cboTENNXB.DataSource = dt;
            cboTENNXB.DisplayMember = "TENNXB";
            cboTENNXB.ValueMember = "MANXB";

            txtNGAYNHAP.Text = DateTime.Now.ToString("yyyy/MM/dd");

            cboTENNXB.SelectedIndex = -1;
            cboTENNXB.Text = tennxb;
            cboTENSACH.Text = tensach;

            setcontrol(true);
            autoid();
        }

        private void autoid()
        {
            string ssql = "select MAX(SOPN) as SOPN from PHIEUNHAP";
            dt = data.RunQuery(ssql);
            if (dt.Rows[0]["SOPN"] == DBNull.Value)
            {
                txtSOPN.Text = "1";
            }
            else
            {
                int mahd = Convert.ToInt32(dt.Rows[0]["SOPN"]);
                txtSOPN.Text = (mahd + 1).ToString();
            }
        }

        private void cboTENSACH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ssql = "select TENTHELOAI,TENTG from sach s join THELOAI tl on s.MALOAI = tl.MALOAI join TACGIA tg on tg.MATG = s.MATG where MASACH = '" + cboTENSACH.SelectedValue + "'";
            dt = data.RunQuery(ssql);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                txtTACGIA.Text = dt.Rows[i]["TENTHELOAI"].ToString();
                txtTHELOAI.Text = dt.Rows[i]["TENTG"].ToString();
            }
        }

         public void setcontrol(bool edit)
        {
            btnLAP.Enabled = edit;
            btnTHOAT.Enabled = edit;
            btnGHI.Enabled = !edit;
            btnHUY.Enabled = !edit;
            btnTHEMSACH.Enabled = !edit;

            cboTENNXB.Enabled = edit;
            cboTENSACH.Enabled = !edit;
            txtSOLUONG.Enabled = !edit;
            txtGIANHAP.Enabled = !edit;
        }
        private void btnTHEMSACH_Click(object sender, EventArgs e)
        {
            if(cboTENSACH.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn sách!", "Thông Báo", MessageBoxButtons.OK);
                cboTENSACH.Focus();
                return;
            }
            if(txtGIANHAP.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập giá tiền!", "Thông Báo", MessageBoxButtons.OK);
                txtGIANHAP.Focus();
                return;
            }
            if (txtSOLUONG.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập số lượng!", "Thông Báo", MessageBoxButtons.OK);
                txtSOLUONG.Focus();
                return;
            }
            foreach(DataGridViewRow row in dataGridView2.Rows)
            {
                if (cboTENSACH.SelectedValue == row.Cells[0].Value)
                {
                    row.Cells[3].Value = int.Parse(row.Cells[3].Value.ToString()) + int.Parse(txtSOLUONG.Text);
                    return;
                }
            }

            dataGridView2.Rows.Add(cboTENSACH.SelectedValue, cboTENSACH.Text, txtGIANHAP.Text, txtSOLUONG.Text);
        }

        private void btnHUY_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            cboTENSACH.SelectedIndex = -1;
            cboTENNXB.SelectedIndex = -1;
            txtTACGIA.Clear();
            txtTHELOAI.Clear();
            txtSOLUONG.Clear();
            txtGIANHAP.Clear();
            setcontrol(true);
            btnLAP.Focus();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLAP_Click(object sender, EventArgs e)
        {
            if (cboTENNXB.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn nhà xuất bản!", "Thông Báo", MessageBoxButtons.OK);
                cboTENNXB.Focus();
                return;
            }      
            setcontrol(false);
            cboTENSACH.Focus();
        }

        private void btnGHI_Click(object sender, EventArgs e)
        {  
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Chưa nhập sản phẩm nào!", "Thông Báo", MessageBoxButtons.OK);
                cboTENSACH.Focus();
                return;
            }

            int sopn = int.Parse(txtSOPN.Text);
            string ssql = "exec THEMPHIEUNHAP " + sopn + ",'" + cboTENNXB.SelectedValue + "','" + txtNGAYNHAP.Text + "'," + 0;
            data.ExecuteNonQuery(ssql);

            int tongtien = 0;
               foreach(DataGridViewRow row in dataGridView2.Rows)
              {
                string masach = row.Cells[0].Value.ToString();
                int soluong = Convert.ToInt32(row.Cells[3].Value.ToString());
                int gianhap = Convert.ToInt32(row.Cells[2].Value.ToString());

                int thanhtien = soluong * gianhap;

                string ssql0 = "exec THEMCTPN " + sopn + ",'" + masach + "'," + gianhap + "," + soluong;
                data.ExecuteNonQuery(ssql0);

                string ssql1 = "select SOLUONG from  sach where MASACH = '" + masach + "'";
                dt = data.RunQuery(ssql1);
                int KHOCU = int.Parse(dt.Rows[0]["SOLUONG"].ToString());

                int KHOMOI = KHOCU + soluong;
                string ssql2 = "update  SACH set SOLUONG = " + KHOMOI + "where MASACH = '" + masach + "'";
                data.ExecuteNonQuery(ssql2);


                tongtien += thanhtien;
            }
            
            string ssql3 = "update PHIEUNHAP set TONGTIEN =" + tongtien + "where SOPN = " + sopn;
            data.ExecuteNonQuery(ssql3);

            cboTENSACH.SelectedIndex = -1;
            cboTENNXB.SelectedIndex = -1;
            setcontrol(true);
            autoid();
            btnLAP.Focus();  
            txtTHELOAI.Clear();
            txtTACGIA.Clear();
            txtSOLUONG.Clear();
            txtGIANHAP.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (dataGridView2.Columns[e.ColumnIndex].Name == "DELETE")
                {
                    dataGridView2.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void cboTENNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ssql2 = "select * from SACH where MANXB = '" + cboTENNXB.SelectedValue + "'";
            dt = data.RunQuery(ssql2);
            cboTENSACH.DataSource = dt;
            cboTENSACH.DisplayMember = "TENSACH";
            cboTENSACH.ValueMember = "MASACH";
            cboTENSACH.SelectedIndex = -1;
            txtTACGIA.Clear();
            txtTHELOAI.Clear();
        }
    }
}
