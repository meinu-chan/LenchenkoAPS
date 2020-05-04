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
    [Authorize]
    public class BillController : ApiController
    {
        private PaymentEntities db = new PaymentEntities();

        #region CRD
        //GET: /api/bill/
        //get all elements
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(db.Bill.ToList());
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        //GET: /api/bill/1
        //get elements by id
        public IHttpActionResult Get(int id)
        {
            try
            {
                Bill bill = db.Bill.Find(id);
                if (bill != null)
                    return Ok(bill);
                else
                    return NotFound();
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        //GET: /api/bill?Year=2020&Service=Steam
        //get elements by choosen atribut
        public IHttpActionResult Get([FromUri] int Year, [FromUri] string Service)
        {
            try
            {
                return Ok(db.PayDone.Where(bill => (bill.Date.Year == Year) && (bill.Service == Service)));
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        // POST: api/bill
        //adding new elements
        public IHttpActionResult Post([FromBody]BillDTO dto)
        {
            try
            {
                var newBill = db.Bill.Add(dto.bill);
                db.SaveChanges();
                newBill.addPaid(dto.payDones);
                return Ok(newBill);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }


        // DELETE: api/bill/3
        // Delete element by id
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var bill = db.Bill.Find(id);
                if (bill != null)
                {
                    bill.delPD();
                    db.Bill.Remove(bill);
                    db.SaveChanges();
                    return Ok(db.Bill.ToList());
                }
                else
                    return NotFound();
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
        #endregion

        //Get bill's amount
        [Route("api/bill/{id}/sum")]
        [HttpGet]
        public IHttpActionResult GetAmount(int id)
        {
            try
            {
                var bill = db.Bill.Find(id);
                if (bill != null)
                    return Ok(String.Format("Bill id ::: {0} ::: Total Amount {1}", id, bill.totBillAmount()));
                else
                    return NotFound();
            }catch(Exception e) { return InternalServerError(e); }
        }
    }
}