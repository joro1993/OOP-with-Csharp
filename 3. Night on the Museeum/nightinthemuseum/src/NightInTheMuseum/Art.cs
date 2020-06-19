using System;

namespace NightInTheMuseum 
{
      public class Art //superklass till menus klassen.
    {
        public string artist;
        public string title;
        public string description;

        public void showArtAndDescription()
        {
            Console.WriteLine("Artist: " + artist);
            Console.WriteLine("Titel: " + title);
            Console.WriteLine("Beskrivning: " + description);
            Console.WriteLine();
        }
    }

}