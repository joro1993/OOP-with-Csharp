using System;

namespace NightInTheMuseum
{
     public class menus : Art // menus är en subklass till Art.
    {
        public void headTitle()
        {   // Huvudtitlen
            Console.WriteLine("*****************************");
            Console.WriteLine("*** RetroSpel's muséeumet ***");
            Console.WriteLine("*****************************");
            Console.WriteLine();
        }
        public void showHowTo()
        {   // visar hur programmet fungerar
            Console.WriteLine("Hej! Och välkommen till retrospel museeumet!");
            Console.WriteLine("Denna konsollen är ett sätt för dig att navigera");
            Console.WriteLine("Och upptäcka vad som finns här att se!");
            Console.WriteLine("Såhär gör du:");
            Console.WriteLine("U - Uppåt || N - Neråt || H - Höger || V - Vänster || Q - Avsluta");
            Console.WriteLine();
            Console.WriteLine("Tryck F för att fortsätta... ");
        }
        public void showEntre()
        {   // Entré texten
            Console.WriteLine("---------------");
            Console.WriteLine("--- Entrén! ---");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine("Tryck U för att gå uppåt. Vill du stänga av? Tryck Q");
        }
        public void showhallway()
        {   // Korridor texten
            Console.WriteLine("------------------");
            Console.WriteLine("--- Korridoren ---");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Tryck U för att gå uppåt till museumets första rum, det gröna rummet!");
            Console.WriteLine("För att gå neråt till Entrén, tryck N");
            Console.WriteLine("Tryck Q för att stänga av.");
        }

        public void showGreenRoom()
        {   // Sega rummet
            Console.WriteLine("--------------------");
            Console.WriteLine("--- Gröna Rummet ---");
            Console.WriteLine("--------------------");
            Console.WriteLine();

            Art greenArt1 = new Art();
            greenArt1.artist = "Hajime Satomi, CEO Sega Corp.";
            greenArt1.title = "SEGA SG-1000. ";
            greenArt1.description = "Detta är en konsoll från 1983. Sega's första spelkonsoll!";
            greenArt1.showArtAndDescription();

            Art greenArt2 = new Art();
            greenArt2.artist = "Hajime Satomi, CEO Sega Corp.";
            greenArt2.title = "SEGA Master System";
            greenArt2.description = "Detta är en konsoll från 1985, Sega's andra spelkonsoll!";
            greenArt2.showArtAndDescription();

            Console.WriteLine();
            Console.WriteLine("Fortsätt Uppåt till det blåa rummet, tryck U");
            Console.WriteLine("Gå till det röda rummet till Höger, tryck H");
            Console.WriteLine("För att gå Neråt till korridoren, tryck N.");
            Console.WriteLine("Tryck Q för att stänga av.");
        }

        public void showRedRoom()
        {   // Arcade rummet
            Console.WriteLine("-------------------");
            Console.WriteLine("--- Röda Rummet ---");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Art redArt1 = new Art();
            redArt1.artist = "Toru Iwatani";
            redArt1.title = "Pac-Man";
            redArt1.description = "Alla har hört talats om Pac-Man! Det skapades först som ett arkadspel år 1980!";
            redArt1.showArtAndDescription();

            Art redArt2 = new Art();
            redArt2.artist = "Tomohiro Nishikado";
            redArt2.title = "Space Invaders";
            redArt2.description = "Ytterligare ett klassiskt arkadspel. Släpptes år 1978.";
            redArt2.showArtAndDescription();

            Art redArt3 = new Art();
            redArt3.artist = "Atari";
            redArt3.title = "Star wars";
            redArt3.description = "Alla vet vad star wars är! Men alla kanske inte vet om detta arkadspel. Släpptes 1983!";
            redArt3.showArtAndDescription();

            Console.WriteLine("Tryck U för att gå Uppåt till det lila rummet");
            Console.WriteLine("Tryck H för att gå Vänster till det gröna rummet");
            Console.WriteLine("Tryck Q för att stänga av.");
        }

