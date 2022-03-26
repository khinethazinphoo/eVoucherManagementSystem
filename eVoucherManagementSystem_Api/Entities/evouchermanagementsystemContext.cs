using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace eVoucherManagementSystem_Api.Entities
{
    public partial class evouchermanagementsystemContext : DbContext
    {
        public evouchermanagementsystemContext()
        {
        }

        public evouchermanagementsystemContext(DbContextOptions<evouchermanagementsystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblEvoucher> TblEvouchers { get; set; }
        public virtual DbSet<TblPurchasehistory> TblPurchasehistories { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("Server=localhost;User=root;Password=root@123;database=evouchermanagementsystem");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblEvoucher>(entity =>
            {
                entity.HasKey(e => e.EvoucherId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_evoucher");

                entity.Property(e => e.EvoucherId).HasColumnName("EVoucherId");

                entity.Property(e => e.Amount).HasColumnType("decimal(18,2)");

                entity.Property(e => e.BuyType).HasMaxLength(45);

                entity.Property(e => e.DateExpire).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.GiftperUserlimit).HasMaxLength(45);

                entity.Property(e => e.Image).HasMaxLength(500);

                entity.Property(e => e.IsActive).HasColumnType("bit(1)");

                entity.Property(e => e.Name).HasMaxLength(45);

                entity.Property(e => e.PaymentMethod).HasMaxLength(45);

                entity.Property(e => e.PhoneNumber).HasMaxLength(45);

                entity.Property(e => e.Quantity).HasMaxLength(45);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.UserId).HasMaxLength(50);
            });

            modelBuilder.Entity<TblPurchasehistory>(entity =>
            {
                entity.HasKey(e => e.PurchaseHistoryId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_purchasehistory");

                entity.Property(e => e.Amount).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Base64ForQr)
                    .HasMaxLength(500)
                    .HasColumnName("Base64ForQR");

                entity.Property(e => e.BuyType).HasMaxLength(45);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ExpiryDate).HasMaxLength(50);

                entity.Property(e => e.GiftperUserlimit).HasMaxLength(45);

                entity.Property(e => e.Image).HasMaxLength(500);

                entity.Property(e => e.IsActive).HasColumnType("bit(1)");

                entity.Property(e => e.IsUsed).HasColumnType("bit(1)");

                entity.Property(e => e.Name).HasMaxLength(45);

                entity.Property(e => e.PaymentMethod).HasMaxLength(45);

                entity.Property(e => e.PhoneNumber).HasMaxLength(45);

                entity.Property(e => e.PromoCode).HasMaxLength(12);

                entity.Property(e => e.Quantity).HasMaxLength(45);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.UserId).HasMaxLength(50);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("tbl_user");

                entity.Property(e => e.Name).HasMaxLength(45);

                entity.Property(e => e.Phone).HasMaxLength(45);

                entity.Property(e => e.UserId).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
