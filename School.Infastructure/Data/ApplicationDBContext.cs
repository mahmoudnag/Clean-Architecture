using Microsoft.EntityFrameworkCore;
using School.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infastructure.Data
{
    public class ApplicationDBContext:DbContext
    {
       
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<StudentSubject> studentSubjects { get; set; }
        public DbSet<DepartmentSubject> departmentSubjects { get; set; }
    }
}
