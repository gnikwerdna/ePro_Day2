using ePro.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ePro.Controllers
{
    public class UploadController : Controller
    {
        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Upload()
        {
                return View();

        }
        

        [HttpPost]
        public ActionResult Upload(ProductFile model)
        {
        /* Code to save save model data into database. */ 
        foreach (string upload in Request.Files)
        {

        if (Request.Files[upload].ContentLength == 0) continue;
         string pathToSave = Server.MapPath ("~/Documents/");
         string filename = Path.GetFileName(Request.Files[upload].FileName);
         Request.Files[upload].SaveAs(Path.Combine(pathToSave, filename));
         }
            return View();
         }


    }
}