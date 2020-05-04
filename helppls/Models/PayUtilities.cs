using helppls.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace helppls.Controllers
{
    public class PayUtilities: ISelectable
    {
        private string name;
        private int paynum;
        private string Service;

        public decimal pay(decimal tot)
        {
            return tot;
        }
    }
}