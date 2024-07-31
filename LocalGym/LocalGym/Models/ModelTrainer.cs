using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LocalGym.Models
{
    /// <summary>
    /// returns Trainer information
    /// </summary>
    public class ModelTrainer
    {


        public int TrainerId { get; set; }
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;
      
        public string speciality { get; set; } = string.Empty;

        public decimal FeePer30Minutes { get; set; } = 0.0M;
       
        public DateTime HireDate { get; set; } = DateTime.MinValue;
    }
}
