using AutoMapper;
using School.Core.Features.Students.Queries.Results;
using School.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.mapping.Students
{
    public partial class StudentProfile :Profile
    {
        public StudentProfile()
        {
            GetatSudentListMapping();
            GetatSingleStudentMapping();


        }
    }
}
