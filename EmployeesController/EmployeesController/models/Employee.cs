namespace EmployeesController.models
{
    public class Employee
    {
      
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? JobTitle { get; set; } = null;
        public decimal salary { get; set; } = 0;
  
    }
}
