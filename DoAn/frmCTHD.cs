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
    public partial class frmCTHD : Form
    {
        private DataProviders data;
        private DataTable dt;
        private int oldsl;
        private bool timkiem = true;
        public frmCTHD()
        {

            InitializeComponent();
        }

private void frmCTHD_Load(object sender, EventArgs e)
        {        
            data = new DataProviders();
            data.OpenDB();

            Display();
            dataGridView1.ClearSelection();
        }

     private  void Display()
        {          
            string ssql = "select * from HOADON";
            dt = data.RunQuery(ssql);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int r = dataGridView1.CurrentRow.Index;
               int  mahd = Convert.ToInt32(dataGridView1.Rows[r].Cells[0].Value.ToString());
                string ssql1 = "select cthd.MASACH,TENSACH,TENTHELOAI,cthd.SOLUONG,cthd.GIATIEN,cthd.THANHTIEN from CHITIETHOADON cthd join sach s on cthd.MASACH = s.MASACH\r\njoin THELOAI tl on tl.MALOAI = s.MALOAI where MAHD = " + mahd ;
                dt = data.RunQuery(ssql1);
                dataGridView2.DataSource = dt;
               
            }
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            DialogResult dr;        
            if(dataGridView1.SelectedCells.Count > 0)
            {
                dr = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) return;

                int r = dataGridView1.CurrentRow.Index;
               int MaHD =   Convert.ToInt32(dataGridView1.Rows[r].Cells[0].Value);         
                string ssql1 = "delete from HOADON where MAHD = " + MaHD ;               
                data.ExecuteNonQuery(ssql1);
 
                Display();
            
                dataGridView1.ClearSelection();
                dataGridView2.DataSource = null;
            }
            else
            {
                MessageBox.Show("Chọn Dòng Để Xóa!","Thông Báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void frmCTHD_DoubleClick(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();      
            dataGridView2.DataSource = null;
            txtTIMKIEM.Focus();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (txtTIMKIEM.Text.Trim() == "")
            {
                return;
            }
            if (timkiem == false)
            {
                string ssql1 = "select * from HOADON";
                dt = data.RunQuery(ssql1);
                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = null;
                txtTIMKIEM.Text = "";
                btnTIMKIEM.Text = "Tìm Kiếm";
                timkiem = true;
                return;
            }
            string ssql = "select * from HOADON where MAHD =" + int.Parse(txtTIMKIEM.Text);
                dt = data.RunQuery(ssql);
                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = null;
                btnTIMKIEM.Text = "Hủy";
                timkiem = false;
                    
        }

        private void btnLAP_Click(object sender, EventArgs e)
        {
            frmHOADON frmHOADON = new frmHOADON();
            frmHOADON.FormClosing += new FormClosingEventHandler(frmCTHD_Load);
            frmHOADON.ShowDialog();
        }
    }
}
