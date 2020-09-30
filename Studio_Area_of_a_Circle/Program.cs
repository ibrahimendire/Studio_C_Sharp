using System;

namespace Studio_Area_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a radius: ");
            string userInput = Console.ReadLine();
            double radius = double.Parse(userInput);

            double area = Math.Round(Math.PI * Math.Pow(radius, 2) * 100) / 100;
            double circumference = Math.Round(2 * radius * Math.PI*100)/100;
            if (radius >= 0 )
            {
                Console.WriteLine($"The area of a circle of radius { userInput} is: { area} ");
                Console.WriteLine($"The circumference of a circle of radius {userInput} is: {circumference}  \n ");

                Console.Write("Enter miles per gallon of your car :");
                userInput = Console.ReadLine();
                double milePerGallon = double.Parse(userInput);
                if (milePerGallon > 0)
                {
                    Console.WriteLine("you  will use " + radius * (1 / milePerGallon) + " gallon of gas to go around this circle.");
                }else { Console.Write("Please input Valid data (mile per gallon of your Car gas consumtion) "); }
            }
            else { Console.WriteLine("Please enter valid input"); }

            
        }
    }
}
