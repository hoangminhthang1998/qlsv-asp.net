using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Doanbaove
{
    public partial class loginView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            txt_username.Focus();

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            string st_ten, st_pass;
            st_ten = txt_username.Text.Trim();
            st_pass = txt_password.Text.Trim();

            if ((st_ten == "admin") && (st_pass == "1"))
            {
                Session["loginsys"] = st_ten;
                Session["checklogin"] = "logsysuccess";
                Session.Timeout = 5;
                Response.Redirect("~/home.aspx?menu=home");

            }
            else
            {
                lbl_tb.Visible = true;

            }
        }
    }
}