using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_SQL_ORM
{
    internal class Class
    {      
        
        public static void ClassMenu()
        {
            Console.Clear();
            bool MenyOn = true;
            while (MenyOn)
            {
                Console.WriteLine("Choose student class below");
                Console.WriteLine("1:Class A\n2:Class B\n3:Class C\n4:Back to main menu");

                string UserChoice = Console.ReadLine();

                switch (UserChoice)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        Console.Clear();
                        return;
                        
                }

                if(UserChoice == "1")
                {
                    Console.Clear();
                    
                    SqlConnection sqlCon = new SqlConnection(@"Data Source = ANTON;Initial Catalog=SchoolDB;Integrated security = True");
                    SqlDataAdapter sqldata = new SqlDataAdapter("select * from Students Where Class = 'A'", sqlCon);
                    DataTable datatable = new DataTable();
                    sqldata.Fill(datatable);

                    foreach (DataRow row in datatable.Rows)
                    {
                        Console.Write(row["FirstName"] + " ");
                        Console.Write(row["LastName"]);
                        Console.WriteLine();




                    }
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (UserChoice == "2")
                {
                    Console.Clear();

                    SqlConnection sqlCon = new SqlConnection(@"Data Source = ANTON;Initial Catalog=SchoolDB;Integrated security = True");
                    SqlDataAdapter sqldata = new SqlDataAdapter("select * from Students Where Class = 'B'", sqlCon);
                    DataTable datatable = new DataTable();
                    sqldata.Fill(datatable);

                    foreach (DataRow row in datatable.Rows)
                    {
                        Console.Write(row["FirstName"] + " ");
                        Console.Write(row["LastName"]);
                        Console.WriteLine();




                    }
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();

                    SqlConnection sqlCon = new SqlConnection(@"Data Source = ANTON;Initial Catalog=SchoolDB;Integrated security = True");
                    SqlDataAdapter sqldata = new SqlDataAdapter("select * from Students Where Class = 'C'", sqlCon);
                    DataTable datatable = new DataTable();
                    sqldata.Fill(datatable);

                    foreach (DataRow row in datatable.Rows)
                    {
                        Console.Write(row["FirstName"] + " ");
                        Console.Write(row["LastName"]);
                        Console.WriteLine();




                    }
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
