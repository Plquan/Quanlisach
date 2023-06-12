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
    public partial class frmSEARCH : Form
    {
        private DataProviders data;
        private DataTable dt;
        public frmSEARCH()
        {
            InitializeComponent();
        }

        private void frmSEARCH_Load(object sender, EventArgs e)
        {
            data = new DataProviders();
            data.OpenDB();

            //goi i ten sach
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
            string ssql = "select TENSACH from SACH";
            dt = data.RunQuery(ssql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                mycollection.Add(dt.Rows[i]["TENSACH"].ToString());
            }
           txtsearch1.AutoCompleteCustomSource = mycollection;
        
            AutoCompleteStringCollection mycollection1 = new AutoCompleteStringCollection();
            string ssql1= "select TENTHELOAI from THELOAI";
            dt = data.RunQuery(ssql1);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                mycollection1.Add(dt.Rows[i]["TENTHELOAI"].ToString());
            }
            txtsearch2.AutoCompleteCustomSource = mycollection1;

            AutoCompleteStringCollection mycollection2 = new AutoCompleteStringCollection();
            string ssql2 = "select TENTG from TACGIA";
            dt = data.RunQuery(ssql2);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                mycollection2.Add(dt.Rows[i]["TENTG"].ToString());
            }
            txtsearch3.AutoCompleteCustomSource = mycollection2;

            AutoCompleteStringCollection mycollection3 = new AutoCompleteStringCollection();
            string ssql3 = "select TENNXB FROM NHAXUATBAN";
            dt = data.RunQuery(ssql3);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                mycollection3.Add(dt.Rows[i]["TENNXB"].ToString());
            }
            txtsearch4.AutoCompleteCustomSource = mycollection3;
        }
        private void btnTK1_Click(object sender, EventArgs e)
        {

            if (txtsearch1.Text.Trim() == "")
            {
                string ssql0 = "select MASACH,TENSACH,TENTG,TENTHELOAI,TENNXB,GIA from sach s join TACGIA tg on s.MATG = tg.MATG \r\njoin THELOAI tl on tl.MALOAI = s.MALOAI\r\njoin NHAXUATBAN nxb on nxb.MANXB = s.MANXB";
                dt = data.RunQuery(ssql0);
                dataGridView1.DataSource = dt;
                return;
            }

            string ssql = "select * from SACH where TENSACH = N'" + txtsearch1.Text + "'";
            dt = data.RunQuery(ssql);
            dataGridView1.DataSource = dt;
        }

        private void btnTK2_Click(object sender, EventArgs e)
        {
            if (txtsearch2.Text.Trim() == "")
            {
                string ssql0 = "select * from THELOAI";
                dt = data.RunQuery(ssql0);
                dataGridView2.DataSource = dt;
                return;
            }
            string ssql = "select * from THELOAI where TENTHELOAI = N'" + txtsearch2.Text + "'";
            dt = data.RunQuery(ssql);
            dataGridView2.DataSource = dt;
        }

        private void btnTK3_Click(object sender, EventArgs e)
        {
            if (txtsearch3.Text.Trim() == "")
            {
                string ssql0 = "select * from TACGIA ";
                dt = data.RunQuery(ssql0);
                dataGridView3.DataSource = dt;
                return;
            }
            string ssql = "select * from TACGIA where TENTG = N'" + txtsearch3.Text + "'";
            dt = data.RunQuery(ssql);
            dataGridView3.DataSource = dt;
        }

        private void btnTK4_Click(object sender, EventArgs e)
        {
            if (txtsearch4.Text.Trim() == "")
            {
                string ssql0 = "select * from NHAXUATBAN ";
                dt = data.RunQuery(ssql0);
                dataGridView4.DataSource = dt;
                return;
            }
            string ssql = "select * from NHAXUATBAN where TENNXB = N'" + txtsearch4.Text + "'";
            dt = data.RunQuery(ssql);
            dataGridView4.DataSource = dt;
        }

        private void btnTHOAT1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTHOAT2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTHOAT3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTHOAT4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
