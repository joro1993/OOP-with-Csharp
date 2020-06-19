using System;
using System.Collections.Generic;

namespace LeftToDo
{
    class Program
    {

        public static void Main(string[] args)
        {
            List<selectATodo> TodoList = new List<selectATodo>(); // toDo Lista
            List<selectATodo> ArchivedList = new List<selectATodo>(); // Archive lista

            bool runProgram = true;
            string input = " ";
            while (runProgram)
            {
               if(input != "0") 
                {
                    var menu = new Menu();
                    menu.showMenu(); //anropar på huvudmenyn och titlen för programmet

                    input = Console.ReadLine();
                }

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Lägg till vad du ska göra:");
                        string whatToDo = Console.ReadLine();

                        var newTodo = new selectATodo(whatToDo);
                        TodoList.Add(newTodo);
                        Console.Clear();
                        break;

                    case "2": // case "2" visar todo-listan
                        Console.Clear();
                        Console.WriteLine("Detta är din todo-lista!");
                        Console.WriteLine();
                        forLoopTodo(); // anropar på forLoopTodo

                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "3": // case "3" visar fram todo-listan fast med möjlighet att arkivera med hjälp av index
                        Console.Clear();
                        Console.WriteLine("Här kan du arkivera dina färdiga uppgifter");
                        forLoopTodo(); // anropar på forLoopTodo 

                        Console.WriteLine();
                        Console.WriteLine("Vilka uppgifter vill du arkivera? Slå in ett index i taget.");
                        int index = Convert.ToInt32(Console.ReadLine());

                        ArchivedList.Add(TodoList[index]); // lägger in uppgifter från todo listan med hjälp av index så dem hamnar i arkiv-listan
                        Console.WriteLine("Archived task " + index + " .");
                        TodoList.RemoveAt(index); // tar bort vad det än är jag tar bort från min todoList (med hjälp av index)
                        Console.Clear();
                        break;

                    case "4": // case "4" listar fram arkiverade uppgifter
                        Console.Clear();
                        Console.WriteLine("Lista över dina arkiverade uppgifter");
                        forLoopArchive(); // anropar på forLoopArchive

                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;

                    default: // default avslutar programmet
                        Console.WriteLine("Du måste välja mellan 1-5");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }


                
            }

             void forLoopTodo() // for loop för att få fram min todo lista
            {
                for (int i = 0; i < TodoList.Count; i++)
                {
                    var myTodo = TodoList[i];
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Index " + i);
                    Console.WriteLine("---------------------");
                    myTodo.toString();
                }
            }
            void forLoopArchive() // for loop för att få fram min archive lista
            {
                for (int i = 0; i < ArchivedList.Count; i++)
                {
                    var myArchivedTask = ArchivedList[i];
                    Console.WriteLine();
                    Console.WriteLine("Index " + i);
                    Console.WriteLine("---------------------");
                    myArchivedTask.toString();
                }
            }

        }
    
    }
}
