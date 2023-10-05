using MediatR;
using User.Application.Model;

namespace User.Application.CQRS.Command.Add
{
    public class AddCommand : IRequest<string>
    {
        public AddModel AddModel { get; set; }
    }


}
