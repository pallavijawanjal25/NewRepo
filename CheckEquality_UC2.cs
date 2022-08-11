using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCoparison_OppsProblem
{
    public class CheckEquality_UC2
    {
        double Length_XY , Length_SR;
        int X1, X2, Y1, Y2,  S1, S2, R1, R2;
        public void LenghthEqualityCheck()
        {
            bool equal_result = Length_XY.Equals(Length_SR);

            if (equal_result == false)
                Console.WriteLine(" Length of XY and Length of SR are NOT Equal");
            else
                Console.WriteLine("Length of XY and Length of SR are Equal");
            Console.ReadKey();
        }
        }
    }

