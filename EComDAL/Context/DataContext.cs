using EComDAL.Model;
using Microsoft.EntityFrameworkCore;

namespace EComDAL.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Cart>? Carts { get; set; }
        public DbSet<CartItem>? CartItems { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Country>? Countries { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<OrderItem>? OrderItems { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Province>? Provinces { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<SubCategory>? SubCategories { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Currency> Currencies { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Country>()
                .HasMany(p => p.Provinces)
                .WithOne(c => c.Country)
                .HasForeignKey(c => c.CountryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(us => us.Carts)
                .WithOne(u => u.User)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Cart>()
                .HasMany(ca => ca.CartItems)
                .WithOne(us => us.Cart)
                .HasForeignKey(us => us.CartId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Product>()
                .HasMany(ca => ca.CartItems)
                .WithOne(us => us.Product)
                .HasForeignKey(us => us.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Category>()
                .HasMany(subcat => subcat.SubCategories)
                .WithOne(cat => cat.Category)
                .HasForeignKey(cat => cat.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(or => or.Orders)
                .WithOne(u => u.User)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
                .HasMany(ori => ori.OrderItems)
                .WithOne(or => or.Order)
                .HasForeignKey(or => or.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>()
                .HasMany(ori => ori.OrderItems)
                .WithOne(us => us.Product)
                .HasForeignKey(us => us.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(pa => pa.Payments)
                .WithOne(us => us.User)
                .HasForeignKey(us => us.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
                .HasMany(pa => pa.Payments)
                .WithOne(or => or.Order)
                .HasForeignKey(or => or.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Currency>()
                .HasMany(pa => pa.Payments)
                .WithOne(cu => cu.Currency)
                .HasForeignKey(cu => cu.CurrencyId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Category>()
                .HasMany(p => p.Products)
                .WithOne(ca => ca.Category)
                .HasForeignKey(ca => ca.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Role>()
                .HasMany(u => u.Users)
                .WithOne(ro => ro.Role)
                .HasForeignKey(ro => ro.RoleId)
                .OnDelete(DeleteBehavior.Cascade);


        }

    }
}
