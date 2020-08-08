using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IMATClasses;
using System.Collections.Generic;

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

            [TestMethod]
            public void TestValidationEmail()
            {
                clsCustomer ACustomer = new clsCustomer("username123", "Password123!", "test@email.com", "James Voltz");
                clsCustomer InvalidCustomer = new clsCustomer("username123", "Password123!", "test", "James Voltz");
                string Error = ACustomer.ValidEmail(ACustomer.getEmail());
                string Error2 = InvalidCustomer.ValidEmail(InvalidCustomer.getEmail());
                Assert.AreEqual(Error, "");
                Assert.AreEqual(Error2, "Error: email too short to be valid Error: invalid email ");
            }

            [TestMethod]
            public void TestValidationUser()
            {
                clsCustomer ACustomer = new clsCustomer("username123", "Password123!", "test@email.com", "James Voltz");
                string Error = ACustomer.ValidUsername(ACustomer.getUsername());
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void TestValidationUserShort()
            {
                string Error;
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.setUsername("deb");
                Error = ACustomer.ValidUsername(ACustomer.getUsername());
                Assert.AreEqual(Error, "Error: username too short ");
            }

            [TestMethod]
            public void TestValidationUserLong()
            {
                string Error;
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.setUsername("debebebebebebebebebebebebebebebebebebebebebebebebebebe");
                Error = ACustomer.ValidUsername(ACustomer.getUsername());
                Assert.AreEqual(Error, "Error: username too long ");
            }

            [TestMethod]
            public void TestValidationUserNumber()
            {
                string Error;
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.setUsername("12345678");
                Error = ACustomer.ValidUsername(ACustomer.getUsername());
                Assert.AreEqual(Error, "Error: must contain atleast 1 letter ");
            }

            [TestMethod]
            public void TestValidationPasssword()
            {
                string error;
                clsCustomer ACustomer = new clsCustomer("username123", "Password123!", "test@email.com", "James Voltz");
                error = ACustomer.ValidPassword(ACustomer.getPassword());
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void TestValidationPassswordShort()
            {
                string error;
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.setPassword("d123!");
                error = ACustomer.ValidPassword(ACustomer.getPassword());
                Assert.AreEqual(error, "Error: password too short ");
            }

            [TestMethod]
            public void TestValidationPassswordLong()
            {
                string error;
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.setPassword("passwordpasswordpasswordpasswordpasswordpassword123!");
                error = ACustomer.ValidPassword(ACustomer.getPassword());
                Assert.AreEqual(error, "Error: password too long ");
            }

            [TestMethod]
            public void TestValidationPasswordInvalid()
            {
                string error;
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.setPassword("password");
                error = ACustomer.ValidPassword(ACustomer.getPassword());
                Assert.AreEqual(error, "Error: must contain atleast 1 letter and 1 number ");
            }

            [TestMethod]
            public void TestValidationName()
            {
                string error;
                clsCustomer ACustomer = new clsCustomer("username123", "Password123!", "test@email.com", "James Voltz");
                error = ACustomer.ValidName(ACustomer.getRealname());
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void TestValidationNameShort()
            {
                string error;
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.setRealname("d b");
                error = ACustomer.ValidName(ACustomer.getRealname());
                Assert.AreEqual(error, "Error: name too short ");
            }

            [TestMethod]
            public void TestValidationNameLong()
            {
                string error;
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.setRealname("debaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
                error = ACustomer.ValidName(ACustomer.getRealname());
                Assert.AreEqual(error, "Error: name is too long ");
            }

            [TestMethod]
            public void TestValidationNameInvalid()
            {
                string error;
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.setRealname("Deborah");
                error = ACustomer.ValidName(ACustomer.getRealname());
                Assert.AreEqual(error, "Error: Not your full name, please include first and surname with a space between them ");
            }

            [TestMethod]
            public void TestValidationNameNumber()
            {
                string error;
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.setRealname("Deborah 1");
                error = ACustomer.ValidName(ACustomer.getRealname());
                Assert.AreEqual(error, "Error: names dont contain numbers ");
            }

        }

        [TestClass]
        public class tstCustomerCollection
        {

            [TestMethod]
            public void ListandCount()
            {
                clsCustomerCollection allCustomers = new clsCustomerCollection();
                List<clsCustomer> testList = new List<clsCustomer>();
                clsCustomer testItem = new clsCustomer();

                testItem.setBoolean(true);
                testItem.setCustomerNo(4);
                testItem.setEmail("test@email.co.uk");
                testItem.setPassword("Password1");
                testItem.setRealname("James Voltz");
                testItem.setUsername("JamesVoltz123");
                testList.Add(testItem);

                allCustomers.setList(testList);

                Assert.AreEqual(allCustomers.getCount(), testList.Count);

            }

            [TestMethod]

            public void AddTest()
            {
                clsCustomerCollection allCustomers = new clsCustomerCollection();
                clsCustomer testItem = new clsCustomer();
                Int32 primaryKey;

                testItem.setBoolean(true);
                testItem.setCustomerNo(4);
                testItem.setEmail("test@email.co.uk");
                testItem.setPassword("Password1");
                testItem.setRealname("James Voltz");
                testItem.setUsername("JamesVoltz123");

                allCustomers.setCustomer(testItem);
                primaryKey = allCustomers.Add();

                allCustomers.getCustomer().Find(primaryKey);

                Assert.AreEqual(allCustomers.getCustomer(), testItem);


            }

            [TestMethod]

            public void DeleteTest()
            {
                clsCustomerCollection allCustomers = new clsCustomerCollection();
                int deletedPrimaryKey = 6;
                allCustomers.getCustomer().Find(deletedPrimaryKey);
                allCustomers.Delete();

                
                Assert.AreEqual(allCustomers.getCustomer().Find(deletedPrimaryKey), false);
            }
        }
    }
}
