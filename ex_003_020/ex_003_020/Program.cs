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

            //Console.WriteLine("Standard Numberic Format Specifiers");

            //Console.WriteLine(
            //    "(C)          {0:C}\n" +
            //    "(D)          {0:D}\n" +
            //    "(E)          {1:E}\n" +
            //    "(F)          {1:F}\n" +
            //    "(G)          {0:G}\n" +
            //    "(N)          {0:N}\n" +
            //    "(P)          {1:P}\n" +
            //    "(R)          {1:R}\n" +
            //    "(X)          {0:X}\n",
            //    -123456789, -1234.5678F
            //    );


            /*
             *  011
             */

            //Console.WriteLine("{0:N2}", 1234.5678);
            //Console.WriteLine("{0:D8}", 1234);
            //Console.WriteLine("{0:F3}", 1324.56);
            //Console.WriteLine("{0,8}", 1324);
            //Console.WriteLine("{0,-8}", 1324);

            //string s;

            //s = string.Format("{0:N2}", 1234.5678);
            //Console.WriteLine(s);

            //s = string.Format("{0:D8}", 1234);
            //Console.WriteLine(s);

            //s = string.Format("{0:F3}", 1324.56);
            //Console.WriteLine(s);

            //Console.WriteLine(1234.5678.ToString("N2"));
            //Console.WriteLine(1234.ToString("D8"));
            //Console.WriteLine(1234.56.ToString("F3"));

            //Console.WriteLine("{0:#.##}", 1234.5678);
            //Console.WriteLine("{0:0,0.00}", 1234.5678);
            //Console.WriteLine("{0:#, #.##}", 1234.5678);
            //Console.WriteLine("{0:00000.00}", 1234.5678);

            //Console.WriteLine("{0:#, #.##;(#,#.##);zero}", 1234.5678);
            //Console.WriteLine("{0:#, #.##;(#,#.##);zero}", -1234.5678);
            //Console.WriteLine("{0:#, #.##;(#,#.##);zero}", 0);



            /*
             *  012
             */

            //float fit = 1F / 3;
            //double dbl = 1D / 3;
            //decimal dcm = 1M / 3;

            //Console.WriteLine("float : {0},\ndouble : {1}\ndecimal : {2}", fit, dbl, dcm);
            //Console.WriteLine("float : {0}byte,\ndouble : {1}byte\ndecimal : {2}byte", sizeof(float), sizeof(double), sizeof(decimal));
            //Console.WriteLine("float : {0} ~ {1}", float.MinValue, float.MaxValue);
            //Console.WriteLine("double : {0} ~ {1}", double.MinValue, double.MaxValue);
            //Console.WriteLine("decimal : {0} ~ {1}", decimal.MinValue, decimal.MaxValue);


            /*
             *  013
             */

            //int num = 1234567890;
            //long num2 = num;

            //Console.WriteLine(num2);

            //double x = 1234.5;
            //int a;

            //a = (int)x;
            //Console.WriteLine(a);


            /*
             *  014
             */

            //string input;
            //int v;

            //Console.Write("1 int로 변환할 문자를 입력하시오 : ");
            //input = Console.ReadLine();
            //bool b = Int32.TryParse(input, out v);

            //if (!b)
            //    Console.WriteLine("{0}은 int 로 반환 될 수 없습니다\n", input);
            //else
            //    Console.WriteLine("{0}으로 반환 되었습니다", v);

            //Console.Write("2 double 로 변환할 문자를 입력하시오 : ");

            //input = Console.ReadLine();

            //try
            //{
            //    double m = Double.Parse(input);
            //    Console.WriteLine("{0}로 반환 되었습니다", m);

            //}
            //catch(FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            /*
             *  015
             */

            //int x, y;
            //Console.Write("첫 숫자를 입력하시오 : ");
            //x = Convert.ToInt32(Console.ReadLine());

            //Console.Write("두번째 숫자를 입력하시오 : ");
            //y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("{0} + {1} = {2}", x, y, x + y);

            //short v = short.MaxValue;
            //Console.WriteLine("\n\n2진수, 8진수 10진수 16진수로 출력하기");

            //int num = 2;
            //string s = Convert.ToString(v, num);
            //int i = Convert.ToInt32(s, num);
            //Console.WriteLine("i = {0}, {1,2}진수 = {2,16}", i, num, s);

            //num = 8;
            //s = Convert.ToString(v, num);
            //i = Convert.ToInt32(s, num);
            //Console.WriteLine("i = {0}, {1,2}진수 = {2,16}", i, num, s);

            //num = 10;
            //s = Convert.ToString(v, num);
            //i = Convert.ToInt32(s, num);
            //Console.WriteLine("i = {0}, {1,2}진수 = {2,16}", i, num, s);

            //num = 16;
            //s = Convert.ToString(v, num);
            //i = Convert.ToInt32(s, num);
            //Console.WriteLine("i = {0}, {1,2}진수 = {2,16}", i, num, s);


            /*
             *  016
             */

            //Console.WriteLine(3 + 4 * 5);
            //Console.WriteLine((3 + 4) * 5);
            //Console.WriteLine(3 * 4 / 5);
            //Console.WriteLine(4 / 5 * 3);

            //int a = 10, b = 20, c;
            //Console.WriteLine(c = a + b);


            /*
             *  017
             */

            //Console.WriteLine("정수의 계산");
            //Console.WriteLine(123 + 45);
            //Console.WriteLine(123 - 45);
            //Console.WriteLine(123 * 45);
            //Console.WriteLine(123 / 45);
            //Console.WriteLine(123 % 45);

            //Console.WriteLine("\n실수의 계산");
            //Console.WriteLine(123.45 + 67.89);
            //Console.WriteLine(123.45-67.89);
            //Console.WriteLine(13.45 / 67.89);
            //Console.WriteLine(123.45%67.89);


            /*
             *  018
             */

            //int x = 10, y = 0;
            //try
            //{
            //    Console.WriteLine(10.0 / 0);
            //    Console.WriteLine(x / y);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            /*
             *  019
             */

            //int x = int.MaxValue, y = 0;
            //checked
            //{
            //    try
            //    {
            //        y = x + 10;
            //    }

            //    catch(Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}
            //Console.WriteLine("int.MaxValue +10  = {0}", y);



            /*
             * 020
             */

            bool b;
            int x = 10, y = 20;

            b = x == y;
            Console.WriteLine("{0} == {1} : {2}", x, y, b);

            b = x > y;
            Console.WriteLine("{0} > {1} : {2}", x, y, b);

            b = x < y;
            Console.WriteLine("{0} < {1} : {2}", x, y, b);

            b = x >= y;
            Console.WriteLine("{0} >= {1} : {2}", x, y, b);

            b = x <= y;
            Console.WriteLine("{0} <= {1} : {2}", x, y, b);

            b = x != y;
            Console.WriteLine("{0} != {1} : {2}", x, y, b);



        }
    }
}
