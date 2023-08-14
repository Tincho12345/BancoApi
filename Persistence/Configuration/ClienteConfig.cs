using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Persistence.Configuration
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(160);

            builder.Property(p => p.Apellido)
                .IsRequired()
                .HasMaxLength(80);

            builder.Property(p => p.FechaNacimiento).IsRequired();

            builder.Property(p => p.Telefono)
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(p => p.Email)
                .HasMaxLength(100);

            builder.Property(p => p.Direccion)
                .HasMaxLength(160)
                .IsRequired();

            builder.Property(p => p.Edad);

            builder.Property(p => p.CreatedBy)
                .HasMaxLength(30);

            builder.Property(p => p.LastModifiedBy)
                .HasMaxLength(30);
        }
    }
}
