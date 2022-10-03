using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Domain.Entities;
using Teste.Domain.Services;

namespace Teste.Infra.Services
{
    public class ConsultaTodoService : IConsultaTodoService
    {
        public Todo RetornaTodo()
        {
            string urlConsulta = "https://jsonplaceholder.typicode.com/todos/1";
            HttpClient httpClient = new HttpClient();
            
            var resultado = httpClient.GetAsync(urlConsulta).Result;

            if (resultado.IsSuccessStatusCode)
            {
                var todo = JsonConvert.DeserializeObject<Todo>(resultado.Content.ReadAsStringAsync().Result);

                return todo;
            }

            throw new Exception();
        }

        public IEnumerable<Todo> RetornaTodos()
        {
            string urlConsulta = "https://jsonplaceholder.typicode.com/todos";

            HttpClient httpClient = new HttpClient();

            var resultado = httpClient.GetAsync(urlConsulta).Result;

            if (resultado.IsSuccessStatusCode)
            {
                var todos = JsonConvert.DeserializeObject<IEnumerable<Todo>>(resultado.Content.ReadAsStringAsync().Result);

                return todos;
            }

            throw new Exception();
        }
    }
}
