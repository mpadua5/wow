using Microsoft.Extensions.DependencyInjection;
using Wow.Application.Interface;
using Wow.Application.Service;
using Wow.Domain.Interfaces;
using Wow.Infra.Data.Context;
using Wow.Infra.Data.Repositories;

namespace Wow.Infra.CrossCutting.Ioc
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<TesteWowContext>();
            
            services.AddScoped<IAccountRepository, AccoutRepository>();
            
            services.AddScoped<IAccountService, AccountService>();
        }
    }
}