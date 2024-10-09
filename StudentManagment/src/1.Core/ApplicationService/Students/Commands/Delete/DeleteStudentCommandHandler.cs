
using StudentManagment.Core.Contracts.Students.Commands;
using StudentManagment.Core.Domain.Students.Entities;
using StudentManagment.Core.RequestResponse.Students.Commands.Delete;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace StudentManagment.Core.ApplicationService.Students.Commands.Delete;

public class DeleteStudentCommandHandler : CommandHandler<DeleteStudentCommand>
{
    private IStudentCommandRepository _studentCommandRepository;

    public DeleteStudentCommandHandler(ZaminServices zaminServices,
        IStudentCommandRepository studentCommandRepository) : base(zaminServices) 
        => _studentCommandRepository = studentCommandRepository;

    public override async Task<CommandResult> Handle(DeleteStudentCommand command)
    {

        Student student = await _studentCommandRepository.GetAsync(command.Id);
        
        if (student is null) throw new InvalidEntityStateException("دانش آموز یافت نشد.");

        student.Delete();

        _studentCommandRepository.Delete(student);

        await _studentCommandRepository.CommitAsync();

        return Ok();
    }
}
