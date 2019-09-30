using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input length: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            Input(A, n);
            IsContains5(A, n);
            IsContains5Or6(A, n);
            IsContains5And6(A, n);
            Counts5(A, n);
            Counts5Or6(A, n);
            SumArray(A, n);
        }

        static void Input(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[" + i + "]=");
                A[i] = int.Parse(Console.ReadLine());
            }
        }

        static bool IsContains5(int[] A, int n)
        {
            int flag = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] == 5)
                    flag++;
            }
            if (flag > 0)
            {
                Console.WriteLine("this array contains number 5!");
                return true;
            }
            else
            {
                Console.WriteLine("this array doesn't contain number 5!");
                return false;
            }
        }

        static bool IsContains5Or6(int[] A, int n)
        {
            int flag = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] == 5 || A[i] == 6)
                    flag++;
            }
            if (flag > 0)
            {
                Console.WriteLine("this array contains number 5 or 6!");
                return true;
            }
            else
            {
                Console.WriteLine("this array doesn't contain number 5 or 6!");
                return false;
            }
        }

        static bool IsContains5And6(int[] A, int n)
        {
            int flag = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] == 5 && A[i] == 6)
                    flag++;
            }
            if (flag > 0)
            {
                Console.WriteLine("this array contains number 5 and 6!");
                return true;
            }
            else
            {
                Console.WriteLine("this array doesn't contain number 5 and 6!");
                return false;
            }
        }

        static int Counts5(int[] A, int n)
        {
            int c = 0;
            int flag = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] == 5)
                    flag++;
            }
            if (flag > 0)
                Console.WriteLine("there is/are " + flag + " number 5 in this array.");
                return flag;
        }

        static int Counts5Or6(int[] A, int n)
        {
            int flag = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] == 5 || A[i] == 6)
                    flag++;
            }
            if (flag > 0)
                Console.WriteLine("there is/are " + flag + " number 5 or 6 in this array.");
                return flag;
        }

        static int SumArray(int[] A, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += A[i];
            Console.WriteLine("Summary of this array is: " + sum);
            return sum;
        }
    }
}
