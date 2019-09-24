using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //VeNSao(10, '*'); Console.WriteLine("");
            //VeNSao(10, 'c'); Console.WriteLine("");
            //Vline(10, '*'); Console.WriteLine("");
            //Vline(10, 'c'); Console.WriteLine("");
            //Dline(10, 'c'); Console.WriteLine("");
            DrawTriangle(14, 'c'); Console.WriteLine("");
            //test(); Console.WriteLine("");
        }
        static void VeNSao(int n, char c){
            for (int i = 0; i <= n; i++)
            {
                Console.Write('*');
            }
        }
        static void Vline(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(c);
            }
        }
        static void Dline(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {   
                Vline(i,' ');
                Console.Write(" "+c);
            }
        }
        //line 1: n-1 spaces, 1 star
        //line 2: n-2 spaces, 1 star, 1 spaces, 1 star
        //line 3: n-3 spaces, 1 star, 3 spaces, 1 star
        //line 4: n-4 spaces, 1 star, 4 spaces, 1 star
        //last: 2n-1 stars
        static void DrawTriangle(int n, char c)
        {
                VeNSao(n-1,' ');
                VeNSao(1, '*');
                Console.WriteLine();
            int a = 2, b =1;
            for(int i =0; i<n-2;i++)
            {
                VeNSao(n - a, ' '); VeNSao(1, c);
                VeNSao(b, ' '); VeNSao(1, c);
                a = a + 1;
                b = b +2;
            }

                VeNSao(2*n - 1, '*');
                Console.WriteLine();
          

        }
        static void test()
        {
            
            int i, j,n;
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }              
        }
   
    }
}
