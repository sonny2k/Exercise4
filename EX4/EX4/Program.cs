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
                IsOdd(n);
                IsEven(n);
                IsPrime(n);
                Square(n);
                Cube(n);
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
                for (int i = 1; i <n; i++)
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
    }
}
