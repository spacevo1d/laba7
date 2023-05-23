using laba7;
using laba7.Figure_;
// static double sum(Worker[] arr)
//{
//    double sum = 0;
//    for(int i = 0; i < arr.Length; i++)
//    {
//        sum += arr[i].chistiye_dengi();
//    }
//    return sum;
//}
//static double sumNalog(Worker[] arr)
//{
//    double sum = 0;
//    for(int i=0; i < arr.Length; i++)
//    {
//        sum += arr[i].nalog();
//    }
//    return sum;
//}
//static double maxsum(Worker[] arr)
//{
//    double max = -1;
//    for(int j = 0; j < arr.Length; j++)
//    {
//        if (max < arr[j].chistiye_dengi())
//        {
//            max = arr[j].chistiye_dengi();
//        }
//    }
//    return max;
//}
//Worker[] arr=new Worker[4];
//arr[0]=new Worker("Гоша","Гошев",System.DateTime.Now,"м",12345,0.30);
//arr[1]=new Worker("Иван", "Гошев", System.DateTime.Now, "м", 54321, 0.03);
//arr[2] = new Worker1("Петя", "Петев", System.DateTime.Now, "м", 12345, 0.30,5);
//arr[3] = new Worker1("Коля", "Колев", System.DateTime.Now, "м", 54321, 0.03,9);
//for(int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}
//Console.WriteLine(sum(arr));
//Console.WriteLine(sumNalog(arr));
//Console.WriteLine(maxsum(arr));




//Cilindr a=new Cilindr();
//a.Centr=new Point2d(0, 0);
//a.Tochka=new Point2d(1, 0);
//a.Height = 4;
//Console.WriteLine(a.plosh());
//Console.WriteLine(a.perim());
//Console.WriteLine(a.ploshbok());
//Console.WriteLine(a.V());
//Prism3 b=new Prism3();
//b.Centr=new Point2d(0, 0);
//b.Tochka=new Point2d(1, 0);
//b.Tochka1=new Point2d(1, 1);
//b.Height = 2;
//Console.WriteLine(b.plosh());
//Console.WriteLine(b.perim());
//Console.WriteLine(b.ploshbok());
//Console.WriteLine(b.V());

//Point2d a = new(0, 0), b = new(1, 0), c = new(1, 1), d = new(0, 1);
//Prism4 a1=new Prism4(a,b,c,d,1);
////a.vvod();
//Console.WriteLine(a1);
//a1.vivod();
//Console.WriteLine(a1.kub() + "," + a1.paral() + "," + a1.pram());
//Prism4 a2=new Prism4(a1.Centr,a1.Tochka,a1.Tochka1,a1.Tochka2,1);
//a2.Tochka1 = new(2, 2);
//Console.WriteLine(a1);
//Console.WriteLine(a2);