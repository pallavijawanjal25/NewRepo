using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCoparison_OppsProblem
{
    public class LineComparision_UC3
    {
        double Length_XY, Length_SR;
        public void CheckTwoLineComparison()
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

