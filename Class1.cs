using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing2D
{
    internal class Point2D
    {
        public float x, y;                                  //float type for x and y
        private int x1, y1;                                 //int type for x1 and y1
        public double angle1, angle2, dbx, dby, r, q;       //double types
        public Point2D()        //constructor with no parameter
        {
            Random rnd = new Random();
            int numx = rnd.Next(1, 100);        //generate random number between 1-100 for x
            int numy = rnd.Next(1, 100);        //generate random number between 1-100 for y
            x = Convert.ToSingle(numx);
            y = Convert.ToSingle(y);
            dbx = Convert.ToDouble(x);
            dby = Convert.ToDouble(y);
        }
        public int X1 { get => x1; set => x1 = value; }         //property for x1
        public int Y1 { get => y1; set => y1 = value; }         //property for y1

        public void printCoordinates()          //printing coordinates
        {
            System.Console.WriteLine("X IS : " + x);
            System.Console.WriteLine("Y IS : " + y);
        }
        public void calculatePolarCoordinates()     //calculating polar coordinates P(r,θ)
        {
            r = (x * x + y * y);
            r = Math.Sqrt(r);
            q = Math.Atan(dby / dbx) * 57.295;
        }
        public void calculateCartesianCoordinates()     //calculating cartesian coordinates
        {
            x1 = Convert.ToInt32(r * Math.Cos(q));
            y1 = Convert.ToInt32(r * Math.Sin(q));
        }
        public void printSphericalCoordinates()     //calculating spherical coordinates
        {
            angle1 = 90 - q;
            angle2 = 90;
            System.Console.WriteLine("( " + r + " , " + angle1 + " , " + angle2 + " )");
        }
    }
}
