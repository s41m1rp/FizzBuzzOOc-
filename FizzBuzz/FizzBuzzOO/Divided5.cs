using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzOO
{
    class Divided5 : IDivided
    {
        public bool matches(int num)
        {
            if (num % 5 == 0 && num % 3 != 0 && num % 7 != 0)
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
               Console.WriteLine("Buzz");            
        }
    }
    
}
