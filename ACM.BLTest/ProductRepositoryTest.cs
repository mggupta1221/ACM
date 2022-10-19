using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //--Arrange
            ProductRepository productRepository = new ProductRepository();
            Product expected = new Product(2)
            {
                CurrentPrice = 13.33M,
                ProductDescription = "Bunch of 4 flowers",
                ProductName = "Sunflower"
            };
            //--Act
            var actual = productRepository.Retreive(2);
            //--Assert
            //Assert.AreEqual(expected, actual); //compares if the objects pointing to same reference as they are not pointing so this will always fail
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
       



        }

    }
}