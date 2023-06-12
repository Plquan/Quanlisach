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
    public partial class BAOCAOPN : Form
    {
        private DataProviders data;
        private DataTable dt;
        public BAOCAOPN()
        {
            InitializeComponent();
        }

        private void BAOCAOPN_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                cboMONTH.Items.Add(i.ToString());
            }
            for (int i = 2020; i <= 2023; i++)
            {
                cboYEAR.Items.Add(i.ToString());
            }

            data = new DataProviders();
            data.OpenDB();
        }


    

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboMONTH.Text.Trim() == "" && cboYEAR.Text.Trim() == "")
            {
                string ssql1 = "select SOPN,TENNXB,NGAYNHAP,TONGTIEN from PHIEUNHAP pn join NHAXUATBAN nxb on nxb.MANXB = pn.MANXB";
                dt = data.RunQuery(ssql1);
                dataGridView1.DataSource = dt;
                TONGTIEN();
                return;
            }

            if (cboMONTH.Text.Trim() == "")
            {
                string ssql1 = "select SOPN,TENNXB,NGAYNHAP,TONGTIEN from PHIEUNHAP pn join NHAXUATBAN nxb on nxb.MANXB = pn.MANXB where year(NGAYNHAP) = '" + cboYEAR.Text + "'";
                dt = data.RunQuery(ssql1);
                dataGridView1.DataSource = dt;
                TONGTIEN();
                return;
            }

            if (cboYEAR.Text.Trim() == "")
            {
                string ssql1 = "select SOPN,TENNXB,NGAYNHAP,TONGTIEN from PHIEUNHAP pn join NHAXUATBAN nxb on nxb.MANXB = pn.MANXB where month(NGAYNHAP) = '" + cboMONTH.Text + "'";
                dt = data.RunQuery(ssql1);
                dataGridView1.DataSource = dt;
                TONGTIEN();
                return;
            }

            string ssql = "select SOPN,TENNXB,NGAYNHAP,TONGTIEN from PHIEUNHAP pn join NHAXUATBAN nxb on nxb.MANXB = pn.MANXB where month(NGAYNHAP) = '" + cboMONTH.Text + "'and year(NGAYNHAP) = '" + cboYEAR.Text + "'";
            dt = data.RunQuery(ssql);
            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
            TONGTIEN();
        }

        private void TONGTIEN()
        {
            int tong = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                tong = tong + int.Parse(row.Cells[3].Value.ToString());
            }
            txtDOANHTHU.Text = tong.ToString();
        }

        private void BTNTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
