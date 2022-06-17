using Approval_management.DataModel.Repository;
using Approval_management.DataModel.Repository.Interface;
using Approval_management.Mapper;
using Approval_management.Services;
using Approval_management.Services.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Approval_management.Extensions
{
    public static class DependencyInjection
    {
        public static void ConfigureDomainServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IRequestRepository, RequestRepository>();
            services.AddScoped<IRequestDetailService, RequestDetailService>();
            services.AddScoped<IUserInfoRepository, UserInfoRepository>();
            services.AddScoped<IUserInfoService, UserInfoService>();
            services.AddAutoMapper(typeof(ProfileMapper));
           
           
        }
    }
}
