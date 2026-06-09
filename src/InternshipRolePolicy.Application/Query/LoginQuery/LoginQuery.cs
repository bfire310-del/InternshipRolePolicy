using KDS.Primitives.FluentResult;
using MediatR;

namespace InternshipRolePolicy.Application.Query.LoginQuery;

public record LoginQuery(string Email, string Password) : IRequest<Result<(string, string, string, string)>>;
