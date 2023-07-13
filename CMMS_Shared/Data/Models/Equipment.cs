using System.ComponentModel.DataAnnotations;

namespace CMMS_Shared.Data.Models
{
    public class Equipment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? EquipmentCode { get; set; }

        public string? SerialNo { get; set; }

        public Equipment? WhereUsed { get; set; }

        public string? ProductModel { get; set; }

    }
}
