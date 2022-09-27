using System;
using Teste.Shared.Interfaces;

namespace Teste.Domain.Commands.Nivel
{
    public class EditarNivelCommand : ICommand
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }    
    }
}
