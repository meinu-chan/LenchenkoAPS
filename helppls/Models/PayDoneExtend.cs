using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace helppls.Models
{
    public partial class PayDone
    {
        //add elements in  db
        public void addPayType(PayTypeDTO[] dto)
        {
            PaymentEntities db = new PaymentEntities();
            foreach (PayTypeDTO pt in dto)
            {
                pt.payType.PayDoneId = this.Id;
                PayType newPayType = db.PayType.Add(pt.payType);
                this.PayType.Add(newPayType);
                db.SaveChanges();
                newPayType.addPrepForPays(pt.prepForPays);
            }
        }

        //delete elements in db
        public void delPD()
        {
            PaymentEntities db = new PaymentEntities();

            foreach (PayType pt in this.PayType)
            {
                pt.delPFP();
                db.PayType.Remove(db.PayType.Find(pt.Id));
                db.SaveChanges();
            }
            this.PayType.Clear();
            db.SaveChanges();
        }

        public decimal totAmountPT(decimal res)
        {
            foreach(PayType pt in this.PayType)
            {
               res = pt.totAmountPFP(res);
            }
            return res;
        }
    }
}