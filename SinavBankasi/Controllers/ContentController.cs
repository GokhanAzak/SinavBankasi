using BusniesLayer.Concreate;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SinavBankasi.Controllers
{
    public class ContentController : Controller
    {
       
     
        public ActionResult Index()
        {
            return View();
        }
     
        
    }
}