using System;
using System.Collections.Generic;
using System.Text;
using NightInTheMuseum.Rooms;

namespace NightInTheMuseum
{
    public class Hallway
    {
        public void hallway()
        {
            var menus = new menus();
            var entre = new Entre();
            var blueroom = new GreenRoom();
            menus.headTitle(); // Anropar main titlen
            Console.WriteLine();
            menus.showhallway(); // Anropar korridoren.
            string input = Console.ReadLine();

            switch (input)
            {
                case "U":
                    Console.Clear();
                    blueroom.greenRoom(); // Anropar det gröna rummet.
                    break;

                case "N":
                    Console.Clear();
                    entre.entre(); // Entrén
                    break;

                case "Q":
                    menus.shutDown(); // Anropar på ShutDown
                    break;

                default:
                    menus.invalidInput(); // Anropar på invalidInput.
                    var hallway = new Hallway();
                    hallway.hallway();
                    break;
            }

        }
    
    }
        
}