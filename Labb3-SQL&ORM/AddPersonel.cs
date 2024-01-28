using Labb3_SQL_ORM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_SQL_ORM
{
    internal class AddPersonel
    {
        public static void AddP()
        {
            SchoolDBContext db = new SchoolDBContext();

            var allstaff = from Personel in db.Personels
                           orderby Personel.FirstName
                           select Personel;
          
            Console.WriteLine("First name:");
            string fName = Console.ReadLine();

            Console.WriteLine("Last name:");
            string lName = Console.ReadLine();

            Console.WriteLine("Choose department\n1:Teacher\n2:HeadMaster\n3:IT");
            int UserInputDP = Convert.ToInt32(Console.ReadLine());

            int departmenID = 0;
            
            switch (UserInputDP)
            {
                case 1:
                    departmenID = 1; 
                    break;
                case 2:
                    departmenID = 2;
                    break;
                case 3:
                    departmenID = 3;
                    break;
            }

            Personel NewPersonel = new Personel()
            {
                FirstName = fName,
                LastName = lName,
                DepartmentId = departmenID,
            };

            db.Add(NewPersonel);
            db.SaveChanges();

            Start.StartMenu();

        }
    }
}
