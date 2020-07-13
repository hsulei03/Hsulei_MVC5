using MVC5_Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_Exercise.Controllers
{
    public class RazorScoreController : Controller
    {
        protected List<Student> students = new List<Student>
        {
            new Student {Id =1 , Name = "Joe", Chinese = 88, English = 95, Math = 71 },
            new Student {Id =12 , Name = "Mary", Chinese = 92, English = 82, Math = 60 },
            new Student {Id =23 , Name = "Cathy", Chinese = 98, English = 91, Math = 94 },
            new Student {Id =34 , Name = "John", Chinese = 63, English = 85, Math = 55 },
            new Student {Id =45 , Name = "David", Chinese =59, English = 77, Math= 82 },
        };
        // GET: RazorScore
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Scores()
        {
            return View(students);
        }

        /// <summary>
        /// 找出總分最高者
        /// </summary>
        /// <returns></returns>
        public ActionResult ScoresRazor()
        {
            //找出總分最高者之id
            ViewBag.TopId = students.Find((x) => x.Total == students.Max((y) => y.Total)).Id;
            return View(students);
        }

        public ActionResult ScoresRazorPure()
        {
            //找出總分最高者之id
            ViewBag.TopId = students.Find((x) => x.Total == students.Max((y) => y.Total)).Id;
            return View(students);
        }

        public ActionResult GlobalHtmlHelper()
        {
            //找出總分最高者之id
            ViewBag.TopId = students.Find((x) => x.Total == students.Max((y) => y.Total)).Id;
            return View(students);
        }
    }
}