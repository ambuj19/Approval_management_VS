﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Approval_management.DataModel.Entities
{
    public partial class BudgetRequestContext : DbContext
    {
        public BudgetRequestContext()
        {
        }

        public BudgetRequestContext(DbContextOptions<BudgetRequestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ForwordedRequestDetail> ForwordedRequestDetails { get; set; }
        public virtual DbSet<RequestDetail> RequestDetails { get; set; }
        public virtual DbSet<UserInfo> UserInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=DefautConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ForwordedRequestDetail>(entity =>
            {
                entity.HasKey(e => e.ForwordedRequestId)
                    .HasName("PK__Forworde__D9BD5F08E31BF770");

                entity.ToTable("ForwordedRequestDetail");

                entity.Property(e => e.AdvAmount).HasColumnName("Adv_Amount");

                entity.Property(e => e.Comments).HasMaxLength(200);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.EstAmount).HasColumnName("Est_Amount");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDate).HasColumnType("date");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.ForwordedRequestDetails)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("FK__Forworded__Reque__36B12243");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ForwordedRequestDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Forworded__UserI__37A5467C");
            });

            modelBuilder.Entity<RequestDetail>(entity =>
            {
                entity.HasKey(e => e.RequestId)
                    .HasName("PK__RequestD__33A8519A8644BC47");

                entity.ToTable("RequestDetail");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.AdvAmount).HasColumnName("Adv_Amount");

                entity.Property(e => e.Comments).HasMaxLength(200);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.EstAmount).HasColumnName("Est_Amount");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RequestDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__RequestDe__UserI__267ABA7A");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserInfo__1788CCACED84A3BC");

                entity.ToTable("UserInfo");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserID");

                entity.Property(e => e.Designation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(100)
                    .HasColumnName("EmailID");

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
