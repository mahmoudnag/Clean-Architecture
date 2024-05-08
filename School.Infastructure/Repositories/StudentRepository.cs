using Microsoft.EntityFrameworkCore;
using School.Data.Entites;
using School.Infastructure.Abstracts;
using School.Infastructure.Data;
using School.Infastructure.infastructureBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infastructure.Repositories
{
    public class StudentRepository : GenericRepositoryAsync<Student>, IStudentRepository
    {
        private readonly DbSet<Student> _student;
        public StudentRepository(ApplicationDBContext _applicationDBContext):base(_applicationDBContext) {


            _student= _applicationDBContext.Set<Student>();

        }
        public  async Task<List<Student>> GetAllStudentsAsync()
        {
            
            return await _student.Include(x=>x.Department).ToListAsync();
        }
    }
}
