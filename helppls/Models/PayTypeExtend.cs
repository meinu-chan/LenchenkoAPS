using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace helppls.Models
{
    public partial class PayType
    {
        //add elements in db
        public void addPrepForPays(PrepForPay[] pfp)
        {
            PaymentEntities db = new PaymentEntities();
            foreach (PrepForPay pp in pfp)
            {
                pp.PayTypeId = this.Id;
                PrepForPay newPrepForPay = db.PrepForPay.Add(pp);
                this.PrepForPay.Add(newPrepForPay);
                db.SaveChanges();
            }
        }

        //delete elements in db
        public void delPFP()
        {
            PaymentEntities db = new PaymentEntities();

            foreach (PrepForPay pfp in this.PrepForPay)
            {
                db.PrepForPay.Remove(db.PrepForPay.Find(pfp.Id));
                db.SaveChanges();
            }
            this.PrepForPay.Clear();
            db.SaveChanges();
        }

        public decimal totAmountPFP(decimal res)
        {
            foreach(PrepForPay pfp in this.PrepForPay)
            {
                res += pfp.Total;
            }
            return res;
        }
    }
}