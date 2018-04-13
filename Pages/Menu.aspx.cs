using CSAT.App_Code;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSAT.Pages
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }

        private void FillPage()
        {
            ArrayList foodList = Connection.GetFoodByType(!IsPostBack ? "%" : selectType.SelectedValue);
            StringBuilder sb = new StringBuilder();

            foreach (App_Code.Food food in foodList)
            {
                //< th rowspan = '6' width = '150px' >< img runat = 'server' src = '{6}' /></ th >
                //< th width = '50px' > Name: </ td >
                              sb.Append(
                    string.Format(
                        @"<table class='foodTable'>
            <tr>
                <th rowspan='6' width='150px'><img runat='server' src='{3}' /></th>
                <th width='50px'>Name: </td>
                <td>{0}</td>
            </tr>

            <tr>
                <th>Type: </th>
                <td>{1}</td>
            </tr>

            <tr>
                <th>Price: </th>
                <td>$ {2}</td>
            </tr>

            <tr>
                <th>Ingredients: </th>
                <td>{4}</td>
            </tr>

            <tr>
                <th>Description: </th>
                <td>{5}</td>
            </tr>        
            
           </table>", food.Name, food.Type, food.Price, food.Image, food.Ingredient, food.Description));
                lblMenu.Text = sb.ToString();
            }
        }

        protected void selectType_SelectedIndexChanged1(object sender, EventArgs e)
        {
            FillPage();
        }
    }
}