using KDS.Primitives.FluentResult;

namespace InternshipRolePolicy.Application.Interfaces;

public interface IJwtService
{
    Task<Result<string>> GenerateToken(Guid userId, string roleCode);
    Task<Result<(Guid, string)>> ValidateToken(string token);
}
