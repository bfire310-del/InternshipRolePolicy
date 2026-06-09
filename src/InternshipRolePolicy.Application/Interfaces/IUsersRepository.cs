using InternshipPractice.Domain.Entities;
using InternshipRolePolicy.Application.Responses;
using KDS.Primitives.FluentResult;

namespace InternshipRolePolicy.Application.Interfaces;

public interface IUsersRepository
{
    Task<Result<List<UserResponse>>> GetAll();
    Task<Result<User>> GetUserByEmailAndPassword(string email, string password);
}
