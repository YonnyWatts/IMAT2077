using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMATClasses
{
    public class clsCustomerCollection{
        //private fields
        private int count = 0;
        private List<clsCustomer> customerList = new List<clsCustomer>();
        private clsCustomer thisCustomer = new clsCustomer();
        
        //constructor with no parameters
        public clsCustomerCollection(){
          count = 0;
            int records;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_selectall");
            records = DB.Count;

            while(count < records)
            {
                clsCustomer ACustomer = new clsCustomer();

                ACustomer.setBoolean(Convert.ToBoolean(DB.DataTable.Rows[count]["IsPaymentSaved"]));
                ACustomer.setCustomerNo(Convert.ToInt32(DB.DataTable.Rows[count]["AccountNo"]));
                ACustomer.setEmail(Convert.ToString(DB.DataTable.Rows[count]["Email"]));
                ACustomer.setUsername(Convert.ToString(DB.DataTable.Rows[count]["Username"]));
                ACustomer.setPassword(Convert.ToString(DB.DataTable.Rows[count]["PassWord"]));
                ACustomer.setRealname(Convert.ToString(DB.DataTable.Rows[count]["FullName"]));
                customerList.Add(ACustomer);
                count++;
            }

        }

        //getters and setters
        public int getCount()
        {
            return count;
        }

        public clsCustomer getCustomer()
        {
            return thisCustomer;
        }
        public List<clsCustomer> getList()
        {
            return customerList;
        }

        public void setCount(int listCount)
        {
            count = listCount;
        }

        public void setCustomer(clsCustomer customer)
        {
            thisCustomer = customer;
        }

        public void setList(List<clsCustomer> consumerlist)
        {
            customerList = consumerlist;
            count = customerList.Count;
        }


        //methods
        public void Delete(){
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AccountNo", thisCustomer.getCustomerNo());
            DB.Execute("sproc_tblCustomer_Delete");
            customerList.Remove(thisCustomer);

            count--;
         }
            
        
        public int Add()
        {
            
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Realname", thisCustomer.getRealname());
            DB.AddParameter("@Username", thisCustomer.getUsername());
            DB.AddParameter("@Password", thisCustomer.getPassword());
            DB.AddParameter("@Email", thisCustomer.getEmail());
            DB.AddParameter("@paymentInfo", thisCustomer.getBoolean());
            customerList.Add(thisCustomer);
            count++;

            return DB.Execute("sproc_tblCustomer_Add");
        }

        public void Filter(){

        }

    }
}
