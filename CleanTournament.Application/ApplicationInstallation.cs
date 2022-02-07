using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CleanTournament.Application
{
    public static class ApplicationInstallation
    {

        public static IServiceCollection TournamentApplications(this IServiceCollection service)
        {
            service.AddAutoMapper(Assembly.GetExecutingAssembly());
            service.AddMediatR(Assembly.GetExecutingAssembly());

            return service;
        }
    }
}
