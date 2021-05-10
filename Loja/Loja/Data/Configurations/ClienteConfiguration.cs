﻿using Loja.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Loja.Data.Configurations
{
    class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(p => p.CPF).HasColumnType("VARCHAR(11)").IsRequired();
            builder.Property(p => p.DataNascimento);
            builder.Property(p => p.Telefone).HasColumnType("VARCHAR(11)").IsRequired();
            builder.Property(p => p.Email).HasColumnType("VARCHAR(80)");
            builder.Property(p => p.CEP).HasColumnType("VARCHAR(8)").IsRequired();
            builder.Property(p => p.Numero).IsRequired();
            builder.Property(p => p.Cidade).HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(p => p.Estado).HasColumnType("VARCHAR(2)").IsRequired();
        }
    }
}
