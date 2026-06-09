using InternshipRolePolicy.Application.Interfaces;
using InternshipRolePolicy.Application.Responses;
using KDS.Primitives.FluentResult;
using MediatR;

namespace InternshipRolePolicy.Application.Query.GetAllUsers;

public class GetAllUsersQueryHandler(IUsersRepository usersRepository) : IRequestHandler<GetAllUsersQuery, Result<List<UserResponse>>>
{
    public async Task<Result<List<UserResponse>>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        var result = await usersRepository.GetAll();
        return result;
    }
}
