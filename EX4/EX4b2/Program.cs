using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4b2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input H: ");
            int H = Convert.ToInt32(Console.ReadLine());
            a(H);
            Console.WriteLine();
            b(H);
            Console.WriteLine();
            c(H);
            Console.WriteLine("\n");
            d(H);
            Console.WriteLine("\n");
            e(H);
            Console.WriteLine("\n");
            f(H);
            Console.WriteLine("\n");
            g(H);
            Console.WriteLine("\n");
            h(H);
            Console.WriteLine("\n");
            i(H);
            Console.WriteLine("\n");
            j(H);
            
        }

        static void HLine(int H, char c)
        {
            for (int i = 0; i < H; i++)
            {
                Console.Write(c);
            }
        }

        static void a(int H)
        {
            for (int i = 0; i < H; i++)
                Console.WriteLine('i');
        }

        static void b(int H)
        {
            for (int i = 0; i < H; i++)
            {
                HLine(H, 'o');
                Console.WriteLine();
            }
        }

        static void c(int H)
        {
            HLine(H, 'o'); Console.WriteLine();
            for (int i = 0; i < H - 2; i++)
            {
                HLine(1, 'o'); HLine(H - 2, ' '); HLine(1, 'o'); Console.WriteLine();
            }
            HLine(H, 'o');
        }

        static void d(int H)
        {
            for (int i = 0; i < H - 1; i++)
            {
                HLine(1, 'u'); HLine(H - 2, ' '); HLine(1, 'u'); Console.WriteLine();
            }
            HLine(H, 'u');
        }

        static void e(int H)
        {
            HLine(1, 'v'); HLine(2*H - 3, ' '); HLine(1, 'v'); Console.WriteLine();
            int a = 1, b = 5;
            for (int i = 0; i < H-2; i++)
            {
                HLine(a, ' '); HLine(1, 'v'); HLine(2*H - b, ' '); HLine(1, 'v'); Console.WriteLine(); 
                a++; b = b + 2;
            }
            HLine(H - 1, ' '); HLine(1, 'v');
        }


        static void f(int H)
        {
            HLine(2*H-1, 'v'); Console.WriteLine();
            int a = 1, b = 5;
            for (int i = 0; i < H - 2; i++)
            {
                HLine(a, ' '); HLine(1, 'v'); HLine(2 * H - b, ' '); HLine(1, 'v'); Console.WriteLine();
                a++; b = b + 2;
            }
            HLine(H - 1, ' '); HLine(1, 'v');
        }

        static void g(int H)
        {
            HLine(H - 1, ' '); HLine(1, 'A'); Console.WriteLine();
            int a = 2, b = 1;
            for (int i = 0; i < H - 2; i++)
            {
                HLine(H - a, ' '); HLine(1, 'A'); a++;
                HLine(b, ' '); HLine(1, 'A'); Console.WriteLine(); b = b + 2;
            }
            HLine(2 * H - 1, 'A'); Console.WriteLine();
        }

        static void h(int H)
        {
            HLine(1, 'W'); HLine(2 * H - 3, ' '); HLine(1, 'W'); HLine(2 * H - 3, ' '); HLine(1, 'W'); Console.WriteLine();
            int a = 1, b = 5, c = 1;
            for (int i = 0; i < H - 2; i++)
            {
                HLine(a, ' '); HLine(1, 'W'); HLine(2 * H - b, ' '); HLine(1, 'W'); HLine(c, ' '); HLine(1, 'W'); HLine(2 * H - b, ' '); HLine(1, 'W'); Console.WriteLine();
                a++; b = b + 2; c = c + 2;
            }
            HLine(H - 1, ' '); HLine(1, 'W'); HLine(2 * H - 3, ' '); HLine(1, 'W');
        }

        static void i(int H)
        {
            HLine(H-1, ' '); HLine(1, 'A'); Console.WriteLine();
            int a = 2, b = 1;
            for (int i = 0; i < H/2 - 1; i++)
            {
                HLine(H - a, ' '); HLine(1, 'A');
                HLine(b, ' '); HLine(1, 'A'); Console.WriteLine(); a++; b = b + 2;
            }
            if (H%2==0)
            {
                HLine(H - a, ' '); HLine(H+1, 'A'); Console.WriteLine(); a++; b = b + 2;
            }
            else
            {
                HLine(H - a, ' '); HLine(H, 'A'); Console.WriteLine(); a++; b = b + 2;
            }
            
            for (int i = 0; i < H/2 - 1; i++)
            {
                HLine(H - a, ' '); HLine(1, 'A'); a++;
                HLine(b, ' '); HLine(1, 'A'); Console.WriteLine(); b = b + 2;
            }
        }

        static void j(int H)
        {
            HLine(1, 'x'); HLine(H-3, ' '); HLine(1, 'x'); Console.WriteLine();
            int a = 1, b = 5;
            for (int i = 0; i < H/2-2; i++ )
            {
                HLine(a, ' '); HLine(1, 'x'); HLine(H - b, ' '); HLine(1, 'x'); Console.WriteLine(); a++; b = b + 2;
            }
            if (H%2==0)
            {
                HLine((H - 3) / 2 + 1, ' '); HLine(1, 'x'); Console.WriteLine();
            }
            else
            {
                HLine((H - 3) / 2, ' '); HLine(1, 'x'); Console.WriteLine();
            }
           
            int c = 7, d = 1;
            for (int i = 0; i <H/2-2; i++)
            {
                HLine(H - c, ' '); HLine(1, 'x'); c++;
                HLine(d, ' '); HLine(1, 'x'); Console.WriteLine(); d = d + 2;
            }
            HLine(1, 'x'); HLine(H-3, ' '); HLine(1, 'x'); Console.WriteLine();
        }
    }
}
