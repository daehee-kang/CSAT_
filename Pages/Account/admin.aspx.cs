using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSAT.Pages.Account
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                bool loggedin = (bool)Session["logged"];
                if (loggedin)
                {
                    if ((string)Session["type"] != "administrator")
                    {
                        Response.Redirect("~/Pages/Account/Login.aspx");
                    }
                }
            }
            catch(NullReferenceException ex)
            {
                throw new HttpException(404, "Not Found");
            }
        }
    }
}