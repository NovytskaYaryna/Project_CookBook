namespace CookBook
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CookBookDB : DbContext
    {
        private static CookBookDB instance;

        private CookBookDB() : base("name=CookBookDB")
        { }

        public static CookBookDB getInstance()
        {
            if (instance == null)
                instance = new CookBookDB();
            return instance;
        }

        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Resipes> Resipes { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admins>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Admins>()
                .Property(e => e.surname)
                .IsUnicode(false);

            modelBuilder.Entity<Admins>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<Admins>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Categories>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Resipes)
                .WithRequired(e => e.Categories)
                .HasForeignKey(e => e.category_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resipes>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Resipes>()
                .Property(e => e.resipes1)
                .IsUnicode(false);

            modelBuilder.Entity<Resipes>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.surname)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Resipes)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);
        }
    }
}
