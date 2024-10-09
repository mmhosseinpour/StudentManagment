using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace StudentManagment.Core.RequestResponse.Students.Commands.Delete;

public class DeleteStudentCommand : ICommand, IWebRequest
{
    public long Id { get; set; }

    public string Path => "/api/Student/Delete";
}
