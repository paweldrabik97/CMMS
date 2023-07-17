using CMMS_Shared.Data.Models;
using CMMS_Shared.Services;
using Microsoft.AspNetCore.Components;

namespace CMMS_Shared.Pages.Eqp
{
    public partial class Details
    {
        [Inject]
        protected IEquipmentService EquipmentService { get; set; }

        [Parameter]
        public int Id { get; set; }

        public Equipment Equipment { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Equipment = await EquipmentService.GetEquipmentById(Id);
        }
    }
}
