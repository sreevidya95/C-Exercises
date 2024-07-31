using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalGym.Models
{
    /// <summary>
    /// returns session information
    /// </summary>
    public class Session
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SessionId { get; set; }
        [Required]
        [ForeignKey("TrainerId")]
        public Trainer? Trainer { get; set; }
        public int TrainerId { get; set; }
        [Required]
        [ForeignKey("MemberId")]
        public Member? Member { get; set; }
        public int MemberId { get; set; }
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        [DataType(DataType.Duration)]
        public TimeOnly Duration { get; set; }
       

    }
}
