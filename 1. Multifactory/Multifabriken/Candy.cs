using System;
using System.Collections.Generic;

namespace Multifabrik
{
    public class candy
    {
        private string _flavor;
        private string _amount;
        public candy(string flavor, string amount)
        {
            _flavor = flavor;
            _amount = amount;
        }

        public void toString()
        {
            List<string> candyItems = new List<string>();
            candyItems.Add(_flavor);
            candyItems.Add(_amount);

            foreach (string candyStuff in candyItems)
            {
                Console.WriteLine(candyStuff);
            }
        }

    }
}


