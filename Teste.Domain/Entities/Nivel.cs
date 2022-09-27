﻿using Teste.Shared.Entities;

namespace Teste.Domain.Entities
{
    public class Nivel : EntityBase
    {
        private Nivel()
        {
        }

        public Nivel(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }

        public void Alterar(string nome)
        {
            Nome = nome;
        }
    }
}
