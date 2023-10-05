using MediatR;
using User.Application.Model;

namespace User.Application.CQRS.Command.UsersCreate
{
    public class UsersCreateCommand : IRequest<string>
    {
        public UsersCreateModel UsersCreateModel { get; set; }
    }
}
