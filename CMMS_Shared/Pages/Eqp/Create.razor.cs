using CMMS_Shared.Data.Models;
using CMMS_Shared.Services;
using Microsoft.AspNetCore.Components;

namespace CMMS_Shared.Pages.Eqp
{
    public partial class Create
    {

        [Inject]
        protected IEquipmentService EquipmentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public Equipment Equipment { get; set; }

        protected override async Task OnInitializedAsync()
        {
           Equipment = new Equipment();
        }

        private async void SubmitEquipment()
        {
            await EquipmentService.CreateEquipment(Equipment);
            NavigationManager.NavigateTo("/eqp");
        }
    }
}
