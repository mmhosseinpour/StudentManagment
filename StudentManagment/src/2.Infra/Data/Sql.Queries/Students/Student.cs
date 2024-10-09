
using Zamin.Core.Domain.Toolkits.ValueObjects;

namespace StudentManagment.Infra.Data.Sql.Queries.Students;

public partial class Student
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalCode { get; set; }
    public string ProfileImageSourceUrl { get; set; }

}