        public void showBlueRoom()
        { // The playstation
            Console.WriteLine("-------------------");
            Console.WriteLine("--- Blåa Rummet ---");
            Console.WriteLine("-------------------");
            Console.WriteLine();

            Art blueArt = new Art();
            blueArt.artist = "Sony Interactive Entertainment";
            blueArt.title = "The Playstation";
            blueArt.description = "Detta är sony's första konsoll som släpptes år 1994!";
            blueArt.showArtAndDescription();

            Console.WriteLine("Tryck U för att gå Uppåt till svarta rummet");
            Console.WriteLine("Tryck H för att gå Höger till det lila rummet");
            Console.WriteLine("Tryck V för att gå Vänster till det vita rummet");
            Console.WriteLine("Tryck N för att gå Ner till det gröna rummet");
            Console.WriteLine("Tryck Q för att stänga av.");
        }

        public void showBlackRoom()
        {   // Svarta rummet som är tomt
            Console.WriteLine("---------------------");
            Console.WriteLine("--- Svarta Rummet ---");
            Console.WriteLine("---------------------");
            Console.WriteLine();
            Console.WriteLine("I detta rummet finns det tyvärr ingenting(ÄN!).");
            Console.WriteLine();
            Console.WriteLine("Tryck N för att gå neråt till det blåa rummet");
            Console.WriteLine("Tryck Q för att stänga av.");
        }

        public void showWhiteRoom()
        { // Första spelet ever
            Console.WriteLine("-------------------");
            Console.WriteLine("--- Vita Rummet ---");
            Console.WriteLine("-------------------");
            Console.WriteLine();

            Art whiteArt = new Art();
            whiteArt.artist = "William Higinbotham";
            whiteArt.title = "Pong";
            whiteArt.description = "släpptes år 1958. Sägs vara världens första videospel, ett simpelt tennis spel!";
            whiteArt.showArtAndDescription();

            Console.WriteLine("Tryck H för att gå höger till det blåa rummet");
            Console.WriteLine("Tryck Q för att stänga av.");
        }

        public void showPurpleRoom()
        {   // Nintendo rummet
            Console.WriteLine("-------------------");
            Console.WriteLine("--- Lila Rummet ---");
            Console.WriteLine("-------------------");
            Console.WriteLine();

            Art purpleArt1 = new Art(); 
            purpleArt1.artist = "Nintendo R&D2";
            purpleArt1.title = "Color TV-game";
            purpleArt1.description = "släpptes år 1977, första konsollerna med färg. Innehåller 6 versioner av Pong.";
            purpleArt1.showArtAndDescription();

            Art purpleArt2 = new Art();
            purpleArt2.artist = "Nintendo R&D2";
            purpleArt2.title = "Nintendo Entertainment System";
            purpleArt2.description = "Den första, klassiska nintendo konsollen. Släpptes 1983";
            purpleArt2.showArtAndDescription();

            Art purpleArt3 = new Art();
            purpleArt3.artist = "Nintendo R&D2";
            purpleArt3.title = "Super Nintendo Entertainment System";
            purpleArt3.description = "Uppföljaren till Nintendo Entertainment System. Släpptes år 1990.";
            purpleArt3.showArtAndDescription();

            Art purpleArt4 = new Art();
            purpleArt4.artist = "Nintendo IRD";
            purpleArt4.title = "Nintendo 64";
            purpleArt4.description = "Uppföljaren till Super Nintendo Entertainment System. släpptes år 1996.";
            purpleArt4.showArtAndDescription();

            Console.WriteLine("Tryck H för att gå Höger till det blåa rummet");
            Console.WriteLine("Tryck N för att gå Neråt till det röda rummet");
            Console.WriteLine("Tryck Q för att stänga av");
        }

        public void shutDown()
        {   //Metod för att stänga ner programmet
            Console.Clear();
            Console.WriteLine("Välkommen åter!");
            Environment.Exit(0);
        }

        public void invalidInput() 
        {   // När man skriver in fel input så kommer denna upp.
            Console.WriteLine("Ogiltig input!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
