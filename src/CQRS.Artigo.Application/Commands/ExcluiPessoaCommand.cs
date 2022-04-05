using MediatR;

namespace CQRS.Artigo.Application.Commands
{
    public class ExcluiPessoaCommand : IRequest<string>
    {
        public int Id { get; set; }
    }
}
