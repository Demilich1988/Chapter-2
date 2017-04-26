using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Variables for Area of Triange
            double triBase = 1.5;
            double triHeight = 4;
            double triArea = .5 * triBase * triHeight;
            
            //Create variable for remainders
            int a= 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            int restore = b * quotient + remainder;

            //Create variables for cylinders
            double cylHeight;
            double cylRadius;
            String userHeight;
            String userRadius;
            double pie = 3.1415926;
            double cylVolume;
            double cylArea;

            //Ask user for height and Radius
            Console.Write("Please enter in cylander height");
            userHeight = Console.ReadLine();
            Console.Write("Please enter in cylander radius");
            userRadius = Console.ReadLine();


            //Convert user input to double
            cylHeight = Convert.ToDouble(userHeight);
            cylRadius = Convert.ToDouble(userRadius);


            //preform math for volume and area
            cylVolume = pie * cylRadius * cylRadius * cylHeight;
            cylArea = 2 * pie * cylRadius * (cylRadius + cylHeight);

            //Output
            Console.WriteLine(cylVolume);
            Console.WriteLine(cylArea);








            //Command for console to wait on user command before closing
            Console.ReadKey();


        }
    }
}
