using Microsoft.EntityFrameworkCore;
using School.Data.Entites;
using School.Infastructure.Abstracts;
using School.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Service.implementations
{
   
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;
        public StudentService(IStudentRepository _studentRepository )
        {
            studentRepository= _studentRepository;
        }
        public async Task<List<Student>> GetAllStudentsAsync()
        {
          return await studentRepository.GetAllStudentsAsync();
        }

        public Task<Student> GetStudentByIDAsynck(int id)
        {
           var student= studentRepository.GetTableNoTracking().Include(std=>std.Department)
                                                  .Where(std=>std.StudID.Equals(id))
                                                  .FirstOrDefaultAsync();
            return student;


        }
    }
}
