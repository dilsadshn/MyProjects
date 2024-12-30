using Microsoft.EntityFrameworkCore;
using PerakendeApp.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerakendeApp.DAL.Context
{
    public class AppDbContext : DbContext 
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=PerakendeSatisDb;Uid=root;password=634234", new MySqlServerVersion(new Version(8, 0, 40)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User ve Satis ilişkisi
            modelBuilder.Entity<User>()
                .HasMany(u => u.Satislar)
                .WithOne(s => s.User)
                .HasForeignKey(s => s.UserId);

            // Satis ve CartItem ilişkisi
            modelBuilder.Entity<Satis>()
                .HasMany(s => s.CartItems)
                .WithOne(ci => ci.Satis)
                .HasForeignKey(ci => ci.SatisId);

            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Satis)
                .WithMany(s => s.CartItems)
                .HasForeignKey(ci => ci.SatisId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
