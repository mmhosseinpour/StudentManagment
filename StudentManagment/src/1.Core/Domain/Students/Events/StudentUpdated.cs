
using Zamin.Core.Domain.Events;
using Zamin.Core.Domain.Toolkits.ValueObjects;

namespace StudentManagment.Core.Domain.Students.Events;

public record StudentUpdated(Guid Bussiness,
    string FirstName,
    string LastName,
    string NationalCode,
    string ProfileImageSourceUrl) : IDomainEvent;
