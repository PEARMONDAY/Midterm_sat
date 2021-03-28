using System;

namespace sat_midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ข้อ1
            int n;
            Console.Write("Input a number n = ");
            n = int.Parse(Console.ReadLine());
           for (int i = 0; i < n; i++)
           {
                
                for (int j = n - i; j > 0 ; j--)
                {
                    Console.WriteLine("*");
                    j = j - 1;
                }
                i = i + 2;
           }
            */
            
            //ข้อ2
            int a;
            Console.Write("Input a = ");
            a = int.Parse(Console.ReadLine());
            int b;
            Console.Write("Input b =");
            b = int.Parse(Console.ReadLine());
            int x = a, y = b;
            bool z = false;
            while(z == false)
            {
                if (x == y)
                {
                    Console.WriteLine("Display x :" + x);
                    z = true;
                }
                else if (x < y)
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }
            }
            

        }
    }
}
