
using BackendProductApi.Infraestructura.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BackendProductApi.Infraestructura
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ProductoContexto>
    {
        public ProductoContexto CreateDbContext(string[] args)
        {

            var builder = new DbContextOptionsBuilder<ProductoContexto>();

            var connectionString = "Server =(localdb)\\MSSQLLocalDB;Database=BDMarket;Trusted_Connection=True;MultipleActiveResultSets=True";

            builder.UseSqlServer(connectionString);

            return new ProductoContexto(builder.Options);
        }
    }
}
