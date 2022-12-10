using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dataannotation.Models.EF
{
    public partial class bankingDBContext : DbContext
    {
        public bankingDBContext()
        {
        }

        public bankingDBContext(DbContextOptions<bankingDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountInfo> AccountInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:training-server-nikhil.database.windows.net,1433;Initial Catalog=bankingDB;Persist Security Info=False;User ID=trainer;Password=Password@1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountInfo>(entity =>
            {
                entity.HasKey(e => e.AccNo)
                    .HasName("PK__AccountI__A471970519DB075B");

                entity.ToTable("AccountInfo");

                entity.Property(e => e.AccNo)
                    .ValueGeneratedNever()
                    .HasColumnName("accNo");

                entity.Property(e => e.AccBalance).HasColumnName("accBalance");

                entity.Property(e => e.AccEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("accEmail");

                entity.Property(e => e.AccIsActive).HasColumnName("accIsActive");

                entity.Property(e => e.AccName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("accName");

                entity.Property(e => e.AccType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("accType");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
