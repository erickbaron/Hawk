using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hawk.Domain
{
    public class ProdutoFavorito
    {
        public int Id { get; set; }
        public bool RegistroAtivo { get; set; }

        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }

        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
    }
}
