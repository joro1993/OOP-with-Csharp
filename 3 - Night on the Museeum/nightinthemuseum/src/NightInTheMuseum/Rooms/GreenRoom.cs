using System;
using System.Collections.Generic;
using System.Text;

namespace NightInTheMuseum.Rooms
{
  class GreenRoom
    {
        public void greenRoom()
        {
            var menus = new menus();
            var hallway = new Hallway();
            var blueroom = new BlueRoom();
            var redroom = new RedRoom();
            menus.headTitle();
            menus.showGreenRoom();

            string input = Console.ReadLine();

            


            switch (input)
            {
                case "U":
                    Console.Clear();
                    blueroom.blueRoom();
                    break;

                case "H":
                    Console.Clear();
                    redroom.redRoom();
                    break;

                case "N":
                    Console.Clear();
                    hallway.hallway();
                    break;

                case "Q":
                    menus.shutDown();
                    break;

                default:
                    menus.invalidInput();
                    var greenroom = new GreenRoom();
                    greenroom.greenRoom();
                    break;
            }
                
            
        }
    }
}
