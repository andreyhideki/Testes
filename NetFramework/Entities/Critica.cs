using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework
{
    public class Critica
    {
        public string Nome { get; set; }
        public string Cor { get; set; }

        public Critica(string nome, string cor)
        {
            Nome = nome;
            Cor = cor;
        }
    }
}
