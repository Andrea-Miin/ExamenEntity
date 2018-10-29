namespace ExamenEntity
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Pizzeria : DbContext
    {
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }

        public Pizzeria()
            : base("name=Pizzeria.Context")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().Property(x => x.Id).IsRequired();
            modelBuilder.Entity<Pizza>().Property(x => x.Name).IsRequired().HasMaxLength(20);

            modelBuilder.Entity<Ingredient>().Property(x => x.Id).IsRequired();
            modelBuilder.Entity<Ingredient>().Property(x => x.Name).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Ingredient>().Property(x => x.Price).IsRequired();
        }
    }
}