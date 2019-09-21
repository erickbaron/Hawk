using Microsoft.AspNetCore.Identity;

namespace Hawk.Domain.Entities

{
    public class UserRole : IdentityUserRole<int>
    {
        public Usuario User { get; set; }
        public Role Role { get; set; }
    }
}