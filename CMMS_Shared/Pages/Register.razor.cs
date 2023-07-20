using CMMS_Shared.Data.Models;
using CMMS_Shared.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CMMS_Shared.Pages
{
    public partial class Register
    {

        //private readonly UserManager<IdentityUser> _userManager;
        //private readonly SignInManager<IdentityUser> _signInManager;

        [Inject]
        NavigationManager NavigationManager { get; set; }

        [Inject]
        protected RegisterService RegisterService { get; set; }

        public Registration Registration { get; set; }




        //public Register(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        //{
        //    this._userManager = userManager;
        //    this._signInManager = signInManager;
        //}

        protected override async Task OnInitializedAsync()
        {
            Registration = new Registration();
        }

        public async void SubmitRegister()
        {
            var user = new IdentityUser()
            {
                UserName = Registration.Email,
                Email = Registration.Email
            };

            var result = await RegisterService.CreateAsync(user, Registration.Password);

            var role = new IdentityRole(Registration.Role);
            var addRoleResult = await RegisterService.CreateRoleAsync(role);

            var addUserRoleResult = await RegisterService.AddToRoleAsync(user, Registration.Role);

            if (result.Succeeded && addRoleResult.Succeeded && addUserRoleResult.Succeeded )
            {
                //await RegisterService.SignInAsync(user, false);
                NavigationManager.NavigateTo("");
            }


        }
    }
}
