using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass triangles = new MyClass();
            Console.Write("Input number of rows: ");
            int userRows = Int32.Parse(Console.ReadLine());

            string pyramid = triangles.PrintPyramid(userRows);
            string rightTriangle = triangles.PrintRightTriangle(userRows);

            Console.WriteLine(pyramid);
            Console.WriteLine(rightTriangle);

            Console.ReadLine();

        }
    }
}
