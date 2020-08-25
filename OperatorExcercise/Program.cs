using System;

namespace OperatorExcercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //-----------------------Exercise 1--------------------
            //explicit typing -
            string variableName = "Hello";

            //inferred typing -
            var varName = "Hello";

            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;


            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");


            //Allow user input the radius
            Console.WriteLine("What is the radius of your circle?");
                var radius = double.Parse(Console.ReadLine());

            //Calculate are of the circle
            var areaOfCircle = CalculateArea(radius);

            Console.WriteLine($"The area of a circle with radius of {radius} is {areaOfCircle}");





        }

        public static double CalculateArea(double radius)
        {

            return Math.PI * (radius * radius);
        }

    }
}
