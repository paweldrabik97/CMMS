using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace CMMS_Shared.Data.Models
{
    public class ItemCycles
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Equipment Equipment { get; set;}

        public int Cycles { get; set;}

        public Equipment? WhereUsed { get; set;}

        public int MaxCycles { get; set;}  

    }
}
