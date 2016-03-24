using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path
{
    using  Point3D;
   public static class Storage
    {
       public static void SaveToFile(ICollection<Path3D> paths, string fileLocation)
       {
           string text = "";
           foreach (var path in paths)
           {
               text += path + Environment.NewLine;
           }
            File.WriteAllText(fileLocation, text);
        }

       public static void LoadFromFile(ICollection<Path3D> paths, string fileLocation)
       {
            string textFromFile = File.ReadAllText(fileLocation);
            string[] elements = textFromFile.Split('\n');
            List<Point3D> foundPoints = new List<Point3D>();

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == "Path: \r")
                {
                    foundPoints = new List<Point3D>();

                    for (int j = i + 1; j < elements.Length; j++)
                    {
                        //For all paths without the last path (because after the last there is no other string Path: )
                        if (elements[j] == "Path: \r")
                        {

                            Path3D currentPath = new Path3D(foundPoints);
                            paths.Add(currentPath);

                            break;
                        }

                        if (elements[j] != "\r" && elements[j] != "")
                        {
                            string[] pointInfo = elements[j].Split();

                            string xStr = pointInfo[0].Replace("X=", "");
                            string yStr = pointInfo[1].Replace("Y=", "");
                            string zStr = pointInfo[2].Replace("Z=", "");

                            double x = double.Parse(xStr);
                            double y = double.Parse(yStr);
                            double z = double.Parse(zStr);

                            Point3D currentPoint = new Point3D(x, y, z);
                            foundPoints.Add(currentPoint);

                        }
                    }
                }
            }

            //Add the last path to the path collection
            Path3D lastPath = new Path3D(foundPoints);
            paths.Add(lastPath);
        }
    }
}
