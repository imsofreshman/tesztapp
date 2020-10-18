using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;


namespace ShoppingDataAccessLayer.Models
{
    public class ShoppingContext : DbContext
    {
        public ShoppingContext() : base("name=MySqlServerConnectionString")
        {
            Database.SetInitializer<ShoppingContext>(new ShoppingInitializer());
        }



        public DbSet<ShoppingOccasion> ShoppingOccasions { get; set; }
        public DbSet<ShoppingPlace> shoppingPlaces { get; set; }
        public DbSet<ShoppingItem> ShoppingItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShoppingOccasion>().ToTable("ShoppingOccasion");
            modelBuilder.Entity<ShoppingOccasion>().HasKey(x => x.ShoppingOccasionID);
            modelBuilder.Entity<ShoppingOccasion>().Property(x => x.Description).HasMaxLength(50);

            modelBuilder.Entity<ShoppingPlace>().ToTable("ShoppingPlace");
            modelBuilder.Entity<ShoppingPlace>().HasKey(x => x.ShoppingPlaceID);
            modelBuilder.Entity<ShoppingPlace>().Property(x => x.Address).HasMaxLength(200);
            modelBuilder.Entity<ShoppingPlace>().Property(x => x.Name).HasMaxLength(50);

            modelBuilder.Entity<ShoppingItem>().ToTable("ShoppingItem");
            modelBuilder.Entity<ShoppingItem>().HasKey(x => x.ShoppingItemID);
            modelBuilder.Entity<ShoppingItem>().Property(x => x.ItemName).HasMaxLength(50);
            modelBuilder.Entity<ShoppingItem>().Property(x => x.UnitOfMeasure).HasMaxLength(10);

            base.OnModelCreating(modelBuilder);
        }
    }
}
