using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace DistanceCalculator
{
    using Point3D;
    class DistanceCalculatorMain
    {
        static void Main(string[] args)
        {
            Point3D first =new Point3D(-7,-4,3);
            Point3D second =  new Point3D(17,6,2.5);
            Console.WriteLine(DistanceCalculator.CalculateDistance(first,second));
        }
    }
}
