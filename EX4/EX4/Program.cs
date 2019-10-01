using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4
{
    public class Program
    {
        public static void Main(string[] args)
        {
                Console.WriteLine("input n: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input y: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input t: ");
                double t = double.Parse(Console.ReadLine());
                IsOdd(n);
                IsEven(n);
                IsPrime(n);
                Square(n);
                Cube(n);
                Pow(x, y);
                Ceil(t);
                Floor(t);
                Rand1();
                Rand2();
                Factorial(n);
        }
        public static bool IsOdd( int n) 
        {
                if (n%2 != 0) 
                    return true;
                else 
                    return false;  
        }

        public static bool IsEven(int n)
        {
                 if (n % 2 == 0)
                    return true;
                 else
                    return false;  
        }

        public static bool IsPrime(int n)
        {
                int c = 0;
                for (int i = 1; i<=n; i++)
                {
                    if (n % i == 0)
                        c++;
                }
                if (c == 2)
                    return true;
                else 
                    return false;
        }

        public static int Square(int n)
        {
                return n * n;
        }

        public static int Cube (int n)
        {
                return n * n * n;
        }

        public static int Pow (int x, int y)
        {
                int result = 1;
                if (y > 0)
                {
                    for (int i = 1; i <= y; i++)
                        result = result * x;
                    return result;
                }
               
                else if (y < 0 && x > 0)
                {
                    return Pow(1/x,y);  
                }
                
               
                
        }

        public static int Abs(int n)
        {
               if (n<0)
                    return n * -1;
               else
                    return n;
        }  
  
        public static int Ceil(double t)
        {
            int p = (int)t;
            if (t < 0)
                if (p != t)
                    return p;
                return p;
            return p = p + 1; 
        }

        public static int Floor(double t)
        {
                int p = (int)t;
                if (t < 0)
                    if (p != t)
                        return p = p - 1;
                    return p;
                return p;
        }

        public static int Rand1()
        {
            Random i = new Random();
            int k = i.Next(0, 2 ^ 31 - 1);
            return k;
        }

        public static float Rand2()
        {
            Random j = new Random();
            float u = j.Next(0, 1);
            return u;
        }

        public static int Factorial(int n)
        {
            int F = 1;
            for (int i = 1; i <= n; i++)
                F = F * i;
            return F;     
        }

    }
}
