using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCoparison_OppsProblem
{
    
    public class CalculateLength_UC1
    { 
     double Linelegth;
     int X1, X2, Y1, Y2;
    
        public void calculateLength()
        {
            double Length_XY = Math.Sqrt(Math.Pow((X1 - X2), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("Length of Line 1 is:: " + Length_XY);
        }
    }
}
