using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates_Demo
{
    class DemoDeligates
    {
        CalculatorDelegate calcuatorDelegate = null;

        internal void Demo(int x, int y)
        {
            calcuatorDelegate = new Calculator().Add;
            Console.WriteLine(calcuatorDelegate(x, y));

            calcuatorDelegate = new Calculator().Substract;
            Console.WriteLine(calcuatorDelegate(x, y));

            calcuatorDelegate = new Calculator().Multiply;
            Console.WriteLine(calcuatorDelegate(x, y));

            calcuatorDelegate = new Calculator().Devide;
            Console.WriteLine(calcuatorDelegate(x, y));

            // passing delegate to another method
            CalculatorDelegate addDelegate = new Calculator().Add;
            CalculatorDelegate substractDelegate = new Calculator().Substract;
            int result = PeformAddAndSubstract(addDelegate, substractDelegate, x, y);
            Console.WriteLine(result);
        }

        /// <summary>
        /// Uses two delegates as input parameters
        /// </summary>
        /// <param name="addDelegate"></param>
        /// <param name="substractDelegate"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int PeformAddAndSubstract(CalculatorDelegate addDelegate, CalculatorDelegate substractDelegate, int x, int y)
        {
            int result = addDelegate(x, y);
            result = substractDelegate(result, y);

            return result;
        }
    }
}
