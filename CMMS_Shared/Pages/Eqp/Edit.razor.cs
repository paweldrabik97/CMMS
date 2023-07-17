using CMMS_Shared.Data.Models;
using CMMS_Shared.Services;
using Microsoft.AspNetCore.Components;

namespace CMMS_Shared.Pages.Eqp
{
    public partial class Edit
    {
        [Inject]
        protected IEquipmentService EquipmentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int Id { get; set; }

        public Equipment equipment { get; set; }

        protected override async Task OnInitializedAsync()
        {
            equipment = await EquipmentService.GetEquipmentById(Id);
        }

        private async void SubmitEquipment()
        {
            await EquipmentService.UpdateEquipment(equipment);

            NavigationManager.NavigateTo("/eqp");
        }
    }
}
