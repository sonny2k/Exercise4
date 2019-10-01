using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4b
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] A = new int[10];
            Input(A);
            IsContains5(A);
            IsContains5Or6(A);
            IsContains5And6(A);
            Counts5(A);
            Counts5Or6(A);
            SumArray(A);
        }

        public static void Input(int[] A)
        {
            for (int i = 0; i <A.Length; i++)
            {
                Console.Write("A[" + i + "]=");
                A[i] = int.Parse(Console.ReadLine());
            }
        }

        public static bool IsContains5(int[] A)
        {
            int flag = 0;
            for (int i = 0; i < A.Length; i++)
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

        public static bool IsContains5Or6(int[] A)
        {
            int flag = 0;
            for (int i = 0; i < A.Length; i++)
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

        public static bool IsContains5And6(int[] A)
        {
            int flag = 0;
            for (int i = 0; i < A.Length; i++)
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

        public static int Counts5(int[] A)
        {
            int c = 0;
            int flag = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 5)
                    flag++;
            }
            if (flag > 0)
                Console.WriteLine("there is/are " + flag + " number 5 in this array.");
                return flag;
        }

        public static int Counts5Or6(int[] A)
        {
            int flag = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 5 || A[i] == 6)
                    flag++;
            }
            if (flag > 0)
                Console.WriteLine("there is/are " + flag + " number 5 or 6 in this array.");
                return flag;
        }

        public static int SumArray(int[] A)
        {
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
                sum += A[i];
            Console.WriteLine("Summary of this array is: " + sum);
            return sum;
        }
    }
}
