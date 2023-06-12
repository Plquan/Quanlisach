using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frmDOANHTHU : Form
    {
        private DataProviders data;
        private DataTable dt;
        
        public frmDOANHTHU()
        {
            InitializeComponent();
        }

        private void frmTKSACH_Load(object sender, EventArgs e)
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
             if(cboMONTH.Text.Trim() == "" && cboYEAR.Text.Trim() == "")
            {
                string ssql1 = "select MAHD,NGAYLAP,TONGTIEN from HOADON";
                dt = data.RunQuery(ssql1);
                dataGridView1.DataSource = dt;
                TONGTIEN();
                return;
            }

            if (cboMONTH.Text.Trim() == "")
            {
                string ssql1 = "select MAHD,NGAYLAP,TONGTIEN from HOADON where year(NGAYLAP) = '" + cboYEAR.Text + "'";
                dt = data.RunQuery(ssql1);
                dataGridView1.DataSource = dt;
                TONGTIEN();
                return;
            }

            if (cboYEAR.Text.Trim() == "")
            {
                string ssql1 = "select MAHD,NGAYLAP,TONGTIEN from HOADON where month(NGAYLAP) = '" + cboMONTH.Text + "'";
                dt = data.RunQuery(ssql1);
                dataGridView1.DataSource = dt;
                TONGTIEN();
                return;
            }

            string ssql = "select MAHD,NGAYLAP,TONGTIEN from HOADON where month(NGAYLAP) = '" + cboMONTH.Text + "'and year(NGAYLAP) = '" + cboYEAR.Text + "'";
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
               tong = tong + int.Parse(row.Cells[2].Value.ToString());
            }
            txtDOANHTHU.Text = tong.ToString();
        }

        private void BTNTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
