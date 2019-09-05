
using System.ComponentModel.DataAnnotations.Schema;

namespace Hawk.Domain.Entities
{
    public class AvaliacaoEmpresa
    {
        public int Id { get; set; }
        public string Comentario { get; set; }
        [Column(TypeName ="decimal(2,1)")]
        public decimal Nota { get; set; }
        public bool RegistroAtivo { get; set; }

        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
    }
}
