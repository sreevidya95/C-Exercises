using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LocalGym.Models
{
    /// <summary>
    /// returns session information
    /// </summary>
    public class ModelSession
    {
        
        public int SessionId { get; set; }
       
        public ModelTrainer? Trainer { get; set; }
        public int TrainerId { get; set; }
        
        public Modelsample? Member { get; set; }
        public int MemberId { get; set; }
       
        public DateTime HireDate { get; set; }
        
        public TimeOnly Duration { get; set; }
    }
}
