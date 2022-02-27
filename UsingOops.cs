using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    /// <summary>
    /// UC1 TO UC4 DONE USING OOPS
    /// </summary>
    public class UsingOops
    {
        public static void usedOop()
        {

            UC_1CalculateTheLength obj1 = new UC_1CalculateTheLength();
            UC_2CheckEquality obj2 = new UC_2CheckEquality();
            Console.WriteLine("Result Of Equality Check");
            Console.WriteLine(obj1.lengthOfLine1.Equals(obj2.lengthOfLine2));
            Console.WriteLine("Used CompareTo");
            Console.WriteLine(obj1.lengthOfLine1.CompareTo(obj2.lengthOfLine2));
        }
    }
}
