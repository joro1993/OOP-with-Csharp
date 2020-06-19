using System;
using System.Collections.Generic;

namespace Multifabrik
{
    public class Pipes
    {
        private string _diameter;
        private string _length;
        public Pipes(string diameter, string length)
        {
            _diameter = diameter;
            _length = length;
        }

        public void toString()
        {
            List<string> pipeItems = new List<string>();
            pipeItems.Add(_diameter);
            pipeItems.Add(_length);

            foreach (string pipeStuff in pipeItems)
            {
                Console.WriteLine(pipeStuff);
            }
        }

    }
}

