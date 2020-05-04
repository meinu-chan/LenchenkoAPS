using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace helppls.Models
{
    public class PaySim:ISelectable
    {
        public int number;
        private int _number { get => number; set { value = number; } }

        public decimal pay(decimal tot)
        {
            return tot;
        }
    }
}