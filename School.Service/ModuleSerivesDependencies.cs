using Microsoft.Extensions.DependencyInjection;
using School.Infastructure.Abstracts;
using School.Infastructure.Repositories;
using School.Service.Abstracts;
using School.Service.implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Service
{
    public static class ModuleSerivesDependencies
    {
        public static IServiceCollection AddModuleSerivesDependencies(this IServiceCollection service)
        {
            service.AddTransient<IStudentService, StudentService>();

            return service;


        }
    }
}
