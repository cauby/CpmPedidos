﻿using CpmPedidos.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidos.Repositorio
{
    public class ImagemMap : DominioBaseMap<Imagem>
    {
        public ImagemMap() : base("tb_imagem") { }
        public override void Configure(EntityTypeBuilder<Imagem> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome)
                .HasColumnName("nome")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(x => x.NomeArquivo)
                .HasColumnName("nome_arquivo")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(x => x.Principal)
                .HasColumnName("principal")
                .IsRequired();
        }
    }
}