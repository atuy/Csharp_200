using System;

namespace ex_021_040
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 021
             */
            //bool re;
            //int a = 10, b = 20;
            //re = (a == b) || (a > 5);
            //Console.WriteLine("{0} || {1} = {2}", a == b, a > 5, re);

            //re = (a == b) && (a > 5);
            //Console.WriteLine("{0} && {1} = {2}", a == b, a > 5, re);

            //re = true ^ false;
            //Console.WriteLine("{0} ^ {1} = {2}", true, false, re);

            //re = !(a > b);
            //Console.WriteLine("{0} : {1}", a > b, re);


            /*
             * 022
             */

            //int a = 14, b = 11, re;

            //re = a | b;
            //Console.WriteLine("{0} | {1} = {2}", a, b, re);

            //re = a & b;
            //Console.WriteLine("{0} & {1} = {2}", a, b, re);

            //re = a ^ b;
            //Console.WriteLine("{0} ^ {1} = {2}", a, b, re);

            //re = ~a;
            //Console.WriteLine("~{0} = {1}", a, re);

            //re = a << 2;
            //Console.WriteLine("{0} << 2 {1}", a, re);

            //re = b >> 2;
            //Console.WriteLine("{0} >> 2 + {1}", b, re);


            /*
             * 023
             */

            //int input = Convert.ToInt32(Console.ReadLine());

            //string re = (input > 0) ? "양수입니다" : "음수입니다";
            //Console.WriteLine("{0}는 {1}", input, re);
            //Console.WriteLine("{0}는 {1}", input, (input % 2 == 0) ? "짝수입니다" : "홀수입니다");

            //for(int i =1; i<=50; i++)
            //{
            //    Console.Write("{0,3}{1}", i, i % 10 != 0 ? "" : "\n");
            //}


            /*
             * 024
             */

            //int a = 32;
            //Console.WriteLine(a += 2);
            //Console.WriteLine(a -= 8);
            //Console.WriteLine(a *= 3);
            //Console.WriteLine(a /= 2);
            //Console.WriteLine(a++);
            //Console.WriteLine(--a);


            /*
             * 025
             */

            //string s = "hello, world!";

            //Console.WriteLine(s.Length);
            //Console.WriteLine(s[8]);
            //Console.WriteLine(s.Insert(8, "C#"));
            //Console.WriteLine(s.PadLeft(20,'.'));
            //Console.WriteLine(s.PadRight(20, '.'));
            //Console.WriteLine(s.Remove(6));
            //Console.WriteLine(s.Remove(6,7));
            //Console.WriteLine(s.Replace('l','m'));
            //Console.WriteLine(s.ToLower());
            //Console.WriteLine(s.ToUpper());
            //Console.WriteLine('/' + s.Trim() + '/');
            //Console.WriteLine('/' + s.TrimStart() + '/');
            //Console.WriteLine('/' + s.TrimEnd() + '/');

            //string[] a = s.Split(',');
            //foreach(var i in a)
            //    Console.WriteLine('/' + i + '/');

            //char[] dest = new char[10];
            //Console.WriteLine("\n\n\n {0}", s);
            //s.CopyTo(7, dest, 0, 6);
            //Console.WriteLine(dest);
            //Console.WriteLine('/' + s.Substring(8) + '/');
            //Console.WriteLine('/' + s.Substring(8, 5) + '/');

            //Console.WriteLine(s.Contains("ll"));
            //Console.WriteLine(s.IndexOf('o'));
            //Console.WriteLine(s.LastIndexOf('o'));
            //Console.WriteLine(s.CompareTo("abc"));

            //Console.WriteLine(String.Concat("Hi ~" ,s));
            //Console.WriteLine(String.Compare("abc", s));

            //string[] val = { "apple", "orange", "grape", "pear" };
            //string re = String.Join(", ", val);
            //Console.WriteLine(re);



            /*
             * 026
             */

            //Console.Write("더하고자 하는 수를 입력하시오 : ");
            //string input = Console.ReadLine();
            //Console.WriteLine(input);

            //int sum = 0;
            //string[] v = input.Split();
            //foreach (var i in v)
            //    sum += int.Parse(i);

            //Console.WriteLine($"결과는 {sum} ");



            /*
             * 027
             */

            //string name = "bikang";
            //string date = DateTime.Today.ToShortDateString();

            //string strplus = "hello" + name + ". today is" + date;
            //Console.WriteLine(strplus);

            //string format = String.Format("hello {0}. TOday is {1}", name, date);
            //Console.WriteLine(format);

            //string inter = $"hello {name}. today {date}";
            //Console.WriteLine(inter);

            //string concat = String.Concat("hello", name, " today", date);
            //Console.WriteLine(concat);

            //string[] ani = { "mouse", "cow", "tiger", "rabbit" };
            //string s = String.Concat(ani);
            //Console.WriteLine(s);


            /*
             * 028
             */

            //string ani = "mouse, cow, tiger, rabbit";
            //string s1 = "cow";

            //bool b = ani.Contains(s1);
            //Console.WriteLine($"{s1} is in the string {ani}");

            //if(b)
            //{
            //    int index = ani.IndexOf(s1);
            //    if(index >= 0)
            //    {
            //        Console.WriteLine($"{s1} begins at index {index}");
            //    }
            //}


            /*
             * 029
             */

            string max = String.Format("0x{0:X} {0:E} {0:N}", Int64.MaxValue);
            Console.WriteLine(max);

            decimal exc = 1129.20m;
            string s = String.Format("현재 원달러 환율은 {0}입니다", exc);
            Console.WriteLine(s);

            s = String.Format("연재 원달러 화ㅣㄴ율은 {0:C2}입니다", exc);
            Console.WriteLine(s);

        }
    }
}
