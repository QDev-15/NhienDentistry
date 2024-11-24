
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NhienDentistry.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NhienDentistry.Data.EF
{
    public class NhienDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public NhienDbContext(DbContextOptions options) : base(options)
        {
        }

        
        public DbSet<AppConfig> AppConfigs { get; set; }
        public DbSet<Base> Bases { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryTranslation> CategoryTranslations { get; set; }    
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Image> Images { get; set; }    
        public DbSet<Language> Languages { get; set; }
        public DbSet<Logger> Loggers { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Slide> Slides { get; set;}

    }
}