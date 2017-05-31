using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzOO
{
    class FizzBuzzOOTest
    {
        static void Main(string[] args)
        {
            FizzBuzzAlgorithm alg = new FizzBuzzAlgorithm();
            alg.initializeAlgorithm();

            for(int i = 1; i<=105; i++)
            {
                alg.doAlgorithm(i);                
            }
            Console.ReadLine();
        }
    }
}
