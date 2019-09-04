using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hawk.Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal ValorCusto { get; set; }
        public decimal ValorVenda { get; set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Comprimento { get; set; }
        public decimal Peso { get; set; }
        public bool Promocao { get; set; }
        public bool RegistroAtivo { get; set; }

        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }

        public Categoria Categoria{ get; set; }
        public int CategoriaId { get; set; }
    }
}
