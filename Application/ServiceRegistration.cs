using Application.Services.StudentServices.Queries;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public static class ServiceRegistration
    {


        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddScoped<IGetAllStudentsQuery, GetAllStudentsQuery>();
        }
    }
}
