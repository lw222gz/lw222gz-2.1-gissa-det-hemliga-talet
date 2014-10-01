using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {
        //fält
        private int _count;
        private int _number;
        public const int MaxNumberOfGuesses = 7;

        // metoden som sätter fältet _count till 0 och ger _number ett värde emellan 1-100
        public void Initialize()
        {
            _count = 0;
            Random random = new Random();
            _number = random.Next(1, 101);            
        }

        // metod som hämtar värdet number ifrån main metoden (som matas in där), metoden kollar sen alla "krav" på det inmatade talet.
        public bool MakeGuess(int number)
        {
            
            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (_count < MaxNumberOfGuesses)
            {

                ++_count;
              
                if (number > _number)
                {
                    Console.WriteLine("{0} är för stort, {1} gissningar kvar.", number, (MaxNumberOfGuesses - _count));                 
                }

                if (number < _number)
                {
                    Console.WriteLine("{0} är för litet, {1} gissningar kvar.", number, (MaxNumberOfGuesses - _count));                  
                }
               
                if (number == _number)
                {
                    Console.WriteLine("Du klarade det! Rätt nummer var {0} och du hade {1} gissningar kvar", _number, (MaxNumberOfGuesses - _count));
                    return true;
                }

                if (_count == MaxNumberOfGuesses)
                {
                    Console.WriteLine("Slut på gissningar, detta rätta talet var {0}.", _number);
                }
                                
                return false;
                
            }
            else
            {
                throw new ApplicationException();
            }           
        }

        // konstruktorn secretnumber som kallar på metoden Initialize
        public SecretNumber()
        {
            Initialize();
        }  

    }
}
