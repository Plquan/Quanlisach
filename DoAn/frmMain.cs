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
    public partial class frmMain : Form
    {
        private DataProviders data;
        private DataTable dt;
        public frmMain()
        {
            InitializeComponent();
        }

        private void quảnLíKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKHACHHANG frmKHACHHANG = new frmKHACHHANG();
            
            frmKHACHHANG.FormClosing += new FormClosingEventHandler(frmMain_Load);
            frmKHACHHANG.ShowDialog();
        }
        private void quảnLíTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTACGIA frmTACGIA = new frmTACGIA();
            frmTACGIA.FormClosing += new FormClosingEventHandler(frmMain_Load);
            frmTACGIA.ShowDialog();
        }
        private void quảnLíNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNXB frmNXB = new frmNXB();
            frmNXB.FormClosing += new FormClosingEventHandler(frmMain_Load);
            frmNXB.ShowDialog();
        }
        private void sốSáchBánChạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDOANHTHU frmDOANHTHU = new frmDOANHTHU();
            frmDOANHTHU.ShowDialog();
        }
        private void quảnLíThểLoạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTHELOAI frmTHELOAI = new frmTHELOAI();
            frmTHELOAI.FormClosing += new FormClosingEventHandler(frmMain_Load);
            frmTHELOAI.ShowDialog();
        }
        private void quảnLíHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCTHD frmCTHD = new frmCTHD();
            frmCTHD.FormClosing += new FormClosingEventHandler(frmMain_Load);
            frmCTHD.ShowDialog();
        }
        private void quảnLíPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCTPN frmCTPN = new frmCTPN();
            frmCTPN.FormClosing += new FormClosingEventHandler(frmMain_Load);
            frmCTPN.ShowDialog();
        }
     

        private void frmMain_Load(object sender, EventArgs e)
        {        
            data = new DataProviders();
            data.OpenDB();
            

            string ssql2 = "Select * From THELOAI ";
            dt = data.RunQuery(ssql2);
            COLTHELOAI.DataSource = dt;
            COLTHELOAI.DisplayMember = "TENTHELOAI";
            COLTHELOAI.ValueMember = "MALOAI";

            string ssql1 = "Select * From NHAXUATBAN";
            dt = data.RunQuery(ssql1);
            COLNXB.DataSource = dt;
            COLNXB.DisplayMember = "TENNXB";
            COLNXB.ValueMember = "MANXB";

            string ssql = "Select * From TACGIA ";
            dt = data.RunQuery(ssql);
            COLTG.DataSource = dt;
            COLTG.DisplayMember = "TENTG";
            COLTG.ValueMember = "MATG";

            string ssql3 = "Select * From THELOAI ";
            dt = data.RunQuery(ssql3);
            cboLOCTHELOAI.DataSource = dt;
            cboLOCTHELOAI.DisplayMember = "TENTHELOAI";
            cboLOCTHELOAI.ValueMember = "MALOAI";

            Display();
            cboLOCTHELOAI.SelectedIndex = -1;
            dataGridView1.ClearSelection();
         
        }

        private void Display()
        {
            string ssql = "select * from SACH";
            dt = data.RunQuery(ssql);

            dataGridView1.DataSource = dt;
        }


        private void btnTHEMSUA_Click(object sender, EventArgs e)
        {
            frmSACH frmSACH = new frmSACH();
            frmSACH.FormClosed += new FormClosedEventHandler(frmMain_Load);
            frmSACH.ShowDialog();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            DialogResult dr;          
            if (dataGridView1.SelectedCells.Count > 0)
            {
                dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) return;

                int r = dataGridView1.CurrentRow.Index;
                string Masach = dataGridView1.Rows[r].Cells[0].Value.ToString();

                string ssql0 = "delete HOADON from HOADON hd join CHITIETHOADON cthd on cthd.MAHD = hd.MAHD where MASACH = '" + Masach + "'";                         
                string ssql1 = "delete PHIEUNHAP from PHIEUNHAP pn join CTPN ct on pn.SOPN = ct.SOPN where MASACH = '" + Masach+ "'";
                string ssql2 = "delete  from sach where MASACH ='" + Masach + "'";
                data.ExecuteNonQuery(ssql0);
                data.ExecuteNonQuery(ssql1);
                data.ExecuteNonQuery(ssql2);
                Display();
            }
            else
            {
                MessageBox.Show("Chọn dòng để xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void txtTIMKIEM_TextChanged(object sender, EventArgs e)
        {
            string ssql = " select * from sach where TENSACH LIKE N'" + txtTIMKIEM.Text + "%'";
            dt = data.RunQuery(ssql);
            dataGridView1.DataSource = dt;
        }

        private void btnBOLOC_Click(object sender, EventArgs e)
        {
            cboLOCTHELOAI.SelectedIndex = -1;
            Display();
            dataGridView1.ClearSelection();
        }

        private void btnLOC_Click(object sender, EventArgs e)
        {
            if (cboLOCTHELOAI.Text.Trim() == "")
            {               
                cboLOCTHELOAI.Focus();
                return;
            }
            string ssql = " select * from sach where MALOAI ='" + cboLOCTHELOAI.SelectedValue + "'";
            dt = data.RunQuery(ssql);
            dataGridView1.DataSource = dt;
        }

        private void btnCAPNHAT_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc chắn muốn cập nhật không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int r = dataGridView1.CurrentRow.Index;
                string Masach = row.Cells[0].Value.ToString();
                string tensach = row.Cells[1].Value.ToString();
                string matg = row.Cells[2].Value.ToString();
                string matl = row.Cells[3].Value.ToString();
                string manxb = row.Cells[4].Value.ToString();
                int gia = int.Parse(row.Cells[5].Value.ToString());
                string ssql ="exec update_sach '"+Masach+"',N'"+ tensach +"','" + matg + "','" + matl +"','"+ manxb +"',"+ gia;
                data.ExecuteNonQuery(ssql);
            }
            Display();
            dataGridView1.ClearSelection();          
        }

        private void frmMain_DoubleClick(object sender, EventArgs e)
        {
            Display();
            dataGridView1.ClearSelection();
        }


        private void thốngKêTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTONKHO frmTONKHO = new frmTONKHO();
            frmTONKHO.FormClosing += new FormClosingEventHandler(frmMain_Load);
            frmTONKHO.ShowDialog();
        }

        private void báoCáoNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
         BAOCAOPN bAOCAOPN = new BAOCAOPN();
            bAOCAOPN.ShowDialog();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSEARCH frmSEARCH = new frmSEARCH();
            frmSEARCH.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
