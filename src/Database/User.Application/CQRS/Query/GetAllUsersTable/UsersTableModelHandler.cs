using Database.Application.Interface;
using Database.Application.Model;
using MediatR;

namespace User.Application.CQRS.Query.GetAllUsersTable
{
    public class UsersTableModelHandler : IRequestHandler<UsersTableCommand,List<UsersTableModel>>
    {
        private readonly IRepository _repository;
        public List<UsersTableModel> Result = new List<UsersTableModel>();
        public UsersTableModelHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<UsersTableModel>> Handle(UsersTableCommand request, CancellationToken cancellationToken)
        {
            var Content = await _repository.GetAll();
            return Content;
        }
    }
}
