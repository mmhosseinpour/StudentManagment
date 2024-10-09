using StudentManagment.Core.Domain.Students.Events;
using System.Reflection.Metadata;
using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.Toolkits.ValueObjects;

namespace StudentManagment.Core.Domain.Students.Entities;

public class Student : AggregateRoot<long>
{
    #region Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalCode { get; set; }
    public string ProfileImageSourceUrl { get; set; }
    #endregion

    #region Constructors
    public Student() { }

    public Student(string firstName, string lastName, string nationalCode, string profileImageSourceUrl)
    {
        FirstName = firstName;
        LastName = lastName;
        NationalCode = nationalCode;
        ProfileImageSourceUrl = profileImageSourceUrl;

        AddEvent(new StudentCreated(BusinessId.Value, FirstName, LastName, NationalCode, ProfileImageSourceUrl));
    }
    #endregion

    #region Commands
    public static Student Create(string firstName, string lastName, string nationalCode, string profileImageSourceUrl)
        => new(firstName, lastName, nationalCode, profileImageSourceUrl);

    public void Update(string firstName, string lastName, string nationalCode, string profileImageSourceUrl)
    {
        FirstName = firstName;
        LastName = lastName;
        NationalCode = nationalCode;
        ProfileImageSourceUrl = profileImageSourceUrl;

        AddEvent(new StudentUpdated(BusinessId.Value, FirstName, LastName, NationalCode, ProfileImageSourceUrl));
    }

    public void Delete()
        => AddEvent(new StudentDeleted(BusinessId.Value, NationalCode));
    #endregion

}
