using System;


namespace Hawk.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public bool RegistroAtivo { get; set; }

        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}
