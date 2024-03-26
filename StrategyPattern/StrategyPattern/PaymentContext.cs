using StrategyPattern.StrategyPattern.Strategies;

namespace StrategyPattern.Strategy
{
    internal class PaymentContext
    {
        private IPaymentStrategy _strategy;

        public PaymentContext() { _strategy = null; }

        // we can use constructor instead of SetStrategy
        public PaymentContext(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SetStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void MakePayment()
        {
            _strategy.MakePayment();
        }
    }
}
