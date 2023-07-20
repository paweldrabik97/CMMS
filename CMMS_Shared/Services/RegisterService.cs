using Microsoft.AspNetCore.Identity;

namespace CMMS_Shared.Services
{
    public class RegisterService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> SignInManager;

        public RegisterService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            SignInManager = signInManager;
        }

        public async Task<IdentityResult> CreateAsync(IdentityUser user, string password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        public async void SignInAsync(IdentityUser user, bool Persistent)
        {
            await SignInManager.SignInAsync(user, Persistent);
        }


        public async void SignOutAsync()
        {
            await SignInManager.SignOutAsync();
        }
    }
}
