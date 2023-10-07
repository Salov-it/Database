using Database.Application.Model;
using MediatR;
using User.Application.Model;

namespace User.Application.CQRS.Query.GetUsersId
{
    public class GetUsersIdCommand : IRequest<UsersTableModel>
    {
        public UsersId usersId { get; set; }
    }
}
