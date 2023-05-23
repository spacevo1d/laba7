using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7.Figure_
{
    internal class Prism4 : Prism3
    {
        protected Point2d tochka2;
        public Point2d Tochka2
        {
            get { return tochka1; }
            set { tochka1 = value; }
        }
        public override double perim()
        {
            return centr.dlina(tochka) + tochka.dlina(tochka1) + tochka1.dlina(tochka2) + tochka2.dlina(centr);
        }
        public override double plosh()
        {
            Point2d a = centr, b = tochka, c = tochka1, d = tochka2;
            Prism3 q = new(a, b, c, height);
            Prism3 w = new(b, c, d, height);
            return q.plosh() + w.plosh();
        }
        public bool paral()
        {
            if (centr.dlina(tochka) == tochka1.dlina(tochka2) && centr.dlina(tochka2) == tochka.dlina(tochka1))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        public bool pram()
        {
            double a = centr.dlina(tochka1), b = tochka.dlina(tochka2);
            if (paral() == true)
            {
                if (a == b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool kub()
        {
            if (pram() == true)
            {
                if (centr.dlina(tochka) == centr.dlina(tochka2) && centr.dlina(tochka) == height)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public override void vvod()
        {
            base.vvod();
            Console.WriteLine("Введите х четвертой точки:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y четвертой точки:");
            double y = Convert.ToDouble(Console.ReadLine());
            tochka2 = new(x, y);
        }
        public override void vivod()
        {
            Console.WriteLine("Centr=" + centr.ToString() + " tochka=" + tochka.ToString() + "tochka1=" + tochka1.ToString() +"tochka2=" + tochka2.ToString()+ " height=" + height);
        }
        public override string ToString()
        {
            return "Centr=" + centr.ToString() + " tochka=" + tochka.ToString() + "tochka1=" + tochka1.ToString() + "tochka2=" + tochka2.ToString() + " height=" + height;
        }
        public Prism4(Point2d a, Point2d b, Point2d c,Point2d d, double h) : base(a, b, c, h)
        {
            tochka2 = new(d);
        }
        public Prism4() : base()
        {
            tochka2 = new(0, 0);
        }
        public Prism4(Prism4 obj) : base(obj)
        {
            tochka2 = obj.tochka2;
        }
    }
}
