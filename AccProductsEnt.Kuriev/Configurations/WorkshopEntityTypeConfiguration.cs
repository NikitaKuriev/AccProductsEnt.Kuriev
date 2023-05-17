﻿using AccProductsEnt.Kuriev.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccProductsEnt.Kuriev.Configurations
{
    public class WorkshopEntityTypeConfiguration : IEntityTypeConfiguration<Workshop>
    {
        public void Configure(EntityTypeBuilder<Workshop> builder)
        {
            builder.HasKey(ws => ws.Id)
                .HasName("PK_Workshop_Id");

            builder.Property(ws => ws.WorkshopName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

           /////
        }
    }
}
