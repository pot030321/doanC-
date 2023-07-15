using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace lamlai_CAFE.Model
{
    public partial class StoreContextDB : DbContext
    {
        public StoreContextDB()
            : base("name=StoreContextDB")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<BILL> BILLs { get; set; }
        public virtual DbSet<BILLINFO> BILLINFOes { get; set; }
        public virtual DbSet<FOOD> FOODs { get; set; }
        public virtual DbSet<FOODCATEGORY> FOODCATEGORies { get; set; }
        public virtual DbSet<salary> salaries { get; set; }
        public virtual DbSet<STORE> STOREs { get; set; }
        public virtual DbSet<TABLEFOOD> TABLEFOODs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .HasMany(e => e.BILLINFOes)
                .WithRequired(e => e.ACCOUNT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ACCOUNT>()
                .HasMany(e => e.salaries)
                .WithRequired(e => e.ACCOUNT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BILL>()
                .HasMany(e => e.BILLINFOes)
                .WithRequired(e => e.BILL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FOOD>()
                .HasMany(e => e.BILLINFOes)
                .WithRequired(e => e.FOOD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FOODCATEGORY>()
                .HasMany(e => e.FOODs)
                .WithRequired(e => e.FOODCATEGORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TABLEFOOD>()
                .HasMany(e => e.BILLs)
                .WithRequired(e => e.TABLEFOOD)
                .WillCascadeOnDelete(false);
        }
    }
}
