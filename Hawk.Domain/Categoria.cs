using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hawk.Domain
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool RegistroAtivo { get; set; }
    }
}
