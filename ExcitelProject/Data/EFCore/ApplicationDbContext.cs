using ExcitelProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExcitelProject.Data.EFCore
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Lead> Leads { get; set; }

        public DbSet<Subarea> Subareas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            for (int i = 0; i < 20; i++)
            {
                builder.Entity<Subarea>().HasData(
                              new Subarea
                              {
                                  Id = i + 1,
                                  Name = $"Subarea name {i + 1}",
                                  PINCode = (i + 1) * 100000,
                              });
            }
        }

    }
}