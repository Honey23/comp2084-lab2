using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class ProductssController : Controller
    {
        // GET: Productss
        public ActionResult Index()
        {
            return View();
        }

        //GET: Productss/Details

        public ActionResult details(string YouSelectedProduct)
        {
            ViewBag.YouSelectedProduct = YouSelectedProduct;

            return View();
        }
    }
}