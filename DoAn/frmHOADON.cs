using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frmHOADON : Form
    {
        private DataProviders data;
        private DataTable dt;
        public frmHOADON()
        {
            InitializeComponent();
        }

        private void HD_Load(object sender, EventArgs e)
        {
            data = new DataProviders();
            data.OpenDB();

            string ssql = "select * from SACH";
            dt = data.RunQuery(ssql);
            cboTENSACH.DataSource = dt;
            cboTENSACH.DisplayMember = "TENSACH";
            cboTENSACH.ValueMember = "MASACH";

            string ssql3 = "select * from KHACHHANG";
            dt = data.RunQuery(ssql3);
            cboTENKH.DataSource = dt;
            cboTENKH.DisplayMember = "TENKH";
            cboTENKH.ValueMember = "MAKH";

            btnTHEMHD.Enabled = true;
            btnTHEMHD.Focus();
            btnXUAT.Enabled = false;
            btnHUY.Enabled = false;
            btnTHEMSACH.Enabled = false;

            cboTENKH.SelectedIndex = -1;
            cboTENSACH.SelectedIndex = -1;

            cboTENKH.Enabled = false;
            cboTENSACH.Enabled = false;
            txtSOLUONG.Enabled = false;

            txtNGAYLAP.Text = DateTime.Now.ToString("yyyy/MM/dd");

            autoid();
           
        }

        private void autoid()
        {
            string ssql = "select MAX(MAHD) as MAHD from HOADON";
            dt = data.RunQuery(ssql);
            if (dt.Rows[0]["MAHD"] == DBNull.Value)
            {
                txtMAHD.Text = "1";
            }
            else
            {
                int mahd = Convert.ToInt32(dt.Rows[0]["MAHD"]);
                txtMAHD.Text = (mahd + 1).ToString();
            }
        }

        private void btnTHEMSACH_Click(object sender, EventArgs e)
        {
            if(cboTENSACH.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn sách !", "Thông Báo", MessageBoxButtons.OK);
                cboTENSACH.Focus();
                return;
            }

            if (txtSOLUONG.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập số lượng!", "Thông Báo", MessageBoxButtons.OK);
                txtSOLUONG.Focus();
                return;
            }

            if (int.Parse(txtSOLUONG.Text) == 0)
            {
                MessageBox.Show("Số lượng phải nhiều hơn 0 !", "Thông Báo", MessageBoxButtons.OK);
                txtSOLUONG.Focus();
                return;
            }

            int khosach = int.Parse(txtKHO.Text);
            int sluong = int.Parse(txtSOLUONG.Text);
            if(khosach < sluong)
            {
                MessageBox.Show("Số lượng sách trong kho không đủ!", "Thông Báo", MessageBoxButtons.OK);
                txtSOLUONG.Focus();
                return;
            }

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if(cboTENSACH.SelectedValue == row.Cells[0].Value)
                {
                    int kho = int.Parse(txtKHO.Text);
                    int r = int.Parse(row.Cells[2].Value.ToString()) + int.Parse(txtSOLUONG.Text);
                        if(r > kho)
                         {
                        MessageBox.Show("Số lượng sách trong kho không đủ!","Thông Báo", MessageBoxButtons.OK);
                        txtSOLUONG.Focus();
                        return;
                         }
                     row.Cells[2].Value = r ;                      
                     return;
                }
            }
            dataGridView2.Rows.Add(cboTENSACH.SelectedValue,cboTENSACH.Text,txtSOLUONG.Text,txtGIA.Text);
        }

        private void cboMASACH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ssql1 = "select TENSACH,SOLUONG,GIA from SACH where MASACH = '" + cboTENSACH.SelectedValue + "'";
            dt = data.RunQuery(ssql1);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboTENSACH.Text = dt.Rows[i]["TENSACH"].ToString();
                txtGIA.Text = dt.Rows[i]["GIA"].ToString();
                txtKHO.Text = dt.Rows[i]["SOLUONG"].ToString();
                
            }
        }

        private void setcontrol(bool edit)
        {
            btnTHEMHD.Enabled = edit;
            btnTHOAT.Enabled = edit;
            btnXUAT.Enabled = !edit;
            btnHUY.Enabled = !edit;
            btnTHEMSACH.Enabled = !edit;

            cboTENKH.Enabled = !edit;
            cboTENSACH.Enabled = !edit;
            txtSOLUONG.Enabled = !edit;
        }



        private void btnXUAT_Click(object sender, EventArgs e)
        {
            if(cboTENKH.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn khách hàng!", "Thông Báo", MessageBoxButtons.OK);
                cboTENKH.Focus();
                return;
            }
          if(dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Chưa chọn sản phẩm nào!", "Thông Báo", MessageBoxButtons.OK);
                cboTENSACH.Focus();
                return;
            }

            int mahd = Convert.ToInt32(txtMAHD.Text);
            string ssql = "exec THEMHOADON " + mahd + ",'" + cboTENKH.SelectedValue + "','" + txtNGAYLAP.Text + "'," + 0;
            data.ExecuteNonQuery(ssql);

            int tongtien = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
              {
                string masach = row.Cells[0].Value.ToString();
                int soluongmua = Convert.ToInt32(row.Cells[2].Value.ToString());
                int giatien = Convert.ToInt32(row.Cells[3].Value.ToString());

                int thanhtien = giatien * soluongmua;
                string ssql1 = "exec THEMCTHD " + mahd + ",'" + masach + "'," + giatien + "," + soluongmua + "," + thanhtien;
                data.ExecuteNonQuery(ssql1);


                string ssql12 = "select SOLUONG from  sach where MASACH = '" + masach + "'";
                dt = data.RunQuery(ssql12);
                int KHOSACH = int.Parse(dt.Rows[0]["SOLUONG"].ToString());

                int tonkho = KHOSACH - soluongmua;
                string ssql2 = "update  SACH set SOLUONG = " + tonkho + "where MASACH = '" + masach + "'";
                data.ExecuteNonQuery(ssql2);

                tongtien += thanhtien;
            }

            string ssql3 = "update HOADON set TONGTIEN = " + tongtien + "where MAHD = '" + mahd +"'";
            data.ExecuteNonQuery(ssql3);

      
            cboTENKH.SelectedIndex = -1;
            cboTENSACH.SelectedIndex = -1;
            txtSOLUONG.Clear();
            txtGIA.Clear();
            txtKHO.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();        
            setcontrol(true);
            autoid();
            btnTHEMHD.Focus();

            
        }

        private void btnHUY_Click(object sender, EventArgs e)
        {
            setcontrol(true);
            autoid();
            txtGIA.Clear();
            txtKHO.Clear();
            txtSOLUONG.Clear();

            cboTENKH.SelectedIndex = -1;
            cboTENSACH.SelectedIndex = -1;
            btnTHEMHD.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTHEMHD_Click(object sender, EventArgs e)
        {
            setcontrol(false);
            cboTENKH.Focus();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (dataGridView2.Columns[e.ColumnIndex].Name == "DELETE")
                {
                    int r = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString());
                    if (r == 1)
                    {
                        dataGridView2.Rows.RemoveAt(e.RowIndex);
                        return;
                    }
                    dataGridView2.Rows[e.RowIndex].Cells[2].Value = r - 1;
                }
            }
        }

  
    }
}
