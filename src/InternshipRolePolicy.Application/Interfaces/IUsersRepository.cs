using InternshipPractice.Domain.Entities;
using KDS.Primitives.FluentResult;

namespace InternshipRolePolicy.Application.Interfaces;

public interface IUsersRepository
{
    Task<Result<User>> GetUserByEmailAndPassword(string email, string password);
}
