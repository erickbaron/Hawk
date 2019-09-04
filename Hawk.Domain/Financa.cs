using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hawk.Domain
{
    public class Financa
    {
        public int Id { get; set; }
        public decimal ValorCusto { get; set; }
        public decimal ValorVenda { get; set; }
        public decimal Lucro { get; set; }
        public bool RegistroAtivo { get; set; }

        public Compra Compra { get; set; }
        public int CompraId { get; set; }

        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
    }
}
