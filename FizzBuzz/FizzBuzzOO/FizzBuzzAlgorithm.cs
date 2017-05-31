using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzOO
{
    class FizzBuzzAlgorithm
    {
        Default _numero = new Default();
        Divided3 _fizz = new Divided3();
        Divided5 _buzz = new Divided5();
        Divided7 _woof = new Divided7();
        Divided15 _fizzBuzz = new Divided15();
        Divided21 _fizzWoof = new Divided21();
        Divided35 _buzzWoof = new Divided35();
        Divided105 _fizzBuzzWoof = new Divided105();

        List<IDivided> numero = new List<IDivided>();
        
        public void initializeAlgorithm()
        {
            numero.Add(_numero);
            numero.Add(_fizz);
            numero.Add(_buzz);
            numero.Add(_woof);
            numero.Add(_fizzBuzz);
            numero.Add(_fizzWoof);
            numero.Add(_buzzWoof);
            numero.Add(_fizzBuzzWoof);
        }

        public void doAlgorithm(int num)
        {
            foreach(var a in numero)
            {
                if (a.matches(num))
                {
                    a.stampa(num);
                }
            }
        }
    }
}
