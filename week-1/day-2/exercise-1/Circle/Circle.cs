using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AreaOfCircle
{
    internal class AOC
    {
        double Radius;

        static void Main(string[] args)
        {
            double radius = 0;
            Console.WriteLine("Enter the value of radius:");
            radius = Convert.ToDouble(Console.ReadLine());


            AOC circle = new AOC(radius);

            Console.WriteLine("Area Of Circle: " + circle.getarea());
            Console.WriteLine("Aree of circumference: " + circle.circumference());

        }
        public AOC(double radius)
        {
            this.Radius = radius;
        }
        public double getarea()
        {
            double pi = 0;
            double area = 0;

            pi = 3.14;
            area = (pi) * this.Radius * this.Radius;
            return area;
        }

        public double circumference()
        {
            double circumference = 0;
            double pi = 0;

            pi = 3.14;
            circumference = 2 * pi * this.Radius;
            return circumference;

        }
    }
}