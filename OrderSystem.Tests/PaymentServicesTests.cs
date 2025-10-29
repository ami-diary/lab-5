using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderSystem;

namespace OrderSystem.Tests
{
    [TestClass]
    public class PaymentServiceTests
    {
        [TestMethod]
        public void ProcessPayment_ReturnsTrue_WhenBalanceIsEnough()
        {
            var paymentService = new PaymentService();
            Assert.IsTrue(paymentService.ProcessPayment(5000, 10000));
        }

        [TestMethod]
        public void ProcessPayment_ReturnsFalse_WhenBalanceIsNotEnough()
        {
            var paymentService = new PaymentService();
            Assert.IsFalse(paymentService.ProcessPayment(10000, 5000));
        }

        [TestMethod]
        public void Integration_OrderService_With_PaymentService_WorksCorrectly()
        {
            var order = new Order();
            order.AddProduct(new Product("Клавиатура", 3000));
            order.AddProduct(new Product("Мышь", 1000));

            var orderService = new OrderService();
            var paymentService = new PaymentService();

            var total = orderService.CalculateOrderTotal(order);
            var paymentResult = paymentService.ProcessPayment(total, 10000);

            Assert.IsTrue(paymentResult); // Проверка интеграции
        }
    }
}