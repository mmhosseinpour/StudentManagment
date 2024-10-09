using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace StudentManagment.Infra.Data.Sql.Commands.Common;

public class DbContextNameCommandDbContextFactory : IDesignTimeDbContextFactory<DbContextNameCommandDbContext>
{
    public DbContextNameCommandDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<DbContextNameCommandDbContext>();

        builder.UseSqlServer("Server =.;Database=DbContextNameDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");

        return new DbContextNameCommandDbContext(builder.Options);
    }
}