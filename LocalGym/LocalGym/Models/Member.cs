using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalGym.Models
{
    /// <summary>
    /// contains the details of memebers that took memebership in gym
    /// </summary>
    public class Member
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberId { get; set; }
        [Required]
        public string First_name { get; set; } = string.Empty;
       
        public string last_name { get; set; }=string.Empty;
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set;} = string.Empty;
        [Required]
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }
    }
}
