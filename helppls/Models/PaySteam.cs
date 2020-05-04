using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace helppls.Models
{
    public class PaySteam
    {
        public string name;
        private string _name { get => name; set { value = name; } }

        public decimal pay(decimal tot)
        {
            return tot;
        }
    }
}