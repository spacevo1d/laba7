using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace laba7
{
    internal class Worker:Person
    {
        public virtual double Oplata { get; set; }
        public double Premi { get; set; }
        public override void vvod()
        {
            base.vvod();
            Console.WriteLine("Введите оплату труда");
            Oplata=Convert.ToDouble(Console.ReadLine);
            Console.WriteLine("Введите примию");
            Premi = Convert.ToDouble(Console.ReadLine);
        }
        public override void vivod()
        {
            Console.WriteLine($" {Lastname} {Name} {gender} пола Дата рождения:{Date} оплатa труда:{Oplata} примия:{Premi} ");
        }
        public override string ToString()
        {
            return Lastname + " " + Name[0] + ". " + Gender + " пола" + " Возраст:" + Vozrast()+ " оплатa труда:"+Oplata+ " примия:" +Premi + " nalog:" + nalog() + " зарплата:"+chistiye_dengi();
        }
        public Worker(string name, string lastname, DateTime date, string gender,double oplata,double premi):base(name,lastname,date,gender)
        {
            Oplata = oplata;
            Premi = premi;
        }
        public Worker():base()
        {   
            Oplata = 0.0;
            Premi = 0.0;
        }
        public Worker(Worker obj):base(obj)
        {
            Oplata = obj.Oplata;
            Premi = obj.Premi;
        }
        public virtual double zarplata()
        {
            return Oplata + Oplata * Premi;
        }
        public double nalog()
        {
            return zarplata()*0.13;
        }
        public double chistiye_dengi()
        {
            return zarplata() - nalog();
        }
    }
}
