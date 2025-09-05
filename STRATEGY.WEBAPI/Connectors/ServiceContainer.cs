using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using STRATEGY.WEBAPI.Contract;
using STRATEGY.WEBAPI.Data;
using System.Collections.Generic;

namespace STRATEGY.WEBAPI.Connectors
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfrustructureService(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(o => o.UseSqlServer(config.GetConnectionString("DbConnector"),
                b => b.MigrationsAssembly(typeof(ServiceContainer).Assembly.FullName)),
                ServiceLifetime.Transient);

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    ValidIssuer = config["JwtSection:Issuer"],
                    ValidAudience = config["JwtSection:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(config["JwtSection:Key"])),
                    ClockSkew = TimeSpan.Zero,
                };
            });


            services.AddCors(options =>
            {
                options.AddPolicy("CorsApi",
                    builder => builder.WithOrigins("https://localhost:7148", "http://mywebsite.com")
                    .AllowAnyHeader()
                        .AllowAnyMethod());
            });

            services.AddAuthentication();
            services.AddAuthorization();
            services.AddScoped<IUser, UserRepository>();
            services.AddScoped<IStrategy, StrategyRepository>();
            return services;
        }
    }
}
