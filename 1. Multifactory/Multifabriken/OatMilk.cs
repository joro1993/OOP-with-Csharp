using System;
using System.Collections.Generic;

namespace Multifabrik
{
    public class oatMilk
    {
        private string _ounces;
        private string _fatPercent;
        public oatMilk(string ounces, string fatPercent)
        {
            _ounces = ounces;
            _fatPercent = fatPercent;
        }

        public void toString()
        {
            List<string> oatMilkItems = new List<string>();
            oatMilkItems.Add(_ounces);
            oatMilkItems.Add(_fatPercent);

            foreach (string oatStuff in oatMilkItems)
            {
                Console.WriteLine(oatStuff);
            }
        }

    }
}


