using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMATClasses
{
 public class clsCustomer
    {
        //private fields
        private int customerNo;
        private string username;
        private string password;
        private string email;
        private bool saveInfo;
        private string realName;



        //constructor that requires all 4 fields
        public clsCustomer(string user, string pass, string emails, string name){
            username = user;
            password = pass;
            email = emails;
            realName = name;
        }

        //constructor that requires no fields
        public clsCustomer(){
        
        }

        //methods
        public bool Find(int customer)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AccountNo", customer);
            DB.Execute("sproc_tblCustomer_FilterByAccountNo");
            if(DB.Count == 1){
                customerNo = Convert.ToInt32(DB.DataTable.Rows[0]["AccountNo"]);
                realName = Convert.ToString(DB.DataTable.Rows[0]["Full Name"]);
                username = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                email = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                password = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                saveInfo = Convert.ToBoolean(DB.DataTable.Rows[0]["IsPaymentSaved?"]);
                return true;
            }
            else
            {
                return false;
            }

        }

        //getters and setters
        public string getUsername(){
            return username;
        }
        public void setUsername(string user){
            username = user;
        }
        public string getRealname(){
            return realName;
        }
        public void setRealname(string name){
            realName = name;
        }
        public bool getBoolean(){
            return saveInfo;
        }
        public void setBoolean(bool info){
            saveInfo = info;
        }
        public string getPassword(){
            return password;
        }
        public void setPassword(string pass){
            password = pass;
        }
        public int getCustomerNo(){
            return customerNo;
        }
        public void setCustomerNo(int account){
            customerNo = account;
        }

        public string getEmail(){
            return email;
        }
        public void setEmail(string emails){
            email = emails;
        }



    }
}
