using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TailorIT.UserTools.Domain.Entities;

namespace TailorIT.UserTools.Infra.Data.Mapping
{
    public class SexoMap : IEntityTypeConfiguration<Sexo>
    {
        public void Configure(EntityTypeBuilder<Sexo> builder)
        {
            builder.ToTable("Sexo");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("SexoId");

            builder.Property(c => c.Description)
                .HasColumnName("Descricao")
                .HasMaxLength(15)
                .IsRequired();
     
        }
    }
}
