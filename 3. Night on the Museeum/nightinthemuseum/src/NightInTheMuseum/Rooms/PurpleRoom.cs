using System;

namespace NightInTheMuseum.Rooms
{
    class PurpleRoom
    {
        public void purpleRoom()
        {
            var menus = new menus();
            var blueroom = new BlueRoom();
            var redroom = new RedRoom();
            menus.headTitle();
            Console.WriteLine();
            menus.showPurpleRoom();

            string input = Console.ReadLine();

            switch (input)
            {
                case "V":
                    Console.Clear();
                    blueroom.blueRoom();
                    break;

                case "N":
                    Console.Clear();
                    redroom.redRoom();
                    break;

                case "Q":
                    menus.shutDown();
                    break;

                default:
                    menus.invalidInput();
                    var purpleroom = new PurpleRoom();
                    purpleroom.purpleRoom();
                    break;
            }
        }
    }
}
