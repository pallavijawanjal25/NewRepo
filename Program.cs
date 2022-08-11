using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCoparison_OppsProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Problem using OOP Concept.");
            Console.WriteLine("");
            Console.WriteLine("Enter x coordinate of point1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y coordinate of point1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x coordinate of point2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y coordinate of point2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            CalculateLength_UC1 lengthCalculation = new CalculateLength_UC1();
            lengthCalculation.calculateLength();

            Console.WriteLine("To Check Both Line Equals or not by Equals method");
            Console.WriteLine("Enter start and end points of First line: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter start and end points of Second line: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            CheckEquality_UC2 EqualityCheck = new CheckEquality_UC2();
            EqualityCheck.LenghthEqualityCheck();

            Console.WriteLine("To Compare Both Line by CompareTo method");
            Console.WriteLine("Please Enter the first line coordinates");
            int l1 = Convert.ToInt32(Console.ReadLine());
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter start and end points of Second line: ");
            int l2 = Convert.ToInt32(Console.ReadLine());
            int m2 = Convert.ToInt32(Console.ReadLine());
            LineComparision_UC3 TwoLineComparison=new LineComparision_UC3();
            TwoLineComparison.CheckTwoLineComparison();

            Console.WriteLine("check line point usin equal and compareTo Methode");
            UC4_OppsLineComparison line = new UC4_OppsLineComparison();
            line.length_line();
            line.check_equality();
            line.Comparelines();


            Console.ReadKey();
        }

    }
    }

