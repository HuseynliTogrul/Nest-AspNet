using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nest_AspNet.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        [NotMapped]
        public string FullName { get => $"{Name} {Surname}"; }
    }
}
