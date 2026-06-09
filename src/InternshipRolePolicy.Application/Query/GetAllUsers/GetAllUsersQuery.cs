namespace InternshipRolePolicy.Application.Query.GetAllUsers;

public record GetAllUsersQuery() : IRequest<Result<List<UserResponse>>>;
