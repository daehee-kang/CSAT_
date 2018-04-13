using CSAT.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSAT.Pages.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            User user = Connection.LoginUser(txtLogin.Text, txtPassword.Text);

            if(user != null)
            {
                Session["login"] = user.Login;
                Session["type"] = user.Type;
                Session["logged"] = true;

                Response.Redirect("~/Pages/Account/ManageOption.aspx");
            }
            else
            {
                lblError.Text = "Login Failed";
            }
        }
    }
}