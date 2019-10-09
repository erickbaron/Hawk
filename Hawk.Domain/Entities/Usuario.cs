using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Hawk.Domain.Entities
{
    public class Usuario : IdentityUser<int>
    {
        public List<UserRole> UserRoles { get; set; }

        [Column("nome")]
        public override string UserName { get => base.UserName; set => base.UserName = value; }

        [Column("senha")]
        public override string PasswordHash { get => base.PasswordHash; set => base.PasswordHash = value; }

        [Column("registro_ativo")]
        public bool RegistroAtivo { get; set; }
    }
}
