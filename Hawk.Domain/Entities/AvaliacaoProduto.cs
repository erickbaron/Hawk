

using System.ComponentModel.DataAnnotations.Schema;

namespace Hawk.Domain.Entities
{
    public class AvaliacaoProduto
    {
        public int Id { get; set; }
        public string Comentario { get; set; }
        [Column(TypeName = "decimal(2,1)")]
        public decimal Nota { get; set; }
        public bool RegistroAtivo { get; set; }

        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
    }
}
