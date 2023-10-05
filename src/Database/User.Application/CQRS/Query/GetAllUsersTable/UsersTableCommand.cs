using Database.Application.Model;
using MediatR;

namespace User.Application.CQRS.Query.GetAllUsersTable
{
    public class UsersTableCommand : IRequest<List<UsersTableModel>>
    {
    }
}
