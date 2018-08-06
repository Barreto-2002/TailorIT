using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TailorIT.UserTools.Domain.Entities;

namespace TailorIT.UserTools.Infra.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(c => c.Id).HasName("UsuarioId");

            builder.Property(c => c.Name)
                .HasColumnName("Nome")
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(c => c.BirthDate)
                .HasColumnName("DataNascimento")
                .IsRequired();

            builder.Property(c => c.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(c => c.Senha)
                .HasColumnType("varchar(30)")
                .IsRequired();

            builder.Property(c => c.IdSexo)
                .HasColumnName("SexoId")
                .IsRequired();

            builder.Property(c => c.Active)
                .HasColumnName("Ativo")
                   .IsRequired();


        }
    }
}
