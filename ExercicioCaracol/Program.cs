using System;
using System.Threading;

namespace ExercicioCaracol
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int x = 0;
            int y = 0;
            int x1 = 81;
            int y1 = 24;

            while (count < 2050)
            {
                for (int i = y; i < y + 1; i++)
                {
                    for (int j = x; j < x1; j++)
                    {
                        Console.SetCursorPosition(j, x);
                        Console.Write("X");
                        count++;
                        Thread.Sleep(50);
                    }
                }

                for (int i = y; i < y1; i++)
                {
                    Console.SetCursorPosition(x1, i);
                    Console.Write("X");
                    count++;
                    Thread.Sleep(50);
                }

                for (int i = y1; i < y1 + 1; i++)
                {
                    for (int j = x1; j >= x; j--)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write("X");
                        count++;
                        Thread.Sleep(50);
                    }
                }

                for (int i = y1; i >= y; i--)
                {
                    Console.SetCursorPosition(x, i);
                    Console.Write("X");
                    count++;
                    Thread.Sleep(50);
                }

                // Mudando os eixos x, y, x1, y1
                x++;
                y++;
                x1--;
                y1--;
            }
        }
    }
}
