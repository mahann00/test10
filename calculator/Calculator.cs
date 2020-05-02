using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Calculator : IMyCalculator
    {
        int IMyCalculator.divide(int number1, int number2)
        {
            return number1 / number2;

           
        }

        int IMyCalculator.minus(int number1, int number2)
        {
            return number1 - number2;

            
        }

        int IMyCalculator.multiple(int number1, int number2)
        {
            return number1 * number2;

            
        }

        int IMyCalculator.plus(int number1, int number2)
        {
            return number1 + number2;
          
        }
    }
}
