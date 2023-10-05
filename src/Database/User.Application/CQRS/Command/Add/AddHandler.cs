using Database.Application.Interface;
using MediatR;

namespace User.Application.CQRS.Command.Add
{
    public class AddHandler : IRequestHandler<AddCommand, string>
    {
        public readonly IRepository _repository;

        public AddHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> Handle(AddCommand request, CancellationToken cancellationToken)
        {
            _repository.UserAdd(request.AddModel.Login, request.AddModel.Password, request.AddModel.AccessToken);
            return "Выполнено";
        }
    }
}
