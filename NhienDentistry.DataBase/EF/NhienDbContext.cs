
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NhienDentistry.DataBase.Entities;
using NhienDentistry.DataBase.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NhienDentistry.DataBase.EF
{
    public class NhienDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public NhienDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////Configure using Fluent API
            //modelBuilder.ApplyConfiguration(new CartConfiguration());

            //modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            //modelBuilder.ApplyConfiguration(new ProductConfiguration());
            //modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new OrderConfiguration());

            //modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            //modelBuilder.ApplyConfiguration(new CategoryTranslationConfiguration());
            //modelBuilder.ApplyConfiguration(new ContactConfiguration());
            //modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            //modelBuilder.ApplyConfiguration(new ProductTranslationConfiguration());
            //modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            //modelBuilder.ApplyConfiguration(new TransactionConfiguration());

            //modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            //modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            //modelBuilder.ApplyConfiguration(new ProductImageConfiguration());
            //modelBuilder.ApplyConfiguration(new SlideConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            //Data seeding
            modelBuilder.Seed();
            //base.OnModelCreating(modelBuilder);
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