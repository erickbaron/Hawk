using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Domain.Entities
{
    public class Carrinho
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public bool RegistroAtivo { get; set; }
        
        public ItemCompra ItemCompra { get; set; }
        public int ItemCompraId { get; set; }
    }
}
