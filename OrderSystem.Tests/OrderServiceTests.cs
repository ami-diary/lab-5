using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderSystem;

namespace OrderSystem.Tests
{
    [TestClass]
    public class OrderServiceTests
    {
        [TestMethod]
        public void CalculateOrderTotal_ReturnsCorrectSum()
        {
            var order = new Order();
            order.AddProduct(new Product("Телефон", 30000));
            order.AddProduct(new Product("Чехол", 1000));

            var service = new OrderService();
            var total = service.CalculateOrderTotal(order);

            Assert.AreEqual(31000, total); // Проверка, что сумма корректна
        }

        [TestMethod]
        public void IsOrderValid_ReturnsTrue_WhenProductsExist()
        {
            var order = new Order();
            order.AddProduct(new Product("Монитор", 20000));

            var service = new OrderService();
            Assert.IsTrue(service.IsOrderValid(order)); // Проверка, что заказ с товарами валиден
        }

        [TestMethod]
        public void IsOrderValid_ReturnsFalse_WhenEmptyOrder()
        {
            var order = new Order();
            var service = new OrderService();
            Assert.IsFalse(service.IsOrderValid(order)); // Проверка, что пустой заказ невалиден
        }
    }
}