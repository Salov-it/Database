using Database.Application.Interface;
using Database.Application.Model;
using MediatR;

namespace User.Application.CQRS.Query.GetUsersId
{
    public class GetUserIdHandler : IRequestHandler<GetUsersIdCommand, UsersTableModel>
    {
        private readonly IRepository _repository;
        public UsersTableModel Result = new UsersTableModel();
        public GetUserIdHandler(IRepository repository) 
        { 
            _repository = repository;
        }
        public async Task<UsersTableModel> Handle(GetUsersIdCommand request, CancellationToken cancellationToken)
        {
           Result = await _repository.GetById(request.usersId.id);
           return Result;
        }
    }
}
