using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoNganLuong.Controllers
{
    public class NLPaymentController : Controller
    {
        // GET: MLPayment
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult NLWithPayment()
        {
            var link = new NLService().CreateOrdByNL(10000);
            return Redirect(link.ToString());
        }
    }
}