using MVC5_Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_Exercise.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmployeeList()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {ID = 10001,Name="David",Phone = "0933-123455", Email = "david@gmail.com"},
                new Employee {ID = 10002,Name="Marry",Phone = "0923-123935", Email = "marry@gmail.com"},
                new Employee {ID = 10003,Name="John",Phone = "0913-134475", Email = "john@gmail.com"},
                new Employee {ID = 10004,Name="Cindy",Phone = "0933-121252", Email = "cindy@gmail.com"},
                new Employee {ID = 10005,Name="Sally",Phone = "0935-122855", Email = "sally@gmail.com"},
                new Employee {ID = 10006,Name="Rose",Phone = "0913-123985", Email = "rose@gmail.com"},
                new Employee {ID = 10007,Name="Jack",Phone = "0938-123951", Email = "jack@gmail.com"},
            };
            return View(employees);
        }
    }
}