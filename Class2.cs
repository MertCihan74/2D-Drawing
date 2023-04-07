using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing2D
{
    internal class Polygon      //polygon class
    {
        private Point2D Center;    
        private int length;             
        private int numberOfEdges;        
        private int Radius;


        public Point2D mCenter { set => Center = value; get => Center; }
        public int mLength { set => length = value; get => length; }
        public int mNofEdges { set => numberOfEdges = value; get => numberOfEdges; }

        public Polygon()
        {
            Center = new Point2D();

            Random rand2 = new Random();
            Radius = rand2.Next(1, 100);

            Center.x = rand2.Next(1, 100);
            Center.y = rand2.Next(1, 100);
            mLength = rand2.Next(3, 30);
        }


        public PointF[] calculateEdgeCoordinate()
        {
            PointF[] p1 = new PointF[numberOfEdges];
            float px, py;
            int j = 0;
            double delta = 360.0 / mNofEdges;

            for (int i = 0; i < mNofEdges; i++)
            {
                px = Convert.ToSingle(Center.x + length * Math.Cos(delta * i * Math.PI / 180));
                py = Convert.ToSingle(Center.y + length * Math.Sin(delta * i * Math.PI / 180));
                p1[i] = new PointF(px, py);
                j++;
            }
            return p1;
        }

        
    }
}
