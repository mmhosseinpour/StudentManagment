using Microsoft.EntityFrameworkCore;
using StudentManagment.Infra.Data.Sql.Queries.Students;
using Zamin.Infra.Data.Sql.Queries;

namespace StudentManagment.Infra.Data.Sql.Queries.Common;

public partial class DbContextNameQueryDbContext : BaseQueryDbContext
{
    public DbContextNameQueryDbContext(DbContextOptions<DbContextNameQueryDbContext> options) : base(options)
    {
    }
    public virtual DbSet<Student> Students { get; set; } = null;
    public virtual DbSet<OutBoxEventItem> OutBoxEventItems { get; set; } = null;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server =.;Database=DbContextNameDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OutBoxEventItem>(entity =>
        {
            entity.Property(e => e.AccuredByUserId).HasMaxLength(255);

            entity.Property(e => e.AggregateName).HasMaxLength(255);

            entity.Property(e => e.AggregateTypeName).HasMaxLength(500);

            entity.Property(e => e.EventName).HasMaxLength(255);

            entity.Property(e => e.EventTypeName).HasMaxLength(500);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}