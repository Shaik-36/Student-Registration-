using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_MVC.Models
{
    public class Student
    {
        public int Id { get; set; }

        public int SId { get; set; }

        public string StudentName { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string Course { get; set; }

        public int Fee{ get; set; }
    }
}
