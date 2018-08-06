using Microsoft.EntityFrameworkCore;
using TailorIT.UserTools.Domain.Entities;
using TailorIT.UserTools.Infra.Data.Mapping;

namespace TailorIT.UserTools.Infra.Data.Contexts
{
    public sealed class TailorItContext : DbContext
    {
        public TailorItContext(DbContextOptions<TailorItContext> options) : base(options)
                 => Database.EnsureCreated();

        public DbSet<User> Users { get; set; }
        public DbSet<Sexo> Sexo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sexo>()
                .HasMany(c => c.User)
                .WithOne(e => e.Sexo).HasForeignKey(c=> c.IdSexo).IsRequired();

            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new SexoMap());

            modelBuilder.Entity<Sexo>().HasData(new Sexo { Id = 1, Description = "Masculino" },
                                                new Sexo { Id = 2, Description = "Feminino" });

        }
    }
}
