using CMMS_Shared.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CMMS_Shared.Services
{
    public class RegisterService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> SignInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SystemDbContext _context;



        public RegisterService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager, SystemDbContext context)
        {
            _userManager = userManager;
            SignInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
        }

        public async Task<IdentityResult> CreateAsync(IdentityUser user, string password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        public async Task<IdentityResult> CreateRoleAsync(IdentityRole role)
        {
            return await _roleManager.CreateAsync(role);
        }

        public async Task<IdentityResult> AddToRoleAsync(IdentityUser user, string role)
        {
            return await _userManager.AddToRoleAsync(user, role);
        }

        public async void SignInAsync(IdentityUser user, bool Persistent)
        {
            await SignInManager.SignInAsync(user, Persistent);
        }


        public async void SignOutAsync()
        {
            await SignInManager.SignOutAsync();
        }

        public async Task<List<IdentityUser>> GetUsers()
        {
            return await _userManager.Users.ToListAsync();
        }

        public async Task<IdentityUser> GetUserById(string id)
        {
            return await _userManager.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task DeleteUser(string id)
        {
            IdentityUser? user = _userManager.Users.FirstOrDefault(t => t.Id == id);

            if (user != null)
            {
               await _userManager.DeleteAsync(user);
               
            }
            else
            {
                throw new ArgumentNullException();
            }


        }

        public string? GetUserRolesById(string id)
        {
            

            IdentityUserRole<string>? userRole = _context.UserRoles.FirstOrDefault(x => x.UserId == id);
            IdentityRole? role = _context.Roles.FirstOrDefault(t => t.Id == userRole.RoleId);
            
            
            return role.Name;
            

        }
    }
}
