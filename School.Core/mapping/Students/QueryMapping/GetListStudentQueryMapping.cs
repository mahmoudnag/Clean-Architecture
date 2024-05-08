using School.Core.Features.Students.Queries.Results;
using School.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.mapping.Students
{
    public partial class StudentProfile
    {
        public void GetatSudentListMapping()
        {
            CreateMap<Student, GetStudentListResponse>()
                    .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.DName));
        }
        public void GetatSingleStudentMapping()
        {
            CreateMap<Student, GetSingleStudentResponse>()
                    .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.DName));
        }
    }
}
