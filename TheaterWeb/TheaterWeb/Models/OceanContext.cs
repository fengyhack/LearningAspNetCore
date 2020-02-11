﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TheaterWeb.Models
{
    public partial class OceanContext : DbContext
    {
        public OceanContext()
        {
        }

        public OceanContext(DbContextOptions<OceanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Movies> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Desc).HasColumnName("desc");

                entity.Property(e => e.Genre)
                    .HasColumnName("genre")
                    .HasMaxLength(64);

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("date");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(128);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
