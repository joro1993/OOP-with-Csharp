using System;
using System.Collections.Generic;

namespace Multifabrik
{
    public class Cars
    { 
        private string _regNum;
        private string _carColor;
        private string _carType;
        public Cars(string regNum, string carColor, string carType) // konstruktor med variabler
        {   // som jag sedan kopplar ihop med private string variablerna.
            _regNum = regNum;
            _carColor = carColor;
            _carType = carType;
        }

        public void toString()
        {
            // lägger in dessa variabler i listan carItems så den inmatade informationen hamnar i listan.
            List<string> carItems = new List<string>();
            carItems.Add(_regNum);
            carItems.Add(_carColor);
            carItems.Add(_carType);

            foreach (string carStuff in carItems)
            {
                Console.WriteLine(carStuff);
            }
        }

    }
}


