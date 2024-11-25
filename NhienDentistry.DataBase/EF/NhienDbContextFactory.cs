using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhienDentistry.DataBase.EF
{
    public class NhienDbContextFactory : IDesignTimeDbContextFactory<NhienDbContext>
    {
        public NhienDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("NhienDentistryConnection");

            var optionsBuilder = new DbContextOptionsBuilder<NhienDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new NhienDbContext(optionsBuilder.Options);
        }
    }
}
