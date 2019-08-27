using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace ConvexHull
{
    public sealed class ConvexHullTest
    {
        public static void Main(string[] args)
        {
            String line;
            IList<Point> points= new List<Point>();
            Console.WriteLine("--------Convex Hull Program-------");
            Console.WriteLine("----Reading the file from input.txt----");
            StreamReader sr = new StreamReader(@"input.txt");
            line = sr.ReadLine();
            while (line != null)
            {
                //write the line to console window
                Console.WriteLine(line);
                var point = line.Split(' ');
                double x = Convert.ToDouble(point[0]);
                double y = Convert.ToDouble(point[1]);
                Point p = new Point(x, y);
                points.Add(p);
                line = sr.ReadLine();
            }
            sr.Close();
           
            IList<Point> ConvexHullPoints = ConvexHull.MakeHull(points);
            Console.WriteLine("--------The points that belongs to Convex hull-------");
            //Writing output to the output.txt
            StreamWriter sw = new StreamWriter(@"output.txt");
            foreach (var item in ConvexHullPoints)
            {
                sw.WriteLine(item.x + " " + item.y);
                Console.WriteLine(item.x + " " + item.y);
            }
            sw.Close();
            Console.WriteLine("--------Convex Hull-------");
            Console.ReadLine();
        }
    }
}
