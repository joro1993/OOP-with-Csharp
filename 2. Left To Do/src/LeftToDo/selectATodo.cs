using System;

namespace LeftToDo
{
    public class selectATodo
    {
        private string _whatToDo;
        public selectATodo(string whatToDo)
        {
            _whatToDo = whatToDo;
        }


        public void toString()
        {
            Console.WriteLine(_whatToDo);
        }

    }
}