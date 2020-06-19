using System;
using System.Collections.Generic;
using System.Text;

namespace LeftToDo
{
    public class Menu
    {
        public void showMenu()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("*** Välkommen till din att göra-lista! ***");
            Console.WriteLine("******************************************");
            Console.WriteLine();
            Console.WriteLine("[1] Lägg till i din att göra-lista");
            Console.WriteLine("[2] Visa dina uppgifter");
            Console.WriteLine("[3] Arkivera uppgifter");
            Console.WriteLine("[4] Visa arkiverade uppgifter");
            Console.WriteLine();
            Console.WriteLine("Valfri knapp för att avsluta programmet");
            Console.WriteLine();
            Console.WriteLine("Välj ditt nr:");
        }
    }
}