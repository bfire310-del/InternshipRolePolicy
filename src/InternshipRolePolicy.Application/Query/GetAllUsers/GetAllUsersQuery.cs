using InternshipRolePolicy.Application.Responses;
using KDS.Primitives.FluentResult;
using MediatR;

namespace InternshipRolePolicy.Application.Query.GetAllUsers;

public record GetAllUsersQuery() : IRequest<Result<List<UserResponse>>>;
