using CodeFirstRelationPractic.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelationPractic.Context
{
    public class PatikaSecondDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<PostEntity> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-VJ0SM5I\SQLEXPRESS; database=PatikaCodeFirstDb2; TrustServerCertificate=true; trusted_connection = true;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<PostEntity>()
                        .HasOne(x => x.User)
                        .WithMany(x => x.Posts)
                        .HasForeignKey(x => x.UserId);

        }
    }
}
