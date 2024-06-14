using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Student_MVC.Models
{
    public class Student_MVCDBContext : DbContext
    {
        public Student_MVCDBContext (DbContextOptions<Student_MVCDBContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Student_MVC.Models.Student> Student { get; set; }
    }
}
