using System;
using NightInTheMuseum.Rooms;

namespace NightInTheMuseum
{
        public class Program
        {
            static void Main(string[] args)
            {
                var entre = new Entre();
                var menus = new menus();
                string input = " ";
                
                bool runProgram = true;
                while (runProgram)
                {
                if (input != "0") 
                {
                    menus.headTitle();
                    menus.showHowTo();
                    input = Console.ReadLine();
                    Console.Clear();
                }
                 switch(input)
                 {
                    case "F":
                        entre.entre();
                        break;
                    default:
                       menus.invalidInput();
                        break;

                }

            }

            }
        }
}


