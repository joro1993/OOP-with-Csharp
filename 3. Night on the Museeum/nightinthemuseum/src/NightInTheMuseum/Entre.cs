using System;
using NightInTheMuseum.Rooms;
using System.Collections.Generic;
using System.Text;

namespace NightInTheMuseum
{
    public class Entre
    {
        public void entre()
        {
            var menus = new menus();
            var hallway = new Hallway();
            menus.headTitle(); // Anropar main titlen.
            Console.WriteLine();
            menus.showEntre(); // Anropar entrén.

            string input = Console.ReadLine();
            
            switch (input)
            {
                case "U":
                    Console.Clear();
                    hallway.hallway();
                    break;

                case "Q":
                    menus.shutDown(); // Anropar shutDown från menus.cs
                    break;

                default:
                    menus.invalidInput(); // Anropar på invalidInput från menus.cs
                    var entre = new Entre();
                    entre.entre();
                    break;
            }
        }
    }
}