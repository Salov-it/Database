using Database.Application.Interface;
using MediatR;

namespace User.Application.CQRS.Command.DeleteTable
{
    public class DeleteTableHandler : IRequestHandler<DeleteTableCommand, string>
    {
        private readonly IRepository _repository;
        public DeleteTableHandler(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<string> Handle(DeleteTableCommand request, CancellationToken cancellationToken)
        {
            _repository.Delete();
            return "Выполнено";
        }
    }
}
