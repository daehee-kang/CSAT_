using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSAT.Pages
{
    public partial class CSATOverview : System.Web.UI.Page
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

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {

        }
    }
}