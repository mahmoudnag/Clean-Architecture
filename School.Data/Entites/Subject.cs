﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entites
{
    public class Subject
    {
        public Subject() {


            StudentSubjects=new HashSet<StudentSubject>();
            DepartmentSubjects=new HashSet<DepartmentSubject>();



        }
        [Key]
        public int SubID { get; set; }
        [StringLength(200)]
        public string SubjectName { get; set; }

        public DateTime period { get; set; }
        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }
        public virtual ICollection <DepartmentSubject> DepartmentSubjects { get; set; }
    }
}
