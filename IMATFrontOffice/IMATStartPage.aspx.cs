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
            string error = "";
            clsCustomer newCustomer = new clsCustomer(txtUser.Text,txtPass.Text, txtEmail.Text,txtName.Text);
            error += newCustomer.ValidEmail(newCustomer.getEmail());
            error += newCustomer.ValidPassword(newCustomer.getPassword());
            error += newCustomer.ValidUsername(newCustomer.getUsername());
            error += newCustomer.ValidName(newCustomer.getRealname());

            if (error == "")
            {
                Session["aCustomer"] = newCustomer;
                clsCustomerCollection AllCustomers = new clsCustomerCollection();
                AllCustomers.setCustomer(newCustomer);
                AllCustomers.Add();
                lblErrorOrConfirm.Text = "New account registered, please Login";
            } else
            {
                lblErrorOrConfirm.Text = error;
            }
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //check if login matches user in collection
            //if info valid, login to main screen
        }
    }
}