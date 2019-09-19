

using System.ComponentModel.DataAnnotations.Schema;

namespace Hawk.Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal ValorCusto { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal ValorVenda { get; set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Comprimento { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Peso { get; set; }
        public bool Promocao { get; set; }
        public bool RegistroAtivo { get; set; }
        //Imagem
        public string ImagemURL { get; set; }

        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }

        public Categoria Categoria{ get; set; }
        public int CategoriaId { get; set; }
    }
}
