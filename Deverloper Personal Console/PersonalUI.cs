using DevTeamsProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deverloper_Personal_Console
{
    class PersonalUI
    {
        private DeveloperRepo _contentRepo = new DeveloperRepo();

        public void Run()
        {
            Menu();
        }
        //Menu 
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display
                Console.WriteLine("Choose from the Following Selections: \n" +
                    "1. Enter New Developer \n" +
                    "2. View Personnel Directory \n" +
                    "3. View Deverloper by Names \n" +
                    "4. View Deverloper by ID \n" +
                    "5. View Deverloper by Manager \n" +
                    "6. View Deverlopers by Licensing \n" +
                    "7. Update Personal Directory \n" +
                    "8. Edit Personnel Directory \n" +
                    "9. Exist");


                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        //EnterNewPersonnel();
                        break;
                    case "2.":
                        //DisplayAllDevelopers();
                        break;
                    case "3.":
                        //DisplayByName();
                        break;
                    case "4.":
                       //DisplayByIdNumber();
                        break;
                    case "5.":
                        //DisplayByDevelopersByManager();
                        break;
                    case "6.":
                        //DisplayByDevelopersLicensing();
                        break;
                    case "7.":
                        //UpdatePersonal();
                        break;
                    case "8.":
                        //EditPersonnel();
                        break;
                    case"9.":
                        Console.WriteLine("Thank You");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Enter Valid Number.");
                        break;
                }

                Console.WriteLine("press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
