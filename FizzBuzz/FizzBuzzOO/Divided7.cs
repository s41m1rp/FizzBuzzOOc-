using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzOO
{
    class Divided7 : IDivided
    {
        public bool matches(int num)
        {
            if (num % 7 == 0 && num % 3 != 0 && num % 5 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void stampa(int num)
        {
            Console.WriteLine("woof");
        }
    }
}
