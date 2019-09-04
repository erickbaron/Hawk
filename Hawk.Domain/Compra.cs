using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hawk.Domain
{
    public class Compra
    {
        public int Id { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal Desconto { get; set; }
        public bool RegistroAtivo { get; set; }
        
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
    }
}
