using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace helppls.Models
{
    public class PayStudy: ISelectable
    {
        public string name;
        private string _name { get => name; set { value = name; } }
        public int paynum;
        private int _paynum { get => paynum; set { value = paynum; } }

        public decimal pay(decimal tot)
        {
            return tot;
        }
    }
}