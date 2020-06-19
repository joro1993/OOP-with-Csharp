using System;

namespace NightInTheMuseum.Rooms
{
    class BlackRoom
    {
        public void blackRoom()
        {
            var menus = new menus();
            var blueroom = new BlueRoom();
            menus.headTitle();
            Console.WriteLine();
            menus.showBlackRoom();

            string input = Console.ReadLine();

            switch (input)
            {
                case "N":
                    Console.Clear();
                    blueroom.blueRoom();
                    break;

                case "Q":
                    menus.shutDown();
                    break;

                default:
                    menus.invalidInput();
                    var blackroom = new BlackRoom();
                    blackroom.blackRoom();
                    break;
            }
        }
    }
}
