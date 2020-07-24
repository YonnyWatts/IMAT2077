using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMATClasses
{
 class clsCustomer
    {
        //private fields
        private int customerNo;
        private string username;
        private string password;
        private string email;
        private bool saveInfo;
        private string realName;



        //constructor that requires all 4 fields
        public clsCustomer(int accountNo, string user, string pass, string emails, string name, bool info)
        {
            customerNo = accountNo;
            username = user;
            password = pass;
            email = emails;
            saveInfo = info;
            realName = name;

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
