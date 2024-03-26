namespace StrategyPattern.StrategyPattern.Strategies
{
    internal class CreditCard : IPaymentStrategy
    {
        string number;
        string expr;
        string securityCode;

        public CreditCard(string number, string expr, string securityCode)
        {
            this.number = number;
            this.expr = expr;
            this.securityCode = securityCode;
        }

        public void MakePayment()
        {
            Console.WriteLine("Make payment by credit card");
        }
    }
}
