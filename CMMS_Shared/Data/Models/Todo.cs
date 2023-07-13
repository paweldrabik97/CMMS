using System.ComponentModel.DataAnnotations;

namespace CMMS_Shared.Data.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Assignment { get; set; } = string.Empty;

        public string? Pic { get; set; }

        [Required]
        public string OrderingUser { get; set; } = string.Empty;

        [DataType(DataType.Date)] 
        public DateTime CreateDate { get; set;}

        [DataType(DataType.Date)]
        public DateTime? UntilDate { get; set;}

        [DataType(DataType.Date)]
        public DateTime? FinishDate { get;set;}

        public string? Status { get; set; }

        public Equipment? Eqp { get; set; }



    }
}
