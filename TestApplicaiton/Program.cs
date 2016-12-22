using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicaiton
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Hello! Please Enter a number for fabo series : ");
            int n = int.Parse( Console.ReadLine());
            string series = FabonacciSeries(n);
            Console.WriteLine(series);
            Console.ReadKey();
        }
        static string FabonacciSeries(int n)
        {
            StringBuilder sb = new StringBuilder();

            int a = 1;
            int b = 1;
            int s = 0;
            sb.Append(a.ToString() + "," + b.ToString() + ",");
            for(int i=3;i<= n;i++)
            {
                s = a + b;
                a = b;
                b = s;
                sb.Append(s + ",");
            }

            return sb.ToString();
        }
    }
    
}
