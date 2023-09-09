using Microsoft.AspNetCore.Identity;

namespace PokemonReviewApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string firstname { get; set; } = null!;
        public string lastname { get; set; } = null!;
    }

}
