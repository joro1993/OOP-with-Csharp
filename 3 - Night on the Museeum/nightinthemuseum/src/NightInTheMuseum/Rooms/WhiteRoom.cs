using System;

namespace NightInTheMuseum.Rooms
{
    class WhiteRoom
    {
        public void whiteRoom()
        {
            var menus = new menus();
            var blueroom = new BlueRoom();
            menus.headTitle();
            menus.showWhiteRoom();

            string input = Console.ReadLine();

            switch (input)
            {
                case "H":
                    Console.Clear();
                    blueroom.blueRoom();
                    break;

                case "Q":
                    menus.shutDown();
                    break;

                default:
                    menus.invalidInput();
                    var whiteroom = new WhiteRoom();
                    whiteroom.whiteRoom();
                    break;
            }
        }
    }
}
