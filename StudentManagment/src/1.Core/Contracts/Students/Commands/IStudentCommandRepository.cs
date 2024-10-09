
using StudentManagment.Core.Domain.Students.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace StudentManagment.Core.Contracts.Students.Commands;

public interface IStudentCommandRepository : ICommandRepository<Student, long> { }
