using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAn
{
    public partial class frmSACH : Form
    {   

        private DataProviders data;
        private DataTable dt;
        public frmSACH()
        {
            InitializeComponent();
        }
        private void frmSACH_Load(object sender, EventArgs e)
        {
            txtTENSACH.Enabled = false;
            cboNXB.Enabled = false;
            cboTACGIA.Enabled = false;
            cboTHELOAI.Enabled = false;
            txtGIA.Enabled = false;


            btnTHEM.Enabled = true;  
            btnLUU.Enabled = false;
            btnHUY.Enabled = false;
            btnTHOAT.Enabled = true;

            // mở Kết Nối 
            data = new DataProviders();
            data.OpenDB();
          
            // Lấy Giá trị ComboBox
            string ssql = "Select * From TACGIA Order By TENTG";
            dt = data.RunQuery(ssql);
            cboTACGIA.DataSource = dt;
            cboTACGIA.DisplayMember = "TENTG";
             cboTACGIA.ValueMember = "MATG";

            string ssql1 = "Select * From NHAXUATBAN Order By TENNXB";
            dt = data.RunQuery(ssql1);
            cboNXB.DataSource = dt;
            cboNXB.DisplayMember = "TENNXB";
            cboNXB.ValueMember = "MANXB";

            string ssql2 = "Select * From THELOAI Order By TENTHELOAI";
            dt = data.RunQuery(ssql2);
            cboTHELOAI.DataSource = dt;
            cboTHELOAI.DisplayMember = "TENTHELOAI";
            cboTHELOAI.ValueMember = "MALOAI";
     
            cboTACGIA.SelectedIndex = -1;
            cboTHELOAI.SelectedIndex = -1;
            cboNXB.SelectedIndex = -1;
        
            txtTENSACH.Clear();
            txtGIA.Clear();


        }
  
        public void setcontrols(bool edit)
        {
            txtTENSACH.Enabled = !edit;
            cboNXB.Enabled = !edit;
            cboTACGIA.Enabled = !edit;
            cboTHELOAI.Enabled = !edit;
            txtGIA.Enabled = !edit;
            btnTHEM.Enabled = edit;
      
            btnLUU.Enabled = !edit;
            btnHUY.Enabled = !edit;
            btnTHOAT.Enabled = edit;
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {                
            setcontrols(false);

            cboTACGIA.SelectedIndex = -1;
            cboTHELOAI.SelectedIndex = -1;
            cboNXB.SelectedIndex = -1;  

            txtTENSACH.Clear();
            txtGIA.Clear();
     
            txtTENSACH.Focus();
        }
        
  
        private void btnHUY_Click(object sender, EventArgs e)
        {
            cboTACGIA.SelectedIndex = -1;
            cboTHELOAI.SelectedIndex = -1;
            cboNXB.SelectedIndex = -1;
            txtTENSACH.Clear();
            txtGIA.Clear();

            setcontrols(true);
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLUU_Click(object sender, EventArgs e)
        { 
         
            if(txtTENSACH.Text.Trim().Length > 50)
            {
                MessageBox.Show("Kí tự nhập vao vượt quá số lượng cho phép!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTENSACH.Focus();
                return;
            }
            if (txtTENSACH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTENSACH.Focus();
                return;
            }
            if (txtGIA.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập giá tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGIA.Focus();
                return;
            }

            if (cboTHELOAI.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboTHELOAI.Focus();
                return;
            }
            if (cboTACGIA.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn tác giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboTACGIA.Focus();
                return;
            }
            if (cboNXB.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboNXB.Focus();
                return;
            }

            string ssql = "SELECT TENSACH FROM SACH WHERE TENSACH = N'" + txtTENSACH.Text + "'";
                dt = data.RunQuery(ssql);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đã nhập trùng tên loại sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTENSACH.Clear();
                    txtTENSACH.Focus();
                    return;
                }
                  
             string ssql1 = "exec THEMSACH N'"+txtTENSACH.Text + "','" + cboTACGIA.SelectedValue + "','" +cboTHELOAI.SelectedValue + "','" + cboNXB.SelectedValue +"','" +txtGIA.Text +"',"+ 0 ;
              data.ExecuteNonQuery(ssql1);
            
            txtTENSACH.Clear();   
            txtGIA.Clear();
            cboTACGIA.SelectedIndex = -1;
            cboTHELOAI.SelectedIndex = -1;
            cboNXB.SelectedIndex = -1;
            setcontrols(true);
        }

        private void frmSACH_DoubleClick(object sender, EventArgs e)
        {     
            cboTACGIA.SelectedIndex = -1;
            cboTHELOAI.SelectedIndex = -1;
            cboNXB.SelectedIndex = -1;

            txtTENSACH.Clear();
            txtGIA.Clear();
      
        }





    }
}
