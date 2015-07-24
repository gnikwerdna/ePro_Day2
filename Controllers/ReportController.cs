using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ePro.Controllers
{
    public class ReportController : Controller
    {

        private const string compliantreport = "Reports/ComplaintItems.rdlc";
        // GET: Report
        public ActionResult Index()
        {
            return View();
        }
    }
}