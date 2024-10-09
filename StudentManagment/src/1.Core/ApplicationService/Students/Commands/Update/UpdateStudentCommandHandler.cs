using StudentManagment.Core.Contracts.Students.Commands;
using StudentManagment.Core.Domain.Students.Entities;
using StudentManagment.Core.RequestResponse.Students.Commands.Update;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.Domain.Toolkits.ValueObjects;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace StudentManagment.Core.ApplicationService.Students.Commands.Update;

public class UpdateStudentCommandHandler : CommandHandler<UpdateStudentCommand>
{
    private IStudentCommandRepository _studentCommandRepository;

    public UpdateStudentCommandHandler(ZaminServices zaminServices,
        IStudentCommandRepository studentCommandRepository) : base(zaminServices) 
        => _studentCommandRepository = studentCommandRepository;

    public override async Task<CommandResult> Handle(UpdateStudentCommand command)
    {
        Student student = await _studentCommandRepository.GetAsync(command.Id);

        if (student is null) throw new InvalidEntityStateException("دانش آموز یافت نشد.");

        student.Update(command.FirstName, command.LastName, command.NationalCode, command.ProfileImageSourceUrl);

        await _studentCommandRepository.CommitAsync();

        return Ok();
    }
}
