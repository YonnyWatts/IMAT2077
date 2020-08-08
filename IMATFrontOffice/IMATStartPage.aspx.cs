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
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            foreach(clsCustomer c in AllCustomers.getList())
            {
                if (c.getEmail() == txtEmail.Text)
                {
                    error += "Error: email already in use ";
                } 
            }
            clsCustomer newCustomer = new clsCustomer(txtUser.Text,txtPass.Text, txtEmail.Text,txtName.Text);
            error += newCustomer.ValidEmail(newCustomer.getEmail());
            error += newCustomer.ValidPassword(newCustomer.getPassword());
            error += newCustomer.ValidUsername(newCustomer.getUsername());
            error += newCustomer.ValidName(newCustomer.getRealname());

            if (error == "")
            {
                Session["aCustomer"] = newCustomer;
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

            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            foreach(clsCustomer c in AllCustomers.getList())
            {
                if (c.getUsername() == txtLoginUser.Text && c.getPassword() == txtLoginPass.Text)
                {
                    Session["aCustomer"] = c;
                    Response.Redirect("IMATCustomerPage.aspx");
                }
            }
            //check if login matches user in collection
            //if info valid, login to main screen
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int index;
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            if(txtFind.Text.Any(Char.IsNumber) == false)
            {
                lblErrorOrConfirm0.Text = "Error: please enter valid number";
            } else
            {
                index = int.Parse(txtFind.Text);
                AllCustomers.getCustomer().Find(index);
                txtLoginUser.Text = AllCustomers.getCustomer().getUsername();
                txtLoginPass.Text = AllCustomers.getCustomer().getPassword();
            }
           
        }
    }
}