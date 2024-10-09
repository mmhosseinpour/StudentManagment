
using StudentManagment.Core.Contracts.Students.Queries;
using StudentManagment.Core.RequestResponse.Students.Queries.GetById;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;

namespace StudentManagment.Core.ApplicationService.Students.Queries.GetById;

public class GetStudentByIdQueryHandler : QueryHandler<GetStudentByIdQuery, GetStudentByIdResponseModel>
{
    private readonly IStudentQueryRepository _studentQueryRepository;

    public GetStudentByIdQueryHandler(ZaminServices zaminServices,
        IStudentQueryRepository studentQueryRepository) : base(zaminServices)
    {
        _studentQueryRepository = studentQueryRepository;
    }

    public override async Task<QueryResult<GetStudentByIdResponseModel>> Handle(GetStudentByIdQuery query)
    {
        var student = await _studentQueryRepository.ExecuteAsync(query);

        return Result(student);

    }
}
