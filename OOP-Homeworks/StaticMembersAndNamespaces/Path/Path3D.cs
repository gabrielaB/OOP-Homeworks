using System;
using System.Collections.Generic;
using System.Reflection;

namespace Path
{
    using Point3D;
   public class Path3D
    {
       public Path3D(ICollection<Point3D> points)
       {
           this.Points = points;
       }
       public ICollection<Point3D> Points { get; set; }

       public override string ToString()
       {
            string output = "Path: " + Environment.NewLine;
            foreach (var point in this.Points)
            {
                output += point + Environment.NewLine;
            }

            return output;
        }
    }
}
