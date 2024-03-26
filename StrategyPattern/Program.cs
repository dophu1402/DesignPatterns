using StrategyPattern.Strategy;
using StrategyPattern.StrategyPattern.Strategies;

// use Stategy class constructor
var paymentMethod = new PaymentContext(new PayPal("Sample@email.com", "SamplePass"));
paymentMethod.MakePayment();


// use SetStrategy method
PaymentContext invoice = new PaymentContext();
invoice.SetStrategy(new CreditCard("0123-456-789", "10/03","123"));
invoice.MakePayment();