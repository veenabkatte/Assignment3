using System;
using System.Collections.Generic;
using System.Text;

namespace Assighnment3
{
    class Factorial
    {
        static void Main()
        {
            int i, fact = 1, number;
            Console.Write("enter any Number:");
            number = int.Parse(Console.ReadLine());
            for(i=1;i<=number;i++)
            {
                fact = fact * i;
            }

            Console.Write("Factorial of" + number + "is:"+fact);
            Console.ReadLine();
        }
        
    }
}
