using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Domain.Entities
{
    public class imagemViewModel
    {
        public int ProdutoID { get; set; }

        public IFormFile Imagem { get; set; }
    }
}
