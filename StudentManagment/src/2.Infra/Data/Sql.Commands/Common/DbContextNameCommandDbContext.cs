using Microsoft.EntityFrameworkCore;
using StudentManagment.Core.Domain.Students.Entities;
using System.Reflection;
using Zamin.Extensions.Events.Abstractions;
using Zamin.Extensions.Events.Outbox.Dal.EF;

namespace StudentManagment.Infra.Data.Sql.Commands.Common;

public class DbContextNameCommandDbContext : BaseOutboxCommandDbContext
{
    public DbSet<Student> Students{ get; set; }
    public virtual DbSet<OutBoxEventItem> OutBoxEventItems { get; set; } = null;

    public DbContextNameCommandDbContext(DbContextOptions<DbContextNameCommandDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}