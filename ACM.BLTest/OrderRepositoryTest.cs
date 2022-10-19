using ACM.BL;


namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValidity()
        {
            //--Arrange
            OrderRepository orderRepository = new OrderRepository();
            Order expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 10, 19, 10, 00, 00, new TimeSpan(5, 30, 0))
            };
            //--Act
            var actual = orderRepository.Retreive(10);
            //--Assert
            // Assert.AreEqual(expected, actual);//compares if the objects pointing to same reference as they are not pointing so this will always fail
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
           

        }
    }
}
