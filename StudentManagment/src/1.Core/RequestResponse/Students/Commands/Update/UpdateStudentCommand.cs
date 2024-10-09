using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace StudentManagment.Core.RequestResponse.Students.Commands.Update;

public class UpdateStudentCommand : ICommand, IWebRequest
{
    public long Id { get; set; }
    public string FirstName { get; set; } 
    public string LastName { get; set; }
    public string NationalCode { get; set; }
    public string ProfileImageSourceUrl { get; set; }

    public string Path => "/api/Student/Update";
}
