using SmartScript_NETCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace SmartScript_NETCore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
            {
                //System.Configuration.Configurationmanager
            }

        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Chemical> Chemicals { get; set; }
        public DbSet<Effect> Effects { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<UserVariant> UserVariants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<UserRow> UserRows { get; set; }


                protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Ingredient>()
                .HasKey(k => new{k.ChemicalID, k.DrugID});

            modelBuilder.Entity<Effect>()
                .HasKey(k => new{k.ChemicalID, k.VariantID});

            modelBuilder.Entity<UserVariant>()
                .HasKey(k => new{k.VariantID, k.UserID});

            modelBuilder.Entity<Prescription>()
                .HasKey(k => new{k.UserID, k.DrugID});


            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }




    }
}