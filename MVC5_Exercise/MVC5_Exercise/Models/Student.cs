using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5_Exercise.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Chinese { get; set; }
        public int English { get; set; }
        public int Math { get; set; }
        public int Total
        {
            get { return Chinese + English + Math; }
        }

    }
}