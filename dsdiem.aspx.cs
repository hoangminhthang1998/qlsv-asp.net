using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Doanbaove.AllClass;

namespace Doanbaove
{
    public partial class dsdiem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public class AddMHDAL
        {
            
            Clsconnect dataConnec;
            SqlCommand cmd;
            SqlDataReader re;
            public Boolean ktraMaSV(string maSV)
            {
                bool check = true;
                string query = "SELECT COUNT(MaSv) FROM dbo.tbl_sinhvien WHERE Masv = " + maSV;
                dataConnec.connect_Data();
                cmd = new SqlCommand(query, dataConnec.con);
                int check1 = (int)cmd.ExecuteScalar();
                if (check1 == 0) check = false;
                dataConnec.close_Data();
                return check;
            }
            public AddMHDAL()
            {
                dataConnec = new Clsconnect();

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            AddMHDAL mh = new AddMHDAL();

            if (mh.ktraMaSV(txtMaSV.Text) == true)
            {
                string url = "~/dsdiem2.aspx?user=" + txtMaSV.Text;
                Response.Redirect(url);
            }
            else
            {
                Label1.Text = "Không có Mã sinh viên này";
                Label1.Visible = true;
            }
        }
    }
}