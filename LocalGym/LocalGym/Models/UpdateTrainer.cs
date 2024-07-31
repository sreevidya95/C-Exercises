namespace LocalGym.Models
{
    /// <summary>
    /// Returns the Info of the trainers
    /// </summary>
    public class UpdateTrainer
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string speciality { get; set; } = string.Empty;

        public decimal FeePer30Minutes { get; set; } = 0.0M;

        public DateTime HireDate { get; set; } = DateTime.MinValue;
    }
}
