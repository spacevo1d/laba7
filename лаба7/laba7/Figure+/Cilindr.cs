using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
{
    internal class Cilindr
    {
        protected Point2d centr;
        protected Point2d tochka;
        protected double height;
        public Point2d Centr
        {
            get { return centr; }
            set { centr = value; }
        }
        public Point2d Tochka
        {
            get { return tochka; }
            set { tochka = value; }
        }
        public double Height { get { return height; } set { height = value; } }
        public Cilindr(Point2d centr, Point2d tochka, double height=0)
        {
            this.centr = new(centr);
            this.tochka = new(tochka);
            this.height = height;
        }
        public Cilindr(Cilindr obj)
        {
            centr = obj.centr;
            tochka = obj.tochka;
            height = obj.height;
        }
        public Cilindr()
        {
            centr = new Point2d(0, 0);
            tochka = new Point2d(0, 0);
            height = 0;
        }
        public override string ToString()
        {
            return "Centr=" + centr.ToString()+" tochka="+tochka.ToString()+" height="+height;
        }
        public virtual void vvod()
        {
            Console.WriteLine("Введите х первой точки:");
            centr.x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y первой точки:");
            centr.y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите х второй точки:");
            tochka.x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y второй точки:");
            tochka.y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите height");
            height = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void vivod()
        {
            Console.WriteLine("Centr=" + centr.ToString() + " tochka=" + tochka.ToString() + " height=" + height);
        }
        virtual public double plosh()
        {
            return Math.PI*Math.Pow(centr.dlina(tochka),2);
        }
        virtual public double perim()
        {
            return 2 * Math.PI * centr.dlina(tochka);
        }
        public double V()
        {
            return plosh() * height;
        }
        public double ploshbok()
        {
            return height * perim();
        }
    }
}
