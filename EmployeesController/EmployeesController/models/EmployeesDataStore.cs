using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace EmployeesController.models
   
{
    public class EmployeesDataStore
    {

        public List<Employee> employee{get;set;}
        
        const string ConnectString = "Server=WSAMZN-GDQ29NA1;Initial Catalog=employeesDatabase;User Id=sa;Password=Password@123;";
        SqlConnection con = new SqlConnection(ConnectString);
       
       public List<Employee> GetEmployees()
        {
            try
            {

                SqlCommand command = new SqlCommand("Select * from Employee", con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
             
                while (reader.Read())
                {
                    employee = new List<Employee>();
                    employee.Add(new Employee()
                    {
                        Id = int.Parse(reader["ID"].ToString()),
                        Name = reader["Name"].ToString(),
                        JobTitle = reader["JobTitle"].ToString(),
                        salary = decimal.Parse(reader["Salary"].ToString())
                    });

                  

                }
               

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            con.Close();
            return employee;
        }
        public List<Employee> GetEmployee(int id) {
            try
            {

                SqlCommand command = new SqlCommand("Select * from employee where id = @id", con);
                con.Open();
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();
                employee = new List<Employee>();
                while (reader.Read())
                {
                    employee.Add(new Employee()
                    {
                        Id = int.Parse(reader["ID"].ToString()),
                        Name = reader["Name"].ToString(),
                        JobTitle = reader["JobTitle"].ToString(),
                        salary = decimal.Parse(reader["Salary"].ToString())
                    });
                }
               
            }catch(Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
            con.Close();
            return employee;
        }
        public IResult DeleteEmployee(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Delete from employee where id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                con.Close();
                return Results.Ok("deleted Successfully");

            }
            catch (Exception ex) {
                con.Close();
               return Results.BadRequest(ex.Message);
            }
        }
        public IResult InsertEmployee(string name, string job, decimal salary) {

            try
            {
                int rows = 0;
                SqlCommand com = new SqlCommand("Insert into employee " +
               "(name,Jobtitle,salary) values(@name,@job,@salary)", con);
                con.Open();
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@job", job);
                com.Parameters.AddWithValue("@salary", salary);
                rows = com.ExecuteNonQuery();
                if (rows > 0)
                {
                    return Results.Created();
                }
                else
                {
                    return Results.NotFound("Couldnt Insert");
                }
                con.Close();
            }
            catch (Exception ex) {

                con.Close();
                return Results.BadRequest(ex.Message);
            }

        }

        /*public EmployeesDataStore() => employee =
            [
               new Employee()
                   {
                   Name = "sree",
                   Id=1,
                   JobTitle="SWE",
                   salary=3500.00M

               },
               new Employee()
                   {
                   Name = "vidya",
                   Id=2,
                   JobTitle="SWE",
                   salary=2500.00M

               },
            new Employee()
                   {
                   Name = "sara",
                   Id=3,
                   JobTitle="teacher",
                   salary=2500.00M

               },
            new Employee()
                   {
                   Name = "david",
                   Id=4,
                   JobTitle="teacher",
                   salary=2500.00M

               },

            ];*/






    }
}
