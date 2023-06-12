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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void frmSACHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSACH frmSACH = new frmSACH();
            frmSACH.ShowDialog();
        }

        private void frmTACGIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTACGIA frmTACGIA = new frmTACGIA();
            frmTACGIA.ShowDialog();
        }

        private void frmNHANVIENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNHANVIEN frmNHANVIEN = new frmNHANVIEN();
            frmNHANVIEN.ShowDialog();

        }

        private void frmKHACHHANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKHACHHANG frmKHACHHANG = new frmKHACHHANG(); 
            frmKHACHHANG.ShowDialog();
        }

        private void tHELOAIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTHELOAI frmTHELOAI = new frmTHELOAI();
            frmTHELOAI.ShowDialog();
        }

        private void nxbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNXB frm = new frmNXB();
            frm.ShowDialog();
        }

        private void haodonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHOADON frm = new frmHOADON();
            frm.ShowDialog();
        }

        private void chiTietHoadonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCTHD frm = new frmCTHD();
            frm.ShowDialog();
        }
    }
}
