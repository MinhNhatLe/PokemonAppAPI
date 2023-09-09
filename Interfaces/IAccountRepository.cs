using Microsoft.AspNetCore.Identity;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> SignUpAsync(SignUpModel model);
        public Task<string> SignInAsync(SignInModel model);
    }
}
