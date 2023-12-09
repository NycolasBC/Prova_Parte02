using CartasNoel.Catalogo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasNoel.Catagolo.Persistance.EntityFramework
{
    public class CartasConfiguration : IEntityTypeConfiguration<Cartas>
    {
        public void Configure(EntityTypeBuilder<Cartas> builder)
        {
            builder.ToTable("TB_CARTAS_NOEL");
            builder.HasKey(c => c.Id);

            builder
                .Property(c => c.Id)
                .UseIdentityColumn()
                .HasColumnName("CARTAS_ID")
                .HasColumnType("int");

            builder
                .Property(c => c.Nome)
                .HasColumnName("NOME")
                .HasColumnType("varchar(255)");

            builder
                .Property(c => c.Rua)
                .HasColumnName("RUA")
                .HasColumnType("varchar(50)");

            builder
                .Property(c => c.Numero)
                .HasColumnName("NUMERO")
                .HasColumnType("int");

            builder
                .Property(c => c.Bairro)
                .HasColumnName("BAIRRO")
                .HasColumnType("varchar(50)");

            builder
                .Property(c => c.Cidade)
                .HasColumnName("CIDADE")
                .HasColumnType("varchar(50)");

            builder
                .Property(c => c.UF)
                .HasColumnName("UF")
                .HasColumnType("char(2)");

            builder
                .Property(c => c.Idade)
                .HasColumnName("IDADE")
                .HasColumnType("int");

            builder
                .Property(c => c.TextoCarta)
                .HasColumnName("TEXTO_CARTA")
                .HasColumnType("varchar(500)");
        }
    }
}
