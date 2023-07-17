using CMMS_Shared.Services;
using Microsoft.AspNetCore.Components;
using CMMS_Shared.Data.Models;


namespace CMMS_Shared.Pages.Eqp
{
    public partial class Index
    {
        [Inject]
        protected IEquipmentService EquipmentService { get; set; }

        private List<Equipment> Equipments { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Equipments = await EquipmentService.GetEquipmentList();
        }

        public async Task DeleteEquipment(int equipmentId)
        {
            var equipment = await EquipmentService.GetEquipmentById(equipmentId);
            if (equipment != null)
            {
                await EquipmentService.DeleteEquipment(equipmentId);

                Equipments.RemoveAll(x => x.Id == equipmentId);
            }
        }



    }
}
