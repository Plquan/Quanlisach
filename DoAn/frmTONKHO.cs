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
    public partial class frmTONKHO : Form
    {
      
        private DataProviders data;
        private DataTable dt;
        public frmTONKHO()
        {
            InitializeComponent();

        }
        
        private void frmTONKHO_Load(object sender, EventArgs e)
        {
            btnNHAP.Enabled = false;
            data = new DataProviders();
            data.OpenDB();
        }

        private void btnTHONGKE_Click(object sender, EventArgs e)
        {
            string ssql = "select MASACH,TENSACH,TENNXB,SOLUONG FROM SACH S JOIN NHAXUATBAN nxb on s.MANXB = nxb.MANXB";
            dt = data.RunQuery(ssql);

            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
            btnNHAP.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedCells.Count > 0){
            btnNHAP.Enabled = true;
            }
        }

        private void btnNHAP_Click(object sender, EventArgs e)
        {
            frmPHIEUNHAP frm = new frmPHIEUNHAP();
            frm.FormClosing += new FormClosingEventHandler(btnTHONGKE_Click);
            int r = dataGridView1.CurrentRow.Index;
            string tennxb = dataGridView1.Rows[r].Cells[2].Value.ToString();
            string tensach = dataGridView1.Rows[r].Cells[1].Value.ToString();
            frm.tennxb = tennxb;
            frm.tensach = tensach;
            frm.Show();
            frm.setcontrol(false);
        }

        private void BTNTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTONKHO_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            btnNHAP.Enabled = false;
        }
    }
}
