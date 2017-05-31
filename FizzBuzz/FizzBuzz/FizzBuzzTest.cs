using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class FizzBuzzTest
    {
        static void Main(string[] args)
        {
            FizzBuzzTest mod = new FizzBuzzTest();

            for (int i = 1; i <= 100; i++) {
                if(mod.suddivisibile3(i) && mod.suddivisibile5(i))
                    Console.WriteLine("FizzBuzz");
                else if (mod.suddivisibile3(i))
                    Console.WriteLine("Fizz");
                else if(mod.suddivisibile5(i))
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        private bool suddivisibile3(int num)
        {
           return (num % 3 == 0) ? true : false;
                
        }

        private bool suddivisibile5(int num)
        {
            return (num % 5 == 0) ? true : false;

        }

        private bool suddivisibile35(int num)
        {
            return (num % 5 == 0 && num % 3 == 0) ? true : false;

        }
    }
}
