using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Shared.Entities;
using Teste.Domain.Entities.Enum;

namespace Teste.Domain.Entities
{
    public class Desenvolvedor : EntityBase
    {
        private Desenvolvedor()
        {
        }

        public Desenvolvedor(Nivel nivel, string nome, ESexo sexo, DateTime? dataNascimento, string hobby)
        {
            Nivel = nivel;
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Idade = new DateTime(DateTime.Now.Subtract(DataNascimento.Value).Ticks).Year - 1;
            Hobby = hobby;
        }

        public Nivel Nivel { get; private set; }
        public string Nome { get; private set; }
        public ESexo Sexo { get; private set; }
        public DateTime? DataNascimento { get; private set; }
        public int Idade { get; private set; }
        public string Hobby { get; private set; }

        public void Alterar(Nivel nivel, string nome, ESexo sexo, DateTime? dataNascimento, string hobby)
        {
            Nivel = nivel;
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Idade = new DateTime(DateTime.Now.Subtract(DataNascimento.Value).Ticks).Year - 1;
            Hobby = hobby;
        }

        public void AlterarNivel(Nivel nivel)
        {
            Nivel = nivel;
        }
    }
}
