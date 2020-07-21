using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMATClasses
{
    class clsCustomerCollection{
        //private fields
        private int count = 0;
        private List<clsCustomer> customerList = new List<clsCustomer>();
        private clsCustomer thisCustomer;
        
        //constructor with no parameters
        public clsCustomerCollection(){
          count = 0;

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

        //methods
        public void Find(clsCustomer consumer){
            foreach (clsCustomer customer in customerList){
                if(customer == consumer){
                    thisCustomer = consumer;
                    getCustomer();
                }
            }
        }

        public void Delete(clsCustomer consumer){
            foreach (clsCustomer customer in customerList){
                if (customer == consumer){
                    customerList.Remove(customer);
                    count -= 1;
                }
            }
        }
        public void Add(clsCustomer consumer)
        {
            customerList.Add(consumer);
            count += 1;
        }

        public void Filter(){

        }

    }
}
