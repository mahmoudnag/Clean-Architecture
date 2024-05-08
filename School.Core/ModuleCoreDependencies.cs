using Microsoft.Extensions.DependencyInjection;
using School.Service.Abstracts;
using School.Service.implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace School.Core
{
    public static class ModuleCoreDependencies
    {
        public static IServiceCollection AddModuleCoreDependencies(this IServiceCollection service)
        {
            //Configuration MediatR
            service.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            //Configuration AutoMapper
            service.AddAutoMapper(Assembly.GetExecutingAssembly());
            return service;


        }
    }
}
