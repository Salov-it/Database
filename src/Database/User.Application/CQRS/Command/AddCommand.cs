using MediatR;

namespace User.Application.CQRS.Command
{
    public class AddCommand : IRequest<string>
    {
        public JsonContentModel JsonContent { get; set; }
    }

   
}
