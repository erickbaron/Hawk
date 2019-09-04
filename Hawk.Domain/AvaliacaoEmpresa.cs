using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hawk.Domain
{
    public class AvaliacaoEmpresa
    {
        public int Id { get; set; }
        public string Comentario { get; set; }
        public decimal Nota { get; set; }
        public bool RegistroAtivo { get; set; }

        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
    }
}
