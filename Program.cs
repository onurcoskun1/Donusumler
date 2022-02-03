using System;

namespace Donusumler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Implicit Conversion*******");
            //  ##Düşük kapasiteli bir değişkenin kendinden daha yüksek kapasiteli bir değişkene atanması. Burada convert işlemini developer yerine, makine yapar

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine("i:" +i);

            string e = "Onur";
            char f='k';

            object g = e + f + d;
            Console.WriteLine("g:" + g);


            Console.WriteLine("*******Explicit Conversion*******");
            // C#'ın kendi kendine yapamadığı, convert ve parse işlemleri ile derleyiciye developer tarafından yaptırılan dönüşümler


            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" +y);

            int z=100;
            byte t=(byte)z;
            Console.WriteLine("z:" +z);

            float w = 10.3f;
            byte v= (byte)w; //byte'a çevirip, tam sayı değerini aldı. Böyle çevirilerde veri kaybı olabilir.
            Console.WriteLine("v:"+ v);


            Console.WriteLine("*******ToString Methodu*******");

            int xx=6;
            string yy= xx.ToString();
            Console.WriteLine("yy:"+yy);

            string zz= 12.5f.ToString();
            Console.WriteLine("zz:"+zz);

            Console.WriteLine("*******System.Convert Sınıfı*******");
            
            string s1 = "10", s2="20";
            int sayi1, sayi2;
            int Toplam;

            sayi1= Convert.ToInt32(s1);
            sayi2= Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:"+Toplam);

            Console.WriteLine("*******Parse Sınıfı*******");
            
            ParseMethod();
        }

        public static void ParseMethod()
        {
            string metin1= "10";
            string metin2= "10.3";
            int rakam1;
            double double1;

            rakam1=Int32.Parse(metin1);
            Console.WriteLine("rakam1:"+rakam1);
            double1= Double.Parse(metin2);
            Console.WriteLine("double1:"+double1);       

        }
    }
}
