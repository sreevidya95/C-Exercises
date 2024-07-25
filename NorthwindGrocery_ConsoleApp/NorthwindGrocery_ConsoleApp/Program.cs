
using System.Data.SqlClient;
using System.Xml.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("User Menu");
            Console.WriteLine("-----------");
            Console.WriteLine("1. List All Categories");
            Console.WriteLine("2.List Products in specific Category");
            Console.WriteLine("3.List Products in a price range");
            Console.WriteLine("4.List All Suppliers");
            Console.WriteLine("5.List products from specific category");
            Console.WriteLine("6.Quit");
            Console.WriteLine("Enter your selection");
            int selection = int.Parse(Console.ReadLine());
            
                const string ConnectionString = "Server=WSAMZN-GDQ29NA1;Initial Catalog=demo;User Id=sa;Password=Password@123;";
               SqlConnection con = new SqlConnection(ConnectionString);

           
            switch (selection)
            {

                case 1:
                    {
                        Console.WriteLine("Categories");
                        try
                        {
                          
                            SqlCommand cm = new SqlCommand("Select * from categories", con);
                            con.Open();
                            SqlDataReader sdr = cm.ExecuteReader();
                            while (sdr.Read())
                            {
                                Console.WriteLine(sdr["categoryname"]);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter category name");
                        string name = Console.ReadLine();
                        try
                        {
                            SqlCommand comm = new SqlCommand($"Select * from categories where CategoryName = @name", con);
                            comm.Parameters.AddWithValue("@name", name);

                            con.Open();
                            SqlDataReader sdr = comm.ExecuteReader();
                            if (sdr.HasRows == false)
                            {
                                Console.WriteLine("Couldnt find the category you gave");
                            }
                            else
                            {
                                while (sdr.Read())
                                {
                                    Console.WriteLine(sdr["categoryname"] + "  " + sdr["description"]);
                                }
                               
                            }
                        }catch(Exception e)
                        {

                        Console.WriteLine(e.Message); 
                        }
                        
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter Minimun Price:");
                        int min = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Maximum Price:");
                        int max = int.Parse(Console.ReadLine());
                        try
                        {
                            SqlCommand comm = new SqlCommand("Select * from products where unitprice IN (@min,@max)", con);
                            con.Open();
                            comm.Parameters.AddWithValue("@min", min);
                            comm.Parameters.AddWithValue("@max", max);
                            SqlDataReader sdr = comm.ExecuteReader();
                            if (sdr.HasRows == false)
                            {
                                Console.WriteLine("sorry no data exists for your selection");
                            }
                            else
                            {
                                while (sdr.Read())
                                {
                                    Console.WriteLine("Product name: " + sdr["productname"] + " unitprice: " + sdr["unitprice"]);
                                }
                            }
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                        }



                        break;
                    }
                case 4:
                    {
                        try
                        {
                            Console.WriteLine("All suppliers");
                            SqlCommand cm = new SqlCommand("Select * from suppliers", con);
                            con.Open();
                            SqlDataReader sdr = cm.ExecuteReader();
                            while (sdr.Read())
                            {
                                Console.WriteLine(sdr["companyname"]);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    break;
                    }
                case 5:
                    {
                        Console.WriteLine("Enter supplier id");
                        int id = int.Parse(Console.ReadLine());
                        try
                        {
                            SqlCommand comm = new SqlCommand("Select * from suppliers where supplierid = @id", con);
                            comm.Parameters.AddWithValue("@id", id);

                            con.Open();
                            SqlDataReader sdr = comm.ExecuteReader();
                            if (sdr.HasRows == false)
                            {
                                Console.WriteLine("Couldnt find the category you gave");
                            }
                            else
                            {
                                while (sdr.Read())
                                {
                                    Console.WriteLine(sdr["companyname"]);
                                }

                            }
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                        }
                        break;
                    }
                case 6:
                    {
                        con.Close();
                        return;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Selection");
                        break;
                    }
            }
        }
    }
}