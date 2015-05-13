﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle aCircle = new Circle();
            Console.Write("Enter radius: ");
            aCircle.radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Diameter: " + aCircle.CalculateDiameter());
            Console.WriteLine("Perimeter: " + aCircle.CalculatePerimeter());
            Console.WriteLine("Area: " + aCircle.CalculateArea());
            Console.ReadKey();
        }

        
    }
}