using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helppls.Models
{
    interface IPaymentable
    {
        decimal PaymentCash(int total);

        decimal PaymentCredCard(int total);
    }
}
