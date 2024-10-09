namespace StudentManagment.Core.RequestResponse.Students.Queries.GetById;

public class GetStudentByIdResponseModel
{
    public long Id { get; set; }
    public string  Firstname { get; set; }
    public string LastName { get; set; }
    public string NationalCode { get; set; }
    public string ProfileImageSourceUrl { get; set; }
}
