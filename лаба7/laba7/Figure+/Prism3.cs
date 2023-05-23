using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
{
    internal class Prism3 : Cilindr
    {
        protected Point2d tochka1;
        public Point2d Tochka1
        {
            get { return tochka1; }
            set { tochka1 = value; }
        }
        override public double perim()
        {
            return centr.dlina(tochka) + tochka.dlina(tochka1) + tochka1.dlina(centr);
        }
        public override double plosh()
        {
            double a = perim() / 2;
            return Math.Sqrt(a * (a - centr.dlina(tochka)) * (a - centr.dlina(tochka1)) * (a - tochka.dlina(tochka1)));
        }
        protected double plosh1()
        {
            double a = perim() / 2;
            return Math.Sqrt(a * (a - centr.dlina(tochka)) * (a - centr.dlina(tochka1)) * a - tochka.dlina(tochka));
        }
        public Prism3(Point2d a, Point2d b,Point2d c,double h):base(a,b,h)
        {
            tochka1 = new(c);
        }
        public Prism3():base()
        {
            tochka1 = new Point2d(0, 0);
        }
        public Prism3(Prism3 obj):base(obj)
        {
            tochka1 = obj.tochka1;
        }
        public override void vvod()
        {
            base.vvod();
            Console.WriteLine("Введите х третей точки:");
            tochka1.x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y третей точки:");
            tochka1.y = Convert.ToDouble(Console.ReadLine());
        }
        public override void vivod()
        {
            Console.WriteLine("Centr=" + centr.ToString() + " tochka=" + tochka.ToString() +"tochka1=" + tochka1.ToString() +" height=" + height);
        }
        public override string ToString()
        {
            return "Centr=" + centr.ToString() + " tochka=" + tochka.ToString() + "tochka1=" + tochka1.ToString() + " height=" + height;
        }
    }
}

