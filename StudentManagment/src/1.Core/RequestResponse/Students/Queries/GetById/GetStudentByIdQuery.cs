
using Zamin.Core.RequestResponse.Endpoints;
using Zamin.Core.RequestResponse.Queries;

namespace StudentManagment.Core.RequestResponse.Students.Queries.GetById;

public class GetStudentByIdQuery : IQuery<GetStudentByIdResponseModel>, IWebRequest
{
    public long Id { get; set; }

    public string Path => "/api/Student/GetById";
}
