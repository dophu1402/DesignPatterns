namespace StrategyPattern.StrategyPattern.Strategies
{
    internal class PayPal : IPaymentStrategy
    {
        string _email;
        string _password;
        public PayPal(string email, string password)
        {
            _email = email;
            _password = password;
        }
        public void MakePayment()
        {
            Console.WriteLine("Make payment by Paypal");
        }
    }
}
