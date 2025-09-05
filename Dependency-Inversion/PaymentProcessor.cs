using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    public class PaymentProcessor
    {
        private readonly IPayment _payment;

        public PaymentProcessor(IPayment payment)
        {
            _payment = payment;
        }

        public void MakePayment(decimal amount)
        {
            _payment.Pay(amount);
        }
    }
}
