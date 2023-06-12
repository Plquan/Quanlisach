using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    internal class DataProviders
    {
        private string strcon = "Data Source=DESKTOP-3HS6DDJ\\SQLEXPRESS;Initial Catalog=QLSACH;Integrated Security=True";
        private SqlConnection mycon;
        private SqlDataAdapter myadapter;

        public bool OpenDB()
        {
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
            }
            catch (SqlException ex)
            {
                DisplayError(ex);
                mycon = null;
                return false;
            }
            return true;
        }

        public DataTable RunQuery(string ssql)
        {
            DataTable myDataTable = new DataTable();
            myadapter = new SqlDataAdapter();
            try
            {
                myadapter = new SqlDataAdapter(ssql, mycon);
                SqlCommandBuilder mySqlCommandBuilder = new SqlCommandBuilder(myadapter);
                myadapter.Fill(myDataTable);
            }
            catch (SqlException ex)
            {
                DisplayError(ex);
                return null;
            }
            return myDataTable;
        }

        public void Update(DataTable myDataTable)
        {
            try
            {
                myadapter.Update(myDataTable);
            }
            catch (SqlException ex)
            {
                DisplayError(ex);
            }
        }
        public void ExecuteNonQuery(string cmdString)
        {
            SqlCommand mySqlCommand = new SqlCommand(cmdString, mycon);
            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                DisplayError(ex);
            }
        }

        public void DisplayError(SqlException ex)
        {
            string sSql = "SELECT * FROM ERROR WHERE Number = " + ex.Number;
            DataTable dtError = RunQuery(sSql);
            if (dtError.Rows.Count > 0)
                MessageBox.Show(dtError.Rows[0][1].ToString().Trim(), "Lỗi " + ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(ex.Message, "Error " + ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
