using Approval_management.DataModel.Repository;
using Approval_management.DataModel.Repository.Interface;
using Approval_management.Mapper;
using Approval_management.Services;
using Approval_management.Services.Interface;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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
            services.AddScoped<ITokenService, TokenService>();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options => options.TokenValidationParameters =
                new TokenValidationParameters
                {

                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["TokenKey"])),
                    ValidateIssuer = false,
                    ValidateAudience = false

                });

        }
    }
}
