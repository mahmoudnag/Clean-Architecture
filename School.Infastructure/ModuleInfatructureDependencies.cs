using Microsoft.Extensions.DependencyInjection;
using School.Infastructure.Abstracts;
using School.Infastructure.infastructureBase;
using School.Infastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infastructure
{
    public static class ModuleInfatructureDependencies
    {
        public  static IServiceCollection AddModuleInfatructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository,StudentRepository>();
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));

            return services;


        }
    }
}
