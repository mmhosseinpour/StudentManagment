using Microsoft.EntityFrameworkCore;
using StudentManagment.Core.Contracts.Students.Queries;
using StudentManagment.Core.RequestResponse.Students.Queries.GetById;
using StudentManagment.Core.RequestResponse.Students.Queries.GetList;
using StudentManagment.Infra.Data.Sql.Queries.Common;
using Zamin.Infra.Data.Sql.Queries;

namespace StudentManagment.Infra.Data.Sql.Queries.Students;

internal class StudentQueryRepository : BaseQueryRepository<DbContextNameQueryDbContext>, IStudentQueryRepository
{
    public StudentQueryRepository(DbContextNameQueryDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<GetStudentByIdResponseModel?> ExecuteAsync(GetStudentByIdQuery query)
    {

        return await _dbContext.Students.Select(x => new GetStudentByIdResponseModel()
        {
            Id = x.Id,
            Firstname = x.FirstName,
            LastName = x.LastName,
            NationalCode = x.NationalCode,
            ProfileImageSourceUrl = x.ProfileImageSourceUrl
        }).FirstOrDefaultAsync(x => x.Id.Equals(query.Id));
    }

    public async Task<GetStudentListResponseModel[]> ExecuteAsync(GetStudentListQuery query)
    {
        return await _dbContext.Students.Select(x => new GetStudentListResponseModel()
        {
            Id = x.Id,
            FirstName = x.FirstName,
            LastName = x.LastName,
        }).Skip((query.Page - 1) * query.Page).Take(query.Take).ToArrayAsync();
    }
}
