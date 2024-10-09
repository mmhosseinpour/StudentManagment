
using Zamin.Core.RequestResponse.Endpoints;
using Zamin.Core.RequestResponse.Queries;

namespace StudentManagment.Core.RequestResponse.Students.Queries.GetList;

public class GetStudentListQuery : IQuery<GetStudentListResponseModel[]>, IWebRequest
{
    public byte Take { get; set; }
    public int Page { get; set; }
    public string Path => "/api/Student/get-list";
}
