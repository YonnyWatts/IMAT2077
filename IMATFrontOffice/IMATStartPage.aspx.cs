using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IMATClasses;

namespace IMATFrontOffice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsCustomer aCustomer = new clsCustomer();
            aCustomer = (clsCustomer)Session["aCustomer"];
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            clsCustomer newCustomer = new clsCustomer(txtUser.Text,txtPass.Text, txtEmail.Text,txtName.Text);
            Session["aCustomer"] = newCustomer;
            //add data to database as a new registered user
            lblErrorOrConfirm.Text = "New account registered, please Login";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //check if login matches user in collection
            //if info valid, login to main screen
        }
    }
}