using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCoparison_OppsProblem
{
    internal class UC4_OppsLineComparison
    {
        public int X1, X2, Y1, Y2, S1, S2, R1, R2;

        public double Length_XY;
        public double Length_SR;
        public void length_line()
        {

            Console.WriteLine("Enter x, y co ordinates of the line 1 :");

            Console.WriteLine("Enter value X1");
            X1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter vale X2");
            X2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter vale Y1");
            Y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter vale Y2");
            Y2 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Enter x, y co ordinates of the line 2 :");

            Console.WriteLine("Enter value of S1");
            S1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of S2");
            S2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter vale R1");
            R1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter vale R2 ");
            R2 = Convert.ToInt32(Console.ReadLine());



            double Length_XY = Math.Sqrt(Math.Pow((X1 - X2), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("Length of Line 1 is:: " + Length_XY);

            double Length_SR = Math.Sqrt(Math.Pow((S2 - S1), 2) + Math.Pow((R2 - R1), 2));
            Console.WriteLine("Length of Line 2 is: " + Length_SR);
            Console.ReadLine();

        }


        public void check_equality()
        {
            bool equal_result = Length_XY.Equals(Length_SR);

            if (equal_result == false)
                Console.WriteLine(" Length of XY and Length of SR are NOT Equal");
            else
                Console.WriteLine("Length of XY and Length of SR are Equal");
            Console.ReadKey();
        }

        public void Comparelines()
        {
            double Differene = Length_XY.CompareTo(Length_SR);
            if (Differene < 0)
            {
                Console.WriteLine("Length of XY is less than Length of SR");
            }
            if (Differene > 0)
            {
                Console.WriteLine("Length of XY is greater than Length of SR");
            }
            if (Differene == 0)
            {
                Console.WriteLine("Length of XY is equal to Length of SR");
            }
            Console.ReadKey();
        }
    }
}
