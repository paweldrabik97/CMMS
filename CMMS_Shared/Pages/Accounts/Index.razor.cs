using CMMS_Shared.Data.Models;
using CMMS_Shared.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;

namespace CMMS_Shared.Pages.Accounts
{
    public partial class Index
    {

        [Inject]
        protected RegisterService RegisterService { get; set; }

        private List<IdentityUser> Users { get; set; }
        

        protected override async Task OnInitializedAsync()
        {
            Users = await RegisterService.GetUsers();
            
        }

        public async Task DeleteAccount(string userId)
        {
            var equipment = await RegisterService.GetUserById(userId);
            if (equipment != null)
            {
                await RegisterService.DeleteUser(userId);

                Users.RemoveAll(x => x.Id == userId);
            }
        }
    }
}
