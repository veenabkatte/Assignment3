using System;
using System.Collections.Generic;
using System.Text;

namespace Assighnment3
{
    class SimpleIntrest
    {
        Double simpleIntrest()
        static void Main()
        {
            int year;
            double princamt, rate, interest, totalAmt;
            Console.WriteLine("enter the Loan amount");
            princamt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter theNumber of year: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the rate of Intest: ");
            rate = Convert.ToDouble(Console.ReadLine());
            interest = princamt * year * rate / 100;
            totalAmt = princamt + interest;
            Console.WriteLine("total amount:{0}", totalAmt);
            Console.ReadLine();

        }
    }
}
