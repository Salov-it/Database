using Database.Application.Interface;
using MediatR;

namespace User.Application.CQRS.Command.UsersCreate
{
    public class UsersCreateHandler : IRequestHandler<UsersCreateCommand, string>
    {
        private readonly IRepository _repository;
        public UsersCreateHandler(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<string> Handle(UsersCreateCommand request, CancellationToken cancellationToken)
        {
            _repository.UserCreateTable();
            return "Выполнено";
        }
    }
}
