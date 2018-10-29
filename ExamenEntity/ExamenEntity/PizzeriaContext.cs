namespace ExamenEntity
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IUnitOfWork
    {
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task<int> SaveChangesAsync();
    }

    public class PizzeriaContext : DbContext, IUnitOfWork
    {
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }

        public PizzeriaContext()
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