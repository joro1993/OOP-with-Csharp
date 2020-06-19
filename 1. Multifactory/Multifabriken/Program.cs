using System;
using System.Collections.Generic;

namespace Multifabrik
{
    class Program
    {
        static void Main(string[] args)
        {   // listor kopplade till dem olika classerna och filerna för programmet.
            List<Cars> carList = new List<Cars>();
            List<Pipes> pipeList = new List<Pipes>();
            List<oatMilk> oatMilkList = new List<oatMilk>();
            List<candy> candyList = new List<candy>();



            string input = " "; // en tom string för att kunna navigera i menyfältet med olika nr.
            while (input != "6") // sålänge input inte är 6 så kommer programmet fortsätta att köras tills input blir 6.
            {
                Console.WriteLine("#===============================#");
                Console.WriteLine("# Välkommen till Multifabriken! #");
                Console.WriteLine("#===============================#");
                //meny och title
                Console.WriteLine();
                Console.WriteLine("[1] Bil");
                Console.WriteLine("[2] Rör");
                Console.WriteLine("[3] Havremjölk");
                Console.WriteLine("[4] Godis");
                Console.WriteLine("[5] Visa allt som du har beställt");
                Console.WriteLine("[6] Avsluta");
                Console.WriteLine("Välj vad du vill beställa:");
                input = Console.ReadLine();

                if (input == "1")
                {   // Console.WriteLines och console.ReadLines för att mata in information som sparas i en lista
                    Console.Clear();
                    Console.WriteLine("Välj registreringsnummer TTT - 111: ");
                    string regNum = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Välj färg:");
                    string carColor = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Välj märke: ");
                    string carType = Console.ReadLine();

                    // skapar ny car från konstruktor
                    var myNewCar = new Cars(regNum, carColor, carType);
                    // Lägger till myNewCar variablen i carList
                    carList.Add(myNewCar);
                    Console.Clear();
                }

                else if (input == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Diameter?(svara med 00 D som i diameter)");
                    string diameter = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Längd?(svara med cm)");
                    string length = Console.ReadLine();
                    Console.Clear();

                    var myNewPipes = new Pipes(diameter, length);
                    pipeList.Add(myNewPipes);
                    Console.Clear();
                }

                else if (input == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Hur många liter?");
                    string ounces = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("fetthalt?");
                    string fatPercent = Console.ReadLine();
                    Console.Clear();

                    var myNewOatMilk = new oatMilk(ounces, fatPercent);
                    oatMilkList.Add(myNewOatMilk);
                    Console.Clear();


                }

                else if (input == "4")
                {
                    Console.Clear();
                    Console.WriteLine("smak?");
                    string flavor = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Antal?");
                    string amount = Console.ReadLine();
                    Console.Clear();

                    var myNewCandy = new candy(flavor, amount);
                    candyList.Add(myNewCandy);
                    Console.Clear();
                }


                else if (input == "5")
                {
                    Console.Clear();
                    if (carList.Count > 0) // listorna måste ha en count med en index högre än 0 för att visas
                    {   // här visas listorna från dem olika produkterna man kan beställa.
                        Console.WriteLine("BIL:");
                        var myCar = carList[0];
                        myCar.toString();
                        Console.WriteLine(); 
                    }

                    if (pipeList.Count > 0)
                    {
                        Console.WriteLine("RÖR:");
                        var myPipe = pipeList[0];
                        myPipe.toString();
                        Console.WriteLine();
                    }

                    if (oatMilkList.Count > 0)
                    {
                        Console.WriteLine("HAVREMJÖLK:");
                        var myOatMilk = oatMilkList[0];
                        myOatMilk.toString();
                        Console.WriteLine();
                    }

                    if (candyList.Count > 0)
                    { 
                        Console.WriteLine("GODIS:");
                        var myCandy = candyList[0];
                        myCandy.toString();
                        Console.WriteLine();
                    }
                }

                else if (input == "6")
                { 
                    Console.Clear(); // avslutar programmet om man matar in nr 6.
                    Console.WriteLine("Programmet avslutas!");
                }
            }
        }

    }
}