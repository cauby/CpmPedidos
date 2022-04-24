using CpmPedidos.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidos.Repositorio
{
    public class DominioBaseMap<TDomain> : IEntityTypeConfiguration<TDomain> where TDomain : DominioBase

    {
        private readonly string? _tableName;
        public DominioBaseMap(string tableName = "")
        {
            _tableName = tableName;
        }
        public virtual void Configure(EntityTypeBuilder<TDomain> builder)
        {
            if(!string.IsNullOrEmpty(_tableName))
            {
                builder.ToTable(_tableName);

                builder.HasKey(x => x.Id);
                builder.Property(x => x.Id)
                       .HasColumnName("id")
                       .ValueGeneratedOnAdd();

                builder.Property(x => x.CriadoEm)
                       .HasColumnName("criado_em")
                       .IsRequired();
            }
        }
    }
}
