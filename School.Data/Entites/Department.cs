﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entites
{
    public partial class Department
    {
        public Department() {

            Students =new  HashSet<Student>();
            DepartmentSubjects = new HashSet<DepartmentSubject>();
        }
        [Key]
        public int DID { get; set; }
        [StringLength(200)]
        public string DName { get; set; }
        public virtual ICollection<DepartmentSubject> DepartmentSubjects { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}