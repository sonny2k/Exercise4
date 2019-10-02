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
                Console.WriteLine("input X: ");
                int X = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("intput N: ");
                int N = Convert.ToInt32(Console.ReadLine());
                CalculateEquation(X, N);
                double result = CalculateEquation(X, N);
                Console.WriteLine("sinX = {0}", result);
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

        public static double Pow (int x, int y)
        {
                double result = 1;
                if (y > 0)
                {
                    for (int i = 1; i <= y; i++)
                        result = result * x;  
                } 
                else if (y < 0)
                {
                    y = y * -1;
                    for (int i = 1; i <= y; i++)
                    {
                        result = result * x;
                    }
                    result = 1 / result;
                }
                return result;
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
            {
                if (p == t) 
                {
                    return p;
                }
                else 
                {
                    return p; 
                }
                
            }
            else
            {
                if (p == t)
                {
                    return p; 
                }
                else
                {
                    return p = p + 1;
                }
            }
                
        }

        public static int Floor(double t)
        {
            int p = (int)t;
            if (t < 0)
            {
                if (p != t)
                {
                    return p = p - 1;
                }
                else
                {
                    return p;
                }

            }
            else
            {
                if (p == t)
                {
                    return p;
                }
                else
                {
                    return p;
                }
            }
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
            if (n > 0)
                for (int i = 1; i <= n; i++)
                    F = F * i;
            else if (n == 0)
                F = 1;
            else
                return 0;
            return F;     
        }

        public static double CalculateEquation(int X, int N)
        {
            return Pow(-1, N) * Pow(X, 2 * N + 1) / Factorial(2 * N + 1);
        }

    }
}
