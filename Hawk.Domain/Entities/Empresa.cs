

namespace Hawk.Domain.Entities
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Ramo{ get; set; }

        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public bool RegistroAtivo { get; set; }

        public Usuario user { get; set; }
        public int UsuarioId { get; set; }
    }
}
