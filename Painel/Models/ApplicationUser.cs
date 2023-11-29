using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Painel.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            AdminLojas = false;
        }
        public bool AdminLojas { get; set; }

    }
}
