using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Domain.Entities
{
    public class ImagemProduto : Produto
    {

        public string UrlImagem { get; set; }
        public string UrlImagemHash { get; set; }

        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
    }
}
