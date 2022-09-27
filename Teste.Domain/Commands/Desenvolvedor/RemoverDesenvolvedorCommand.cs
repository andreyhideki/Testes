using System;
using Teste.Shared.Interfaces;

namespace Teste.Domain.Commands.Desenvolvedor
{
    public class RemoverDesenvolvedorCommand : ICommand
    {
        public Guid Id { get; set; }
    }
}
