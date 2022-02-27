using System;

namespace LineComparisonProblem
{
    public class UC_2CheckEquality
    {
        /// <summary>
        /// CHECK THE EQUALITY
        /// </summary>
        public double lengthOfLine2;
        public double isX11;
        public double isY11;
        public double isX22;
        public double isY22;
        public static void CheckEqualityOfTwoLines()
        {
            UC_1CalculateTheLength obj1 = new UC_1CalculateTheLength();
            UC_2CheckEquality obj2 = new UC_2CheckEquality();
            UC_1CalculateTheLength.LenghtBtwnTwoPoint();

            Console.WriteLine("Enter value for 2nd Line point1 isX11 ");
            obj2.isX11 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for 2nd Line point1 isY11 ");
            obj2.isY11 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for 2nd Line point2 isX22 ");
            obj2.isX22 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for 2nd Line point2 isY22 ");
            obj2.isY22 = Convert.ToDouble(Console.ReadLine());

            obj2.lengthOfLine2 = Math.Sqrt((Math.Pow((obj2.isX22 - obj2.isX11), 2)) + (Math.Pow((obj2.isY22 - obj2.isY11), 2)));
            Console.WriteLine($"Length of line2 is : {obj2.lengthOfLine2}");

            Console.WriteLine("Result Of Equality Check");
            Console.WriteLine(obj1.lengthOfLine1.Equals(obj2.lengthOfLine2));

        }

    }
}
