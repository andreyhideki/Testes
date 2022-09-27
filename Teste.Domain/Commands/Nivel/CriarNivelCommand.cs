using Teste.Shared.Interfaces;

namespace Teste.Domain.Commands.Nivel
{
    public class CriarNivelCommand : ICommand
    {
        public string Nome { get; set; }
    }
}
