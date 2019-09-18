using System.ComponentModel.DataAnnotations.Schema;

namespace Hawk.Domain.Entities
{
    public class Financa
    {
        public int Id { get; set; }
        public string Mes { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal ValorCusto { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal ValorVenda { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Lucro { get; set; }
        public bool RegistroAtivo { get; set; }

        public Compra Compra { get; set; }
        public int CompraId { get; set; }

        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
    }
}
