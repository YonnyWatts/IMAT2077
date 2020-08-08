using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IMATClasses;

namespace IMATFrontOffice
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsDataConnection DB = new clsDataConnection();
            clsCustomer aCustomer = (clsCustomer)Session["aCustomer"];
            txtEmail.Text = aCustomer.getEmail();
            txtPass.Text = aCustomer.getPassword();
            txtUser.Text = aCustomer.getUsername();
            txtName.Text = aCustomer.getRealname();
            cboxPay.Checked = aCustomer.getBoolean();
         
            if (cboxPay.Checked == true)
            {
                DB.AddParameter("@Email", aCustomer.getEmail());
                DB.Execute("sproc_tblCustomerPaymentInfo_FilterByEmail");
                txtCard.Text = Convert.ToString(DB.DataTable.Rows[0]["CardNumber"]);
                txtExpire.Text = Convert.ToString(DB.DataTable.Rows[0]["ExpiryDate"]);
                txtStreet.Text = Convert.ToString(DB.DataTable.Rows[0]["StreetAddress"]);
                txtCity.Text = Convert.ToString(DB.DataTable.Rows[0]["City"]);
                txtPost.Text = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
            }
            lblAccountNo.Text = "Account No: " + aCustomer.getCustomerNo().ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Commented out as classes dont exist

            // clsOrder newOrder = newOrder(aCustomer, productChair, int.Parse(txtQuantity.Text))
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            clsDataConnection DB = new clsDataConnection();
            clsCustomer aCustomer = (clsCustomer)Session["aCustomer"];

            /**to validate this, you would use the valid functions from before, as well as writing a similar one to check the data coming 
             * from the text boxes if payment information is on,you would then only run the update code if those functions encountered no errors 
            **/

            if (cboxPay.Checked == true)
            {
                DB.AddParameter("@Email", txtEmail.Text);
                DB.AddParameter("@OldEmail", aCustomer.getEmail());
                DB.AddParameter("@Card", txtCard.Text);
                DB.AddParameter("@City", txtCity.Text );
                DB.AddParameter("@StreetAddress", txtStreet.Text);
                DB.AddParameter("@Date", txtExpire.Text);
                DB.AddParameter("@Name", txtName.Text);
                DB.Execute("sproc_tblCustomer_Update");

            }
            DB.AddParameter("@Email",txtEmail.Text);
            DB.AddParameter("@Password", txtPass.Text);
            DB.AddParameter("@Username", txtUser.Text);
            DB.AddParameter("@paymentinfo", cboxPay.Checked);
            DB.AddParameter("@AccountNo", aCustomer.getCustomerNo());
            DB.AddParameter("@Realname", txtName.Text);
            DB.Execute("sproc_tblCustomer_Update");

            

        }
    }
}