using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPayment payment = new CreditCardPayment();
            var processor = new PaymentProcessor(payment);

            processor.MakePayment(5000);
        }
    }
}
