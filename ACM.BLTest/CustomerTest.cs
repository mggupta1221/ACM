using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer();
            customer.FirstName = "Mukesh";
            customer.LastName = "Gupta";

            string expected="Gupta , Mukesh";    

            //--Act

            string actual=customer.FullName;

            //-Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer();
         
            customer.LastName = "Gupta";

            //--Act
            string expected = "Gupta";

            string actual = customer.FullName;
            //-Assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.FirstName = "Mukesh";
            //--Act
            string expected = "Mukesh";
            string actual = customer.FullName;
            //-Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void StaticTest()
        {
            //--Arrange
            Customer c1 = new Customer();
            c1.FirstName = "Bilbo";
            c1.LastName = "Baggins";
            Customer.InstanceCount += 1;

            Customer c2 = new Customer();
            c1.FirstName = "Frodo";
            c1.LastName = "Baggins";
            Customer.InstanceCount++;

            Customer c3 = new Customer();
            c1.FirstName = "Thorin";
            c1.LastName = "Oakenshield";
            Customer.InstanceCount++;
            //--Act
            //-Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange  given
            Customer c1 = new Customer();
            {
                c1.LastName = "Baggins";
                c1.EmailAddress = "xyz@gmail.com";
            }
            bool expected = true;
            //--Act  when
            bool actual=c1.Validate();
            //-Assert   then
            Assert.AreEqual(expected,actual );



            //--Arrange  given
            Customer c2 = new Customer();
            {
                c2.LastName = "Baggins";
                c2.EmailAddress = null;
            
            }
            expected = false;
            //--Act  when
            actual = c2.Validate();
            //-Assert   then
            Assert.AreEqual(expected, actual);


            //--Arrange  given
            Customer c3 = new Customer();
            {
                c3.EmailAddress = "xyz@gmail.com";
                c3.LastName = null;

            }
            expected = false;
            //--Act  when
            actual = c3.Validate();
            //-Assert   then
            Assert.AreEqual(expected, actual);



            //--Arrange  given
            Customer c4 = new Customer();
            {
                c1.LastName = null;
                c1.EmailAddress =null;
            }
            expected = false;
            //--Act  when
            actual = c4.Validate();
            //-Assert   then
            Assert.AreEqual(expected, actual);
        }



    }


}