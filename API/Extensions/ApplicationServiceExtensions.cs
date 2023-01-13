using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Persistence;
using Application.WorkflowJobs;
using Application.Core;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
            IConfiguration config)
        {
            // There's probably a better way to set this up. This follows the spirit of this
            // suggestion from 2019:
            // https://github.com/dotnet/aspnetcore/issues/9337#issuecomment-539859667
            using var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
                builder.AddEventSourceLogger();
            });
            var logger = loggerFactory.CreateLogger("ApplicationServiceExtensions");

            services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPIv5", Version = "v1" });
                });
            services.AddDbContext<DataContext>(opt =>
            {
                string pgUsername = Environment.GetEnvironmentVariable("PG_USERNAME");
                string pgPassword = Environment.GetEnvironmentVariable("PG_PASSWORD");
                string pgServer = Environment.GetEnvironmentVariable("PG_SERVER");
                string pgDatabase = Environment.GetEnvironmentVariable("PG_DATABASE");

                if (pgUsername == null) logger.LogInformation("PG_USERNAME environment variable not set");
                if (pgPassword == null) logger.LogInformation("PG_PASSWORD environment variable not set");
                if (pgServer == null) logger.LogInformation("PG_SERVER environment variable not set");
                if (pgDatabase == null) logger.LogInformation("PG_DATABASE environment variable not set");

                bool UseEnvVars = pgUsername != null && pgPassword != null && pgServer != null && pgDatabase != null;

                if (!UseEnvVars)
                    logger.LogWarning("Using development database connection string.");

                string connectionString = UseEnvVars
                    ? $"Host={pgServer};Database={pgDatabase};Username={pgUsername};Password={pgPassword}"
                    : config.GetConnectionString("DefaultConnection");

                opt.UseNpgsql(connectionString);
            });

            // For development
            // services.AddCors(opt =>
            // {
            //     opt.AddPolicy("CorsPolicy", policy =>
            //     {
            //         policy.AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:3000");
            //     });
            // });

            services.AddMediatR(typeof(List.Handler).Assembly);
            services.AddAutoMapper(typeof(MappingProfiles).Assembly);

            return services;
        }
    }
}