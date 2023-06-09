﻿using BusniesLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SinavBankasi.Controllers
{
    public class HeadingController : Controller
    {
        HeadingManager hm=new HeadingManager(new EfHeadingDal());
        CategoryManager cm=new CategoryManager(new EfCategoryDal());
        WriterMeneger wm=new WriterMeneger(new EfWritingDal());
        public ActionResult Index()
        {
            var headingvalues=hm.GetList();
            return View(headingvalues);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valuecatagory = (from x in cm.GetList() select new SelectListItem
            { Text = x.CategoryName,Value=x.CategoryID.ToString()
            }).ToList();
            List<SelectListItem> valuewriter = (from x in wm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.WriterName+" "+x.WriterSurName,
                                                    Value = x.WriterID.ToString()
                                                }).ToList();
            ViewBag.vlc=valuecatagory;
            ViewBag.vlw = valuewriter;
            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult ContentByHeading() 
        {
            return View();
        }
    }
}