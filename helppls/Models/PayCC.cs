using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace helppls.Models
{
    public class PayCC: ISelectable
    {
        public int paynum;
        private int _paynum { get => paynum; set { value = paynum; } }

        public decimal pay(decimal tot)
        {
            return tot;
        }
    }
}