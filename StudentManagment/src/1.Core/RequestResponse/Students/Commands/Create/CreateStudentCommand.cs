
using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace StudentManagment.Core.RequestResponse.Students.Commands.Create;

public class CreateStudentCommand : ICommand<Guid>, IWebRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalCode { get; set; }
    public string ProfileImageSourceUrl { get; set; }

    public string Path => "/api/Student/Create";
}
