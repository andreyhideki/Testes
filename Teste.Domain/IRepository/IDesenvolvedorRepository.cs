using System;
using System.Collections.Generic;
using Teste.Domain.Entities;

namespace Teste.Domain.IRepository
{
    public interface IDesenvolvedorRepository
    {
        void Salvar(Desenvolvedor desenvolvedor);
        void Atualizar(Desenvolvedor desenvolvedor);
        void Remover(Guid id);
        Desenvolvedor ObterPorId(Guid id);
        IEnumerable<Desenvolvedor> ObterTodos();
        IEnumerable<Desenvolvedor> ObterDesenvolvedoresComNivel(Guid nivel);
        bool ExisteDesenvolvedorComNivel(Guid nivel);
    }
}
