using System;
using Teste.Domain.Entities.Enum;
using Teste.Shared.Interfaces;

namespace Teste.Domain.Commands.Desenvolvedor
{
    public class CriarDesenvolvedorCommand : ICommand
    {
        public Guid Nivel { get; set; }
        public string Nome { get; set; }
        public ESexo Sexo { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Hobby { get; set; }
    }
}
