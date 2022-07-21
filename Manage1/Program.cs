using Core.Constants;
using Core.Entities;
using Core.Helpers;
using DataAccess.Implementations;
using Manage1.Controller;
using System;
namespace Manage1
{
    public class Manage1
    {

        static void Main()
        {


            GroupController _groupController = new GroupController();



            ConsoleHelpers.WriteTextWithColor(ConsoleColor.Green, "Welcome My First App...");
            Console.WriteLine("--------------------------------------------------");



            while (true)
            {


                ConsoleHelpers.WriteTextWithColor(ConsoleColor.Yellow, "1 - Create Group");
                ConsoleHelpers.WriteTextWithColor(ConsoleColor.Yellow, "2 - Update Group");
                ConsoleHelpers.WriteTextWithColor(ConsoleColor.Yellow, "3 - Delete Group");
                ConsoleHelpers.WriteTextWithColor(ConsoleColor.Yellow, "4 - All Group");
                ConsoleHelpers.WriteTextWithColor(ConsoleColor.Yellow, "5 - Get Group By Name");
                ConsoleHelpers.WriteTextWithColor(ConsoleColor.Yellow, "0 - Exit");
                Console.WriteLine("--------------------------------------------------");


                ConsoleHelpers.WriteTextWithColor(ConsoleColor.Magenta, "Select Options:");
                string number = Console.ReadLine();

                int selectedNumber;
                bool result = int.TryParse(number, out selectedNumber);

                if (result)
                {
                    if (selectedNumber >= 0 && selectedNumber <= 5)
                    {
                        switch (selectedNumber)
                        {
                            case (int)Options.CreateGroup:
                                _groupController.CreateGroup();
                                break;
                            case (int)Options.UpdateGroup:
                                _groupController.UpdateGroup();
                                break;
                            case (int)Options.DeleteGroup:
                                _groupController.DeleteGroup();
                                break;
                            case (int)Options.AllGroup:
                                _groupController.AllGroup();
                                break;
                            case (int)Options.GetGroupByName:
                                _groupController.GetGroupByName();
                                break;
                            case (int)Options.Exit:
                                _groupController.Exit();    
                                return;



                        }
                    }
                    else
                    {
                        ConsoleHelpers.WriteTextWithColor(ConsoleColor.Red, "Please, Select Correct Options...");
                    }
                }
                else
                {
                    ConsoleHelpers.WriteTextWithColor(ConsoleColor.Red, "Please, Select Correct Options...");
                }



            }




        }
    }
}