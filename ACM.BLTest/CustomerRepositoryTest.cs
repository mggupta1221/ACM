using ACM.BL;


namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //--Arrange
            CustomerRepository customerRepository = new CustomerRepository();
            Customer expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };
            //--Act
            var actual = customerRepository.Retrieve(1);
            //--Assert
           // Assert.AreEqual(expected, actual);//compares if the objects pointing to same reference as they are not pointing so this will always fail
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.LastName, actual.LastName);

        }
    }
}
