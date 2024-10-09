
using StudentManagment.Core.Contracts.Students.Queries;
using StudentManagment.Core.RequestResponse.Students.Queries.GetById;
using StudentManagment.Core.RequestResponse.Students.Queries.GetList;
using Zamin.Core.ApplicationServices.Queries;

using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;

namespace StudentManagment.Core.ApplicationService.Students.Queries.GetList;

public class GetStudentListQueryHandler : QueryHandler<GetStudentListQuery, GetStudentListResponseModel[]>
{
    private readonly IStudentQueryRepository _studentQueryRepository;
    public GetStudentListQueryHandler(ZaminServices zaminServices,
        IStudentQueryRepository studentQueryRepository) : base(zaminServices)
    {
        _studentQueryRepository = studentQueryRepository;
    }

    public override async Task<QueryResult<GetStudentListResponseModel[]>> Handle(GetStudentListQuery query)
    {
        var students = await _studentQueryRepository.ExecuteAsync(query);

        return Result(students);

    }
}
