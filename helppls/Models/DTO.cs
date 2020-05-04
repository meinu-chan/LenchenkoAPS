using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace helppls.Models
{
    public class BillDTO
    {
        public Bill bill;

        public PayDoneDTO[] payDones;
    }

    public class PayDoneDTO
    {
        public PayDone payDone;

        public PayTypeDTO[] payTypes;
    }

    public class PayTypeDTO
    {
        public PayType payType;

        public PrepForPay[] prepForPays;
    }
}