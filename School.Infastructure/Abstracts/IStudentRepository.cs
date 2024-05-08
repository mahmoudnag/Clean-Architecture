using School.Data.Entites;
using School.Infastructure.infastructureBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infastructure.Abstracts
{
    public interface IStudentRepository:IGenericRepositoryAsync<Student>
    {
        Task<List<Student>> GetAllStudentsAsync();
    }
}
