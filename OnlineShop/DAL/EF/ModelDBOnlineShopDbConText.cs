namespace DAL.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelDBOnlineShopDbConText : DbContext
    {
        public ModelDBOnlineShopDbConText()
            : base("name=ModelDBOnlineShopDbConText")
        {
        }

        public virtual DbSet<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual DbSet<DANHMUC> DANHMUCs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DANHMUC>()
                .Property(e => e.Meta_Title)
                .IsFixedLength();

            modelBuilder.Entity<HOADON>()
                .Property(e => e.Status)
                .IsFixedLength();

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CHITIETHOADONs)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.Role)
                .IsFixedLength();

            modelBuilder.Entity<NGUOIDUNG>()
                .HasMany(e => e.CHITIETHOADONs)
                .WithOptional(e => e.NGUOIDUNG)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<NGUOIDUNG>()
                .HasMany(e => e.HOADONs)
                .WithOptional(e => e.NGUOIDUNG)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MetaTitle)
                .IsFixedLength();

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.CHITIETHOADONs)
                .WithRequired(e => e.SANPHAM)
                .HasForeignKey(e => e.ProductID)
                .WillCascadeOnDelete(false);
        }
    }
}
