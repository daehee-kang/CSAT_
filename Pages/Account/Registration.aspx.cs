using CSAT.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSAT.Pages.Account
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                bool loggedin = (bool)Session["logged"];
                if (loggedin) { }
            }
            catch(NullReferenceException ex)
            {
                throw new HttpException(404, "Not Found");
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            User user = new User(txtName.Text, txtPassword.Text, txtEmail.Text, "user");

            lblResult.Text = Connection.RegisterUser(user);
        }
    }
}