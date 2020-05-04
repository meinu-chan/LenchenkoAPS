using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace helppls.Models
{
    public partial class Bill
    {
        //Cycle for add elements
        public void addPaid(PayDoneDTO[] dto)
        {
            PaymentEntities db = new PaymentEntities();
            foreach (PayDoneDTO pd in dto)
            {
                pd.payDone.BillId = this.Id;
                PayDone newPayDone = db.PayDone.Add(pd.payDone);
                this.PayDone.Add(newPayDone);
                db.SaveChanges();
                newPayDone.addPayType(pd.payTypes);
            }

        }

        //delet elements in db
        public void delPD()
        {
            PaymentEntities db = new PaymentEntities();

            foreach (PayDone pd in this.PayDone)
            {
                pd.delPD();
                db.PayDone.Remove(db.PayDone.Find(pd.Id));
                db.SaveChanges();
            }
            this.PayDone.Clear();
            db.SaveChanges();
        }

        //finding sum
        public decimal totBillAmount()
        {
            decimal res = 0;
            foreach(PayDone pd in this.PayDone)
            {
                res = pd.totAmountPT(res);
            }
            return res;
        }
    }
}