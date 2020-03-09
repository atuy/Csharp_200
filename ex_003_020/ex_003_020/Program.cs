using System;

namespace ex_003_020
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  005
             */

            //string a = "hello";
            //string b = "h";

            //b = b + "ello";

            //Console.WriteLine(a == b);
            //Console.WriteLine("b = " + b);

            //int x = 10;
            //string c = b + "!" + " " + x;
            //Console.WriteLine("c = " + c);


            /*
             *  006
             */

            //int i;
            //double x;

            //i = 5;
            //x = 3.141592;
            //Console.WriteLine("i = " + i + ", x =" + x);

            //x = i;
            //i = (int)x;
            //Console.WriteLine("i = " + i + ", x =" + x);


            /*
             *  007
             */

            //bool b = true;
            //char c = 'a';
            //decimal d = 1.234m;
            //double e = 1.23456789;
            //float f = 1.23456789f;
            //int i = 1234;
            //string s = "hello";

            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            //Console.WriteLine(f);
            //Console.WriteLine(i);
            //Console.WriteLine(s);

            /*
             *  008
             */

            //Console.WriteLine("10 이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7);

            //string primes;
            //primes = String.Format("10 이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7);
            //Console.WriteLine(primes);

            /*
            *  009
            */

            //int v1 = 100;
            //double v2 = 1.2345;

            //Console.WriteLine(v1.ToString() + "," + v2.ToString());
            //Console.WriteLine("v1 = " + v1 + ", v2 = " + v2);
            //Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2);
            //Console.WriteLine($"v1 = {v1}, v2 = {v2}");


            /*
             *  010
             */

            Console.WriteLine("Standard Numberic Format Specifiers");

            Console.WriteLine(
                "(C)          {0:C}\n" +
                "(D)          {0:D}\n" +
                "(E)          {1:E}\n" +
                "(F)          {1:F}\n" +
                "(G)          {0:G}\n" +
                "(N)          {0:N}\n" +
                "(P)          {1:P}\n" +
                "(R)          {1:R}\n" +
                "(X)          {0:X}\n",
                -123456789, -1234.5678F
                );
        }
    }
}
