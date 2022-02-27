using System;

namespace LineComparisonProblem
{
    public class UC_3CompareTwoLines
    {
        /// <summary>
        /// Compares the two line for GRT eql less than.
        /// </summary>
        public static void CompareTwoLineForGrtEqlLessThan()
        {
            UC_1CalculateTheLength obj1 = new UC_1CalculateTheLength();
            UC_2CheckEquality obj2 = new UC_2CheckEquality();
            UC_2CheckEquality.CheckEqualityOfTwoLines();

            if (obj1.lengthOfLine1 > obj2.lengthOfLine2)
            {
                Console.WriteLine($"Length of line1 {obj1.lengthOfLine1} is greater than Length of line2 {obj2.lengthOfLine2}");
            }
            else if (obj1.lengthOfLine1 == obj2.lengthOfLine2)
            {
                Console.WriteLine($"Length of line1 {obj1.lengthOfLine1} is equal to Length of line2 {obj2.lengthOfLine2}");
            }
            else
            {
                Console.WriteLine($"Length of line1 {obj1.lengthOfLine1} is less than Length of line2 {obj2.lengthOfLine2}");
            }
        }
    }
}
