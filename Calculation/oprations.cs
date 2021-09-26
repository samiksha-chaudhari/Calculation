using System;
using System.Collections.Generic;
using System.Text;

namespace Calculation
{
   public class oprations
   {
        public int Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition is :" +result);
            return result;
        }

        public int Sub(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction is :" + result);
            return result;
        }
    }
}
