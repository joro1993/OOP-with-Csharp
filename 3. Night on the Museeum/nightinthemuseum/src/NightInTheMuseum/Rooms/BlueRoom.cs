using System;
using System.Collections.Generic;

namespace NightInTheMuseum.Rooms
{
        class BlueRoom
    {
        public void blueRoom()
        {
            var menus = new menus();
            var blackroom = new BlackRoom();
            var purpleroom = new PurpleRoom();
            var whiteroom = new WhiteRoom();
            var greenroom = new GreenRoom();
            menus.headTitle();
            Console.WriteLine();
            menus.showBlueRoom();

            string input = Console.ReadLine();

            switch (input)
            {
                case "U":
                    Console.Clear();
                    blackroom.blackRoom();
                    break;

                case "H":
                    Console.Clear();
                    purpleroom.purpleRoom();
                    break;

                case "V":
                    Console.Clear();
                    whiteroom.whiteRoom();
                    break;

                case "N":
                    Console.Clear();
                    greenroom.greenRoom();
                    break;

                case "Q":
                    menus.shutDown();
                    break;

                default:
                    menus.invalidInput();
                    var blueroom = new BlueRoom();
                    blueroom.blueRoom();
                    break;
            }
        }
    }
}
