using System;
using System.Collections.Generic;
using Teste.Domain.Entities;

namespace Teste.Domain.Repositories
{
    public interface INivelRepository
    {
        void Salvar(Nivel nivel);
        void Atualizar(Nivel nivel);
        void Remover(Guid id);
        Nivel ObterPorId(Guid id);
        IEnumerable<Nivel> ObterTodos();
        

    }
}
