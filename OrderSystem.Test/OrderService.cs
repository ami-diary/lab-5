namespace OrderSystem
{
    public class OrderService
    {
        public decimal CalculateOrderTotal(Order order)
        {
            return order.GetTotalPrice();
        }

        public bool IsOrderValid(Order order)
        {
            return order.Products.Count > 0;
        }
    }
}