using EmployeesController.models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Linq;
namespace EmployeesController.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        EmployeesDataStore store = new EmployeesDataStore();
        [HttpGet]
        public List<Employee> GetEmployees()
        {

            return store.GetEmployees();
        }
        [HttpGet("/{id}")]
        public List<Employee> getEmployeeById(int id)
        {
            /*return (from p in store.employee
                    where p.Id == id
                     select p).ToList();*/
            return store.GetEmployee(id);
        }
        [HttpDelete("/{id}")]
        public IResult DeleteEmployees(int id) {
            return store.DeleteEmployee(id);
        }
        [HttpPost]
        public IResult CreateEmployee()
        {
            Employee e = new Employee();

            e.Name = "Sarah";
            e.JobTitle = "SWE";
            e.salary = 35000.00M;
            return store.InsertEmployee(e.Name, e.JobTitle, e.salary);


        }

    }
}
