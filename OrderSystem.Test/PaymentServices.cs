namespace OrderSystem
{
    public class PaymentService
    {
        public bool ProcessPayment(decimal amount, decimal balance)
        {
            return balance >= amount;
        }
    }
}
