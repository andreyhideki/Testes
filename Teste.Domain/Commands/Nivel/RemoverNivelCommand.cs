using System;
using Teste.Shared.Interfaces;

namespace Teste.Domain.Commands.Nivel
{
    public class RemoverNivelCommand : ICommand
    {
        public Guid Id { get; set; }
    }
}
