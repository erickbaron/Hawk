

namespace Hawk.Domain.Entities
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Ramo{ get; set; }
        public bool RegistroAtivo { get; set; }

        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}
