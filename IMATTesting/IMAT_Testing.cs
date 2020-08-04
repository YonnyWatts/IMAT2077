using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IMATClasses;

namespace IMATTesting
{
    [TestClass]
    public class IMAT_Testing
    {
        [TestClass]
        public class tstCustomer
        {
            [TestMethod]
            public void InstanceOK()
            {
                //create an instance of the class we want to create
                clsCustomer ACustomer = new clsCustomer();
                //test to see that it exists
                Assert.IsNotNull(ACustomer);
            }

            [TestMethod]
            public void CustomerNoPropertyOK()
            {
                clsCustomer ACustomer = new clsCustomer();
                int testData = 1;
                ACustomer.setCustomerNo(testData);
                Assert.AreEqual(ACustomer.getCustomerNo(), testData);
            }

            [TestMethod]
            public void EmailPropertyOK()
            {
                clsCustomer ACustomer = new clsCustomer();
                string testData = "email@email.co.uk";
                ACustomer.setEmail(testData);
                Assert.AreEqual(ACustomer.getEmail(), testData);
            }

            [TestMethod]
            public void UsernamePropertyOK()
            {
                clsCustomer ACustomer = new clsCustomer();
                string testData = "testuser456";
                ACustomer.setUsername(testData);
                Assert.AreEqual(ACustomer.getUsername(), testData);
            }

            [TestMethod]
            public void PasswordPropertyOK()
            {
                clsCustomer ACustomer = new clsCustomer();
                string testData = "testPassword123";
                ACustomer.setPassword(testData);
                Assert.AreEqual(ACustomer.getPassword(), testData);
            }

            [TestMethod]
            public void BooleanPropertyOK()
            {
                clsCustomer ACustomer = new clsCustomer();
                bool testData = false;
                ACustomer.setBoolean(testData);
                Assert.AreEqual(ACustomer.getBoolean(), testData);
            }

            [TestMethod]
            public void FindMethodOK()
            {
                clsCustomer ACustomer = new clsCustomer();
                Boolean Found = false;
                int customerNo = 1;
                Found = ACustomer.Find(customerNo);
                Assert.IsTrue(Found);
            }

            [TestMethod]
            public void TestCustomerNOFound()
            {
                //create an instance of the class we want to create
                clsCustomer ACustomer = new clsCustomer();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 CustomerNo = 1;
                //invoke the method
                Found = ACustomer.Find(CustomerNo);
                //check the address no
                if (ACustomer.getCustomerNo() != 1)
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }
            
            [TestMethod]
            public void TestFullNameFound()
            {
                //create an instance of the class we want to create
                clsCustomer ACustomer = new clsCustomer();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 CustomerNo = 1;
                //invoke the method
                Found = ACustomer.Find(CustomerNo);
                //check the address no
                if (ACustomer.getRealname() != "Jonathan Watts")
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void TestUsernameFound()
            {
                //create an instance of the class we want to create
                clsCustomer ACustomer = new clsCustomer();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 CustomerNo = 1;
                //invoke the method
                Found = ACustomer.Find(CustomerNo);
                //check the address no
                if (ACustomer.getUsername() != "JWatts717")
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void TestPasswordFound()
            {
                //create an instance of the class we want to create
                clsCustomer ACustomer = new clsCustomer();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 CustomerNo = 1;
                //invoke the method
                Found = ACustomer.Find(CustomerNo);
                //check the address no
                if (ACustomer.getPassword() != "ThisIsATest")
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void TestEmailFound()
            {
                //create an instance of the class we want to create
                clsCustomer ACustomer = new clsCustomer();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 CustomerNo = 1;
                //invoke the method
                Found = ACustomer.Find(CustomerNo);
                //check the address no
                if (ACustomer.getEmail() != "p2450424@my365.dmu.ac.uk")
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void TestBooleanFound()
            {
                //create an instance of the class we want to create
                clsCustomer ACustomer = new clsCustomer();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 CustomerNo = 1;
                //invoke the method
                Found = ACustomer.Find(CustomerNo);
                //check the address no
                if (ACustomer.getBoolean() != false)
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }



        }
    }
}
