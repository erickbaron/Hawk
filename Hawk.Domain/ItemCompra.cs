using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hawk.Domain
{
    public class ItemCompra
    {
        public int Id { get; set; }
        public decimal ValorItem { get; set; }
        public bool RegistroAtivo { get; set; }

        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }

        public Compra Compra {get; set; }
        public int CompraId {get; set; }
    }
}
