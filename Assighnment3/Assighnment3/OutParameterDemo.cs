using System;
using System.Collections.Generic;
using System.Text;

namespace Assighnment3
{
    class OutParameterDemo
    {
        static void Main()
        {
            OutParameter outparameter = new OutParameter();
            double totalAmt;
            Console.WriteLine($"Simple intrest is:{  outparameter.Smpl(1000, 8,3,out totalAmt )}");
            Console.WriteLine($"total Amount is:{totalAmt}");
            Console.ReadLine();
        }
    }
}
