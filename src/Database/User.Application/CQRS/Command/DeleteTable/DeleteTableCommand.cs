using MediatR;

namespace User.Application.CQRS.Command.DeleteTable
{
    public class DeleteTableCommand : IRequest<string>
    {
    }
}
