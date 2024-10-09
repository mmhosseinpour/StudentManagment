using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagment.Core.RequestResponse.Students.Commands.Create;
using StudentManagment.Core.RequestResponse.Students.Commands.Delete;
using StudentManagment.Core.RequestResponse.Students.Commands.Update;
using StudentManagment.Core.RequestResponse.Students.Queries.GetById;
using StudentManagment.Core.RequestResponse.Students.Queries.GetList;
using Zamin.EndPoints.Web.Controllers;

namespace StudentManagment.Endpoints.API.Students;

[Route("api/[controller]")]
[ApiController]
public class StudentController : BaseController
{
    #region Commands
    [HttpPost("create")]
    public async Task<IActionResult> CreateStudent([FromBody] CreateStudentCommand command) => await Create<CreateStudentCommand, Guid>(command);
    [HttpPut("update")]
    public async Task<IActionResult> UpdateStudent([FromBody] UpdateStudentCommand command) => await Edit<UpdateStudentCommand>(command);
    [HttpDelete("delete/{Id}")]
    public async Task<IActionResult> RemoveStudent([FromRoute] DeleteStudentCommand command) => await Delete<DeleteStudentCommand>(command);
    #endregion
    #region Queries
    [HttpGet("get-by-id/{Id}")]
    public async Task<IActionResult> GetById([FromRoute] GetStudentByIdQuery query)
        => await Query<GetStudentByIdQuery, GetStudentByIdResponseModel>(query);

    [HttpGet("get-list")]
    public async Task<IActionResult> GetList([FromQuery] GetStudentListQuery query)
        => await Query<GetStudentListQuery, GetStudentListResponseModel[]>(query);
    #endregion

}
