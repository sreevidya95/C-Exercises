using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        const string connstring = "Server=WSAMZN-GDQ29NA1;User Id=sa;Password=Password@123;";
        SqlConnection con = new SqlConnection(connstring);
        try
        {
            con.Open();
            SqlCommand command = new SqlCommand("IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'dealership')" +
                " BEGIN EXEC('CREATE DATABASE dealership') END", con);

            SqlDataReader sdr = command.ExecuteReader();
            sdr.Close();
            command = new SqlCommand("use dealership", con);

            SqlDataReader sdr1 = command.ExecuteReader();
            sdr1.Close();
            command = new SqlCommand("IF NOT Exists (select * from sys.tables where name='cars')" +
                                       "BEGIN CREATE TABLE Cars (ID int NOT NULL IDENTITY(1,1) PRIMARY KEY," +
                                       "Inventory_number int NOT NULL, Vehicle_identification_number varchar(255),make varchar(25)," +
                                       "mode varchar(25),year int,odometer_reading int,color varchar(25),price decimal(5,2)," +
                                       "status varchar(25)) END", con);
            SqlDataReader sdr2 = command.ExecuteReader();
            sdr2.Close();
            command = new SqlCommand("IF NOT Exists (select * from sys.tables where name='sales')" +
                                       "BEGIN CREATE TABLE sales (ID int NOT NULL IDENTITY(1,1) PRIMARY KEY," +
                                       "Inventory_number int NOT NULL,sales_date Date," +
                                       "customer_name varchar(25),customer_phone varchar(25),payment_method varchar(25),payment_amount decimal(5,2)," +
                                       "status varchar(25)) END", con);
            SqlDataReader sdr3 = command.ExecuteReader();
            sdr3.Close();
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("------");
                Console.WriteLine("1 - List all available cars\r\n2 - List available cars with less than a specific odometer reading\r\n3 - List available cars with a specific make and model\r\n4 - List available cars between a specific price range\r\n5 - Sell a car\r\n6 - Change a car’s price\r\n7 - Delete a car from inventory\r\n8 - Quit\r\n");
                Console.WriteLine("enter your choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            command = new SqlCommand("Select * from cars", con);
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                Console.WriteLine(reader["inventory_number"] + "  " + reader["Vehicle_identification_number"] + " " + reader["make"]+"  " + reader["mode"]);
                            }
                            reader.Close();
                            break;
                        }
                    case 2:
                        {

                            Console.WriteLine("Enter the odo reading to get the car details of the specific odometer readings");
                            int reading = int.Parse(Console.ReadLine());
                            command = new SqlCommand("Select * from cars where odometer_reading = @odo", con);
                            command.Parameters.AddWithValue("@odo", reading);
                            SqlDataReader reader = command.ExecuteReader() ;
                            while (reader.Read())
                            {
                                Console.WriteLine(reader["inventory_number"] + "  " + reader["Vehicle_identification_number"] + " " + reader["make"] + "  " + reader["mode"]);
                            }
                            reader.Close();
                            break;
                        }
                    case 3:
                        {

                            Console.WriteLine("Enter make of the car");
                            string make = Console.ReadLine();
                            Console.WriteLine("Enter model of the car");
                            string mode = Console.ReadLine();
                            command = new SqlCommand("Select * from cars where make = @make AND mode = @mode", con);
                            command.Parameters.AddWithValue("@make",make);
                            command.Parameters.AddWithValue("@mode", mode);
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                Console.WriteLine(reader["inventory_number"] + "  " + reader["Vehicle_identification_number"] + " " + reader["make"] + "  " + reader["mode"]);
                            }
                            reader.Close();
                            break;
                        }
                    case 4:
                        {

                            Console.WriteLine("Enter minimum range of price");
                            int min = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter maximum range of price");
                            int max = int.Parse(Console.ReadLine());
                            command = new SqlCommand("Select * from cars where price between @min AND @max", con);
                            command.Parameters.AddWithValue("@min", min);
                            command.Parameters.AddWithValue("@max", max);
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                Console.WriteLine(reader["inventory_number"] + "  " + reader["Vehicle_identification_number"] + " " + reader["make"] + "  " + reader["mode"]);
                            }
                            reader.Close();
                            break;
                        }
                    case 5:
                        {

                            Console.WriteLine("Enter the inventory of the car");
                            int inventory = int.Parse(Console.ReadLine());
                            Console.WriteLine("enter customer name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Customer mobile");
                            long phone = long.Parse(Console.ReadLine());
                            Console.WriteLine("Enter payment method");
                            string method = Console.ReadLine();
                            Console.WriteLine("Enter payment amount");
                            float amount = float.Parse(Console.ReadLine());
                            Console.WriteLine("enter status (completed,pending)");
                            string status = Console.ReadLine();
                            string date = DateTime.Now.ToString();
                            command = new SqlCommand("INSERT INTO sales (Inventory_number, sales_date, customer_name," +
                                " customer_phone, payment_method, payment_amount, status)" +
                                "VALUES (@inventory,@date,@name,@phone,@method,@amount,@status)", con);
                            command.Parameters.AddWithValue("@inventory",inventory);
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@date", date);
                            command.Parameters.AddWithValue("@phone", phone);
                            command.Parameters.AddWithValue("@method", method);
                            command.Parameters.AddWithValue("@amount", amount);
                            command.Parameters.AddWithValue("@status", status);
                            command.ExecuteNonQuery();
                            Console.WriteLine("Added");
                           
                            break;
                        }
                    case 6:
                        {

                            Console.WriteLine("Enter the id of car you want to update the price");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the new price");
                            float price = float.Parse(Console.ReadLine());
                            command = new SqlCommand("update cars set price = @price where id = @id", con);
                            command.Parameters.AddWithValue("@id", id);
                            command.Parameters.AddWithValue("@price", price);
                            command.ExecuteNonQuery();
                            Console.WriteLine("updated");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Enter the id of car you want to update the price");
                            int id = int.Parse(Console.ReadLine());
                            command = new SqlCommand("delete from cars where id = @id", con);
                            command.Parameters.AddWithValue("@id", id);
                            command.ExecuteNonQuery();
                            Console.WriteLine("Deleted");
                            break;
                        }
                    case 8:
                        {
                           
                            con.Close();
                            return;


                        }
                    default:
                        {
                            Console.WriteLine("invalid selection");
                            break;
                        }
                }


            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            con.Close();
        }
        
    }
}