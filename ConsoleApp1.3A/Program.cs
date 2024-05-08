using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Globalization;

namespace ConsoleApp1._3A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] shapes = { "Triangle", "Square", "Rectangle" };
            Console.WriteLine("What shape are we looking at Triangle, Square, or Rectangle ? ");
            string shape = Console.ReadLine();
            
            Console.WriteLine($"What is the length of the {shape}?");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"What is the width of the {shape}?");
            int width = Convert.ToInt32(Console.ReadLine());


            if (shapes.Contains(shape)) 
            {
                Console.WriteLine()
            }


            static double Triangle(int length, int width) 
            { 
                double area = length * width/2;
                return area;
            }
            static int Square(int length, int width)
            {
                int area = length * width;
                return area;
            }
            static int Rectangle(int length, int width) 
            {
                int area = length * width;
                return area;
            }
        }   

    }
}
