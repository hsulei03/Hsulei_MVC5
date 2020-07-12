using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_Exercise.Controllers
{
    public class ResultsController : Controller
    {
        // GET: Results
        public ActionResult Index()
        {
            //因ActionResult為基底類別，故可以代表ViewResult型別

            return View();
            //Controller.View()方法實際上是回傳new ViewResult()物件實例
        }


        //以上三種語法是相等的
        public ViewResult Index2()
        {
            return new ViewResult();
        }

        public ViewResult Index3()
        {
            return View();
        }
        public ActionResult Index4()
        {
            return new ViewResult();
        }
        //-----------------------------

        public PartialViewResult GetPartialCard()
        {

            //回傳_SimpleCardPartial.cshtml部分檢視
            return PartialView("_SimpleCardPartial");
        }
    }
}