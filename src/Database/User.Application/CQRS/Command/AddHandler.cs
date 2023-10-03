using MediatR;

namespace User.Application.CQRS.Command
{
    public class AddHandler : IRequestHandler<AddCommand, string>
    {
        public Task<string> Handle(AddCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
