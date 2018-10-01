using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewWorld.Models;

namespace NewWorld.Controllers
{
    public class RecordsController : Controller
    {
        // GET: Records
        public ActionResult Index()
        {
            Record rec = new Record
            {
                Id = 101,
                RecordName = "Bouchers",
                RecordDetails = "The basic stocks"
            };
            ViewBag.Message = rec;
            return View();
        }
    }
}