using helppls.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace helppls.Controllers
{
    public class PaymentController : ApiController, IPaymentable
    {
        public decimal PaymentCash(int total)
        {
            return total;
        }

        public decimal PaymentCredCard(int total)
        {
            return total;
        }

        public decimal totPAyment(decimal total)
        {
            return total += total * (decimal)0.05;
        }
    }
}
