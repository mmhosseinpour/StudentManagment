using StudentManagment.Core.RequestResponse.Students.Queries.GetById;
using StudentManagment.Core.RequestResponse.Students.Queries.GetList;

namespace StudentManagment.Core.Contracts.Students.Queries;

public interface IStudentQueryRepository 
{
    public Task<GetStudentByIdResponseModel?> ExecuteAsync(GetStudentByIdQuery query);

    public Task<GetStudentListResponseModel[]> ExecuteAsync(GetStudentListQuery query);
}