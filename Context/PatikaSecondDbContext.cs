using Microsoft.EntityFrameworkCore;
using Week12_CodeFirstRelation.Entities;

namespace Week12_CodeFirstRelation.Context
{
    public class PatikaSecondDbContext : DbContext
    {
        // BİRİNCİ BÜYÜK
        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent Api
            modelBuilder.Entity<UserEntity>().Property(x => x.UserName)
                .IsRequired()
                .HasMaxLength(15);

            modelBuilder.Entity<PostEntity>().Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(30);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<UserEntity> Users => Set<UserEntity>();
        public DbSet<PostEntity> Posts => Set<PostEntity>();
       
    }
}
