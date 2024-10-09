
using StudentManagment.Core.Contracts.Students.Commands;
using StudentManagment.Core.Domain.Students.Entities;
using StudentManagment.Core.RequestResponse.Students.Commands.Create;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Toolkits.ValueObjects;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace StudentManagment.Core.ApplicationService.Students.Commands.Create;

public class CreateStudentCommandHandler : CommandHandler<CreateStudentCommand, Guid>
{
    private readonly IStudentCommandRepository _studentCommandRepository;

    public CreateStudentCommandHandler(ZaminServices zaminServices,
        IStudentCommandRepository studentCommandRepository) : base(zaminServices)
        => _studentCommandRepository = studentCommandRepository;
    public override async Task<CommandResult<Guid>> Handle(CreateStudentCommand command)
    {

        Student student = Student.Create(command.FirstName, command.LastName, command.NationalCode, command.ProfileImageSourceUrl);

        await _studentCommandRepository.InsertAsync(student);
        await _studentCommandRepository.CommitAsync();

        return Ok(student.BusinessId.Value);
    }
}
