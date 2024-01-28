using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_SQL_ORM
{
    internal class Start
    {
        public static void StartMenu()
        {
            Console.Clear();
            
            while (true)
            {
                Console.WriteLine("Choose option below");
                Console.WriteLine("1:Fetch all students \n2:Fetch student from a class \n3:Add new personel\n4:Exit App");

                string UserInput = Console.ReadLine();



                switch (UserInput)
                {
                    case "1":
                        StudentOption.FirstOrLast();
                        break;

                    case "2":
                        Class.ClassMenu();
                        break;

                    case "3":
                        AddPersonel.AddP();
                        break;
                    case "4":
                       break;
                    default:
                        break;
                                              



                }
                if (UserInput == "4")
                {
                    Console.Clear();
                    break;
                }
            }
        }
    }
}
