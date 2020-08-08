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

            username = "";
            password = "";
            email = "";
            realName = "";
            saveInfo = false;
        }

        //methods

        public string ValidUsername(string user)
        {
            string error = "";
            if(user.Length > 50) {
                error += "Error: username too long ";
                    }
            if (user.Length < 4) {
                error += "Error: username too short ";
            }

            if(user.Any(c => Char.IsLetter(c)) == false) { 
                error += "Error: must contain atleast 1 letter "; 
            }
            return error;
        }

        public string ValidPassword(string pass)
        {
            string error = "";
            if (pass.Length > 50)
            {
                error += "Error: password too long ";
            }
            if (pass.Length < 8)
            {
                error += "Error: password too short ";
            }

            if (pass.Any(c => Char.IsLetter(c)) == false || pass.Any(c => Char.IsNumber(c)) == false)
            {
                error += "Error: must contain atleast 1 letter and 1 number ";
            }
        
            return error;
        }

        public string ValidEmail(string email)
        {
            string error = "";
            if (email.Length > 50)
            {
                error += "Error: email is too long ";
            }
            if (email.Length < 7)
            {
                error += "Error: email too short to be valid ";
            }
            if (email.Contains('@') == false || email.Contains('.') == false)
            {
                error += "Error: invalid email ";
            }

            return error;
        }

        public string ValidName(string name)
        {
            string error = "";
            if (name.Length > 100)
            {
                error += "Error: name is too long ";
            }

            if (name.Length < 4)
            {
                error += "Error: name too short ";
            }
        
            if (name.Contains(' ') == false) {
                error += "Error: Not your full name, please include first and surname with a space between them ";
            }

            if (name.Any(c => Char.IsNumber(c)))
            {
                error += "Error: names dont contain numbers ";
            }

            return error;
        }

        public bool Find(int customer)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AccountNo", customer);
            DB.Execute("sproc_tblCustomer_FilterByAccountNo");
            if(DB.Count == 1){
                customerNo = Convert.ToInt32(DB.DataTable.Rows[0]["AccountNo"]);
                realName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                username = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                email = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                password = Convert.ToString(DB.DataTable.Rows[0]["PassWord"]);
                saveInfo = Convert.ToBoolean(DB.DataTable.Rows[0]["IsPaymentSaved"]);
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
