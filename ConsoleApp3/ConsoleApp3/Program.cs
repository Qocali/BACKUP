using System;
using System.Text;

namespace ConsoleApp3
{
     class Program
    {
       


        static void Main(string[] args)
        {
            int a=5,double b = 7;
            Console.WriteLine(a + b);
            Console.WriteLine(muqayise(15, 123));


        }
        public static string muqayise(int num1,int num2)
        {
            int a = (num1 / 10) % (num1 % 10);
            int b = (num2/ 10) % (num2 % 10);
            Console.WriteLine("a:{0} b:{1}",a,b);
            if (a > b)
            {
                return "a-nin qaligi daha boyukdu";
            }
            else if (a == b)
            {
                return "a-nin qaligi beraberdi b ye";
            }
            else
            {
                return "b-nin qaligi daha boyukdu";
            }
        }



    }
}
