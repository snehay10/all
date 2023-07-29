using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            //ViewData["message"] = "message from view data";
            //ViewData["name"] = "Sneha Suresh Yadav";


            //String[] st1  = {"apple","b","c","d","e","f"};
            //ViewData["st"] = st1;

            //ViewData["sports"] = new List<string>() { "a","b","c","d","e","f"};

            //Emp sneha= new Emp();
            //sneha.Eid = 11;
            //sneha.Enm = "yadav";
            //sneha.EDesignation = "developer";

            //ViewData["Employee"] = sneha;


            ////example of viewBag
            //ViewBag.Message1 = "Message from viewBag";
            //string[] fruits1 = { "a", "p", "p", "l", "e" };
            //ViewBag.Fruits1 = fruits1;
            //ViewBag.Sports = new List<String>()
            //{
            //    "aaa",
            //    "bbb",
            //    "ccc",
            //    "ddd"
            //};
            //Emp shiv = new Emp();
            //shiv.Eid = 22;
            //shiv.Enm = " Shivraj";
            //shiv.EDesignation = "teacher";

            //ViewBag.mans=shiv;


            ViewData["v1"] = "Message from viewdata";
            ViewBag.v2 = "message from viewbag";
            TempData["v3"] = "message from tempdata";

            Session["v4"] = "data come from session ";
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
       public ActionResult Contact()
        {
            return View();
        }
    }
}