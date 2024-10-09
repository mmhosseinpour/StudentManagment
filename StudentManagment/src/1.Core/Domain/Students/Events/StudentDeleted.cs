using Zamin.Core.Domain.Events;
using Zamin.Core.Domain.Toolkits.ValueObjects;

namespace StudentManagment.Core.Domain.Students.Events;

public record StudentDeleted(Guid BussinessId,
    string NationalCode) : IDomainEvent;