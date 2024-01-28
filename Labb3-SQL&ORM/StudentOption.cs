using Labb3_SQL_ORM.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_SQL_ORM
{
    public class StudentOption : SchoolDBContext
    {
        
        public static void FirstOrLast()
        {
            Console.Clear();
            bool menyOn = true;

            while(menyOn)
            {
                Console.WriteLine("Choose option below");
                Console.WriteLine("1:Sort by first name acending\n2:Sort by first name decending\n3:Sort by last name acending\n4:Sort by last name decending\n5:Back to main menu");

                string sortby = Console.ReadLine();

                switch (sortby)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        Console.Clear();
                        return;
                        

                }

                if (sortby == "1")
                {
                    Console.Clear();
                    SqlConnection sqlCon = new SqlConnection(@"Data Source = ANTON;Initial Catalog=SchoolDB;Integrated security = True");
                    SqlDataAdapter sqldata = new SqlDataAdapter("select * from Students ORDER BY FirstName DESC", sqlCon);
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
                else if (sortby == "2")
                {
                    Console.Clear();
                    SqlConnection sqlCon = new SqlConnection(@"Data Source = ANTON;Initial Catalog=SchoolDB;Integrated security = True");
                    SqlDataAdapter sqldata = new SqlDataAdapter("select * from Students ORDER BY FirstName DESC", sqlCon);
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
                else if (sortby == "3")
                {
                    Console.Clear();
                    SqlConnection sqlCon = new SqlConnection(@"Data Source = ANTON;Initial Catalog=SchoolDB;Integrated security = True");
                    SqlDataAdapter sqldata = new SqlDataAdapter("select * from Students ORDER BY LastName ASC", sqlCon);
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
                    SqlDataAdapter sqldata = new SqlDataAdapter("select * from Students ORDER BY LastName DESC", sqlCon);
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
