

namespace Hawk.Domain.Entities
{
    public class EnderecoEmpresa
    {
        public int Id { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public bool RegistroAtivo { get; set; }

        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
    }
}
