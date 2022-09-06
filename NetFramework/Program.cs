using NetFramework.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List
            List<Critica> ListaCriticas = new List<Critica>();
            ListaCriticas.Add(new Critica("Nao Encontrado", "#0000"));
            ListaCriticas.Add(new Critica("Encontrado", "#1111"));
            ListaCriticas.Add(new Critica("Bloqueado", "#2222"));

            foreach (var item in ListaCriticas)
            {
                Console.WriteLine(item.Cor);
                Console.WriteLine(item.Nome);
            }
            #endregion

            Console.WriteLine();

            #region Collection
            Collection<Critica> CollectionCriticas = new Collection<Critica>();
            CollectionCriticas.Add(new Critica("Nao Encontrado", "#0000"));
            CollectionCriticas.Add(new Critica("Encontrado", "#1111"));
            CollectionCriticas.Add(new Critica("Bloqueado", "#2222"));
            foreach (var item in CollectionCriticas)
            {
                Console.WriteLine(item.Cor + " - " + item.Nome);
            }
            #endregion

            Console.WriteLine();

            #region dictionary
            Dictionary<string, string> dicionario = new Dictionary<string, string>();
            dicionario.Add("Nao Encontrado", "#0000");
            dicionario.Add("Encontrado", "#1111");
            dicionario.Add("Bloqueado", "#2222");
            Console.WriteLine(dicionario["Encontrado"]);

            foreach (var item in dicionario)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }

            Console.WriteLine("Dicionario: " + dicionario.FirstOrDefault(d => d.Key == "Bloqueado"));

            if (dicionario.ContainsKey("Bloqueado"))
            {
                Console.WriteLine("{0} chave existe", "Bloqueado");
            }

            #endregion

            Console.WriteLine();

            #region dictionaryObjeto
            Critica NaoEncontrado = new Critica("Nao Encontrado", "#0000");
            Critica Encontrado = new Critica("Encontrado", "#1111");
            Critica Bloqueado = new Critica("Bloqueado", "#2222");

            Dictionary<string, Critica> dicionarioObj = new Dictionary<string, Critica>()
            {
                {"NE", NaoEncontrado},
                {"EN", Encontrado },
                {"BLOQUEADO", Bloqueado },
            };

            foreach (var item in dicionarioObj)
            {
                Console.WriteLine(item.Key + " - " + item.Value.Nome + " - " + item.Value.Cor);
            }

            var selecionadoKey = dicionarioObj.Where(d => d.Key == "NE").FirstOrDefault();

            Console.WriteLine("SELECIONADO Key: " + selecionadoKey.Key + " - " + selecionadoKey.Value.Nome + " - " + selecionadoKey.Value.Cor);

            var selecionadoNome = dicionarioObj.Where(d => d.Value.Nome == "Encontrado").FirstOrDefault();

            Console.WriteLine("SELECIONADO Nome: " + selecionadoNome.Key + " - " + selecionadoNome.Value.Nome + " - " + selecionadoNome.Value.Cor);

            #endregion

            Console.WriteLine();

            #region enum
            foreach (var item in Enum.GetValues(typeof(ECriticas)))
            {
                Console.WriteLine(item);
            }

            foreach (var item in Enum.GetNames(typeof(ECriticas)))
            {
                Console.WriteLine(item);
            }

            Enum ct = ECriticas.NaoEncontrado;
            Console.WriteLine("AE: " + ct);
            #endregion

            Console.WriteLine();
        }
    }
}
