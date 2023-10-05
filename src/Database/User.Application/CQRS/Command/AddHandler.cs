using Database.Application.Interface;
using MediatR;

namespace User.Application.CQRS.Command
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
            _repository.UserAdd(request.JsonContent.Login,request.JsonContent.Password,request.JsonContent.AccessToken);
            return "Выполнено";
        }
    }
}
