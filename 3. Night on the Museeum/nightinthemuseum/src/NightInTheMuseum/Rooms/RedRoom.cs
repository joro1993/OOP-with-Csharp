using System;

namespace NightInTheMuseum.Rooms
{
    class RedRoom
    {
        public void redRoom()
        {
            var menus = new menus();
            var greenroom = new GreenRoom();
            var purpleroom = new PurpleRoom();
            menus.headTitle();
            Console.WriteLine();
            menus.showRedRoom();

            string input = Console.ReadLine();

            switch (input)
            {
                case "H":
                    Console.Clear();
                    greenroom.greenRoom();
                    break;

                case "U":
                    Console.Clear();
                    purpleroom.purpleRoom();
                    break;

                case "Q":
                    menus.shutDown();
                    break;

                default:
                    menus.invalidInput();
                    var redroom = new RedRoom();
                    redroom.redRoom();
                    break;
            }
        }
    }
}
