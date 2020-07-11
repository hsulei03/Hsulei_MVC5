using MVC5_Exercise.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_Exercise.Controllers
{
    public class PassDataController : Controller
    {
        // GET: PassData
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PetShop()
        {
            //1.使用ViewData傳遞資料到View
            ViewData["Company"] = "汪星人寵物店";

            //2.使用ViewBag傳遞資料到View
            ViewBag.Address = "台北市信義區松山路199號";

            //3.使用ViewModel傳遞資料到View
            //利用list泛型集合，代表model資料模型
            List<string> petList = new List<string>();
            petList.Add("狗");
            petList.Add("貓");
            petList.Add("魚");
            petList.Add("鼠");
            petList.Add("變色龍");
            //ViewData.Model = petList;
            //return View();

            //可簡化語法變成直接丟list給view
            //實際上傳送model物件給view，會使用View(petList)語法取代
            return View(petList);
        }

        public ActionResult PassTempData()
        {
            //4.使用TempData傳遞資料，
            //適用於Controller / Action 傳遞資料給View，但不同Action之間傳遞資料，無論是同一個Controller或不同Controller，就必須使用TempData
            TempData["ErrorMessage"] = "無足夠權限存取系統資料，請連絡系統管理人員";
            TempData["UserName"] = "David";
            TempData["Time"] = DateTime.Now.ToLongTimeString();
            return RedirectToAction("ErrorMessage", "ErrorHandler");
            //轉向到另一個Action  RedirectToAction("Action","Controller")

        }

        public ActionResult StronglyTypedView()
        {
            Employee employee = new Employee
            {
                ID = 10001,
                Name = "DaLaLa",
                Phone = "0923-458332",
                Email = "dalala@gmail.com"
            };
            return View(employee);
        }
    }
}