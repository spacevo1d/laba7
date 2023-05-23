using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
{
    internal class Point2d
    {
        public double x;
        public double y;
        public Point2d(double x=0, double y=0)
        {
            this.x = x;
            this.y = y;
        }
        public Point2d(Point2d obj)
        {
            x = obj.x;
            y = obj.y;
        }
        public  void vvod()
        {
            Console.WriteLine("Введите х:");
            x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y:");
            y = Convert.ToDouble(Console.ReadLine());
        }
        public void vivod()
        {
            Console.WriteLine($"({x},{y})");
        }
        public override string ToString()
        {
            return $"({x},{y})";
        }
        virtual public double dlina(Point2d a)
        {
            return Math.Sqrt((x-a.x)*(x-a.x)+(y-a.y)*(y-a.y));
        }
        static public double dlina(Point2d a,Point2d b)
        {
            return Math.Sqrt((b.x - a.x) * (b.x - a.x) + (b.y - a.y) * (b.y - a.y));
        }
    }
}
