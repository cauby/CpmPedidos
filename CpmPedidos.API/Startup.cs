using CpmPedidos.Repositorio;
using Npgsql;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CpmPedidos.API
{
    public class Startup: IStartup
    {
        public IConfiguration Configuration { get; }
        public DbConnection DbConnection => new NpgsqlConnection(Configuration.GetConnectionString("App"));
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AplicacaoDbContext>(options =>
            {
                options.UseNpgsql(
                    DbConnection,
                    assembly => assembly.MigrationsAssembly(typeof(AplicacaoDbContext).Assembly.FullName));
            });

            DependencyInjection.Register(services);
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
        }

    }

    // A partir daqui intercaces e classe para o dotnet 6 conehcer o startup
    public interface IStartup
    {
        IConfiguration Configuration { get; }
        void Configure(WebApplication app, IWebHostEnvironment environment);
        void ConfigureServices(IServiceCollection services);
    }

    public static class StartupExtensions
    {
        public static WebApplicationBuilder UseStartup<TStartup>(this WebApplicationBuilder WebAppBuilder) where TStartup : IStartup
        {
            var startup = Activator.CreateInstance(typeof(TStartup), WebAppBuilder.Configuration) as IStartup;
            if (startup == null) throw new ArgumentException("Classe Strtup.cs invalida!");

            startup.ConfigureServices(WebAppBuilder.Services);
            var app = WebAppBuilder.Build();
            startup.Configure(app, app.Environment);
            app.Run();
            return WebAppBuilder;
        }
    }
}
