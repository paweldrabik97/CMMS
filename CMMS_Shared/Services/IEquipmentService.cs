using CMMS_Shared.Data.Models;

namespace CMMS_Shared.Services
{
    public interface IEquipmentService
    {
        Task<List<Equipment>> GetEquipmentList();
        Task<Equipment> GetEquipmentById(int id);
        Task<Equipment> CreateEquipment(Equipment equipment);
        Task UpdateEquipment(Equipment equipment);
        Task DeleteEquipment(int id);
    }
}
