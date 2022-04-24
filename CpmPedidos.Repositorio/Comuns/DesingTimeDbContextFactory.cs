﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CpmPedidos.Repositorio
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AplicacaoDbContext>
    {
        public AplicacaoDbContext CreateDbContext(string[] args)
        {
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var fileName = Directory.GetCurrentDirectory() + $"/../CpmPedidos.API/appsettings.{environmentName}.json";

            var configuration = new ConfigurationBuilder().AddJsonFile(fileName).Build();
            var connectionString = configuration.GetConnectionString("App");

            var builder = new DbContextOptionsBuilder<AplicacaoDbContext>();
            builder.UseNpgsql(connectionString);

            return new AplicacaoDbContext(builder.Options);
        }
    }
}
