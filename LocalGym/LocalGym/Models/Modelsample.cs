using System.ComponentModel.DataAnnotations;

namespace LocalGym.Models
{
    /// <summary>
    /// returns Members information
    /// </summary>
    public class Modelsample
    {
        public int MemberId { get; set; }
       
        public string First_name { get; set; } = string.Empty;

        public string last_name { get; set; } = string.Empty;
       
        public string email { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }
    }
}
