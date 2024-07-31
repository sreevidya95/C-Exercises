using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalGym.Models
{
    /// <summary>
    /// returns info of the trainer
    /// </summary>
    public class Trainer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TrainerId { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;

        public string lastName { get; set; } = string.Empty;
        [Required]
        public string speciality { get; set; } = string.Empty;
        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal FeePer30Minutes { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
    }
}
