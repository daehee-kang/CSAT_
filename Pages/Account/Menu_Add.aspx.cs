using CSAT.App_Code;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSAT.Pages
{
    public partial class Menu_Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                bool loggedin = (bool)Session["logged"];
                if (loggedin)
                {
                    string selectedType = ddlType.SelectedValue;
                    ddlType.DataSource = Enum.GetNames(typeof(Food_Type));
                    ddlType.DataBind();
                    ddlType.SelectedValue = selectedType;
                    string selectedImg = ddlImage.SelectedValue;
                    ShowImages();
                    ddlImage.SelectedValue = selectedImg;
                }
            }
            catch(NullReferenceException ex)
            {
                throw new HttpException(404, "Not Found");
            }
        }

        private void ShowImages()
        {
            string[] images = Directory.GetFiles(Server.MapPath("~/Image/"));

            ArrayList imageList = new ArrayList();
            imageList.Add("");
            foreach (string i in images){
                string imageName = i.Substring(i.LastIndexOf(@"\") + 1);
                imageList.Add(imageName);
            }

            ddlImage.DataSource = imageList;
            ddlImage.DataBind();
        }

        private void ClearTextFields()
        {
            txtDesc.Text = "";
            txtIngredient.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
        }
        protected void btnUploadImg_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = Path.GetFileName(FileUpload1.FileName);
                FileUpload1.SaveAs(Server.MapPath("~/Image/") + filename);
                lblResult.Text = "Image " + filename + " successfully uploaded";
                Page_Load(sender, e);
            }
            catch (Exception)
            {
                lblResult.Text = "Upload failed";
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                Food_Type type = (Food_Type) Enum.Parse(typeof(Food_Type), ddlType.SelectedValue, true);
                double price = Convert.ToDouble(txtPrice.Text);
                string image = "../Image/" + ddlImage.SelectedValue;
                string ingredient = txtIngredient.Text;
                string desc = txtDesc.Text;

                Food food = new Food(name, type, price, image, ingredient, desc);
                Connection.AddFood(food);
                lblResult.Text = "Upload Successful";
                ClearTextFields();
            }
            catch (Exception)
            {
                lblResult.Text = "Upload failed";
            }
        }
    }
}