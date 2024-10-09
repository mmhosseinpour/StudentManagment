
using StudentManagment.Core.Contracts.Students.Commands;
using StudentManagment.Core.Domain.Students.Entities;
using StudentManagment.Infra.Data.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace StudentManagment.Infra.Data.Sql.Commands.Students;

public class StudentCommandRepository :
    BaseCommandRepository<Student, DbContextNameCommandDbContext, long>,
    IStudentCommandRepository
{
    public StudentCommandRepository(DbContextNameCommandDbContext dbContext) : base(dbContext)
    {
    }
}
