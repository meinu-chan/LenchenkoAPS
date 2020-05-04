using helppls.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace helppls.Controllers
{
    public class ServiceController : ApiController
    {
        private string Detail;

        public void addDetail(int id)
        {
            PaymentEntities db = new PaymentEntities();

            var bill = db.Bill.Find(id);

            db.Entry(bill).State = EntityState.Modified;

            bill.Detail = Detail;
        }
    }
}
