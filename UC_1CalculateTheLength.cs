using System;

namespace LineComparisonProblem
{
    public class UC_1CalculateTheLength
    {
        /// <summary>
        /// The length of line1
        /// </summary>
        public double lengthOfLine1;

        public double isX1;
        public double isY1;
        public double isX2;
        public double isY2;
        public static void LenghtBtwnTwoPoint()
        {
            UC_1CalculateTheLength obj1 = new UC_1CalculateTheLength();
            Console.WriteLine("Enter value for 1st Line point1 isX1 ");
            obj1.isX1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for 1st Line point1 isY1 ");
            obj1.isY1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for 1st Line point2 isX2 ");
            obj1.isX2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for 1st Line point2 isY2 ");
            obj1.isY2 = Convert.ToDouble(Console.ReadLine());


            obj1.lengthOfLine1 = Math.Sqrt((Math.Pow((obj1.isX2 - obj1.isX1), 2)) + (Math.Pow((obj1.isY2 - obj1.isY1), 2)));
            Console.WriteLine($"Length of line1 is : {obj1.lengthOfLine1}");

        }
    }
}
