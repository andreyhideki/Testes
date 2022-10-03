using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Domain.Entities;

namespace Teste.Domain.Services
{
    public interface IConsultaTodoService
    {
        Todo RetornaTodo();
        IEnumerable<Todo> RetornaTodos();
    }
}
