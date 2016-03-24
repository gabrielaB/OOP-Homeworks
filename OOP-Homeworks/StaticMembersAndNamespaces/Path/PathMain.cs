using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Path
{
    using Point3D;
    class PathMain
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Point3D firstPoint =new Point3D(3,5,6);
            Point3D secondPoint= new Point3D(4,6,7);
            Point3D thirdPoint3D =  new Point3D(7,8,9);

            List<Point3D> firstPoints = new List<Point3D>() {firstPoint, secondPoint, thirdPoint3D};
            List<Point3D> secondPoints = new List<Point3D>() {  thirdPoint3D };
            List<Point3D> thirdPoints = new List<Point3D>() { firstPoint, secondPoint };


            Path3D firstPath = new Path3D(firstPoints);
            Path3D secondPath =  new Path3D(secondPoints);
            Path3D thirdPath = new Path3D(thirdPoints);
            List<Path3D> paths = new List<Path3D>() { firstPath ,secondPath ,thirdPath};
            List<Path3D> pathsFromFile = new List<Path3D>();

            string fileLocation = "test.txt";

            Storage.SaveToFile(paths, fileLocation);
            Storage.LoadFromFile(pathsFromFile, fileLocation);

            foreach (var path in pathsFromFile)
            {
                Console.WriteLine(path);                
            }
        }
    }
}
