using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
{
    internal class Worker1:Worker
    {
        public double Hours { get; set; }
        public override double Oplata { get ; set; }
        public override double zarplata()
        {
            return Oplata*Hours*(1+Premi);
        }
        public override void vvod()
        {
            base.vvod();
            Console.WriteLine("Введите кол-во часов:");
            Hours=Convert.ToDouble(Console.ReadLine());
        }
        public override void vivod()
        {
            Console.WriteLine($" {Lastname} {Name} {gender} пола Дата рождения:{Date} оплатa труда:{Oplata} примия:{Premi} кол-во часов:{Hours}");
        }
        public Worker1(){}
        public Worker1(string name, string lastname, DateTime date, string gender, double oplata, double premi,double hours):base(name,lastname,date,gender,oplata,premi)
        {
            Hours=hours;
        }
        public Worker1(Worker1 obj):base(obj)
        { 
            Hours = obj.Hours;
        }
        public override string ToString()
        {
            return Lastname + " " + Name[0] + ". " + Gender + " пола" + " Возраст:" + Vozrast() + " оплатa труда:" + Oplata + " примия:" + Premi+ " кол-во часов:"+Hours+" nalog:"+nalog() + " зарплата:" + chistiye_dengi();
        }
    }
}
