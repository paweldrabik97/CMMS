using CMMS_Shared.Data;
using CMMS_Shared.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CMMS_Shared.Services
{
    public class EquipmentService : IEquipmentService
    {
        
        private readonly SystemDbContext _context;

        public EquipmentService(SystemDbContext context)
        {
            _context = context;
        }
        
        public async Task<Equipment> CreateEquipment(Equipment equipment)
        {
            _context.Equipments.Add(equipment);
            await _context.SaveChangesAsync();
            return equipment;
        }

        public async Task DeleteEquipment(int id)
        {
            Equipment? equipment = _context.Equipments.FirstOrDefault(x => x.Id == id);
            if (equipment != null) 
            {
                _context.Equipments.Remove(equipment);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public async Task<Equipment> GetEquipmentById(int id)
        {
            return await _context.Equipments.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Equipment>> GetEquipmentList()
        {
            return await _context.Equipments.ToListAsync();
        }

        public async Task UpdateEquipment(Equipment equipment)
        {
            _context.Equipments.Update(equipment);
            await _context.SaveChangesAsync();
        }
    }
}
