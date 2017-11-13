using System;

class Program
{
    static void Main()
    {

            int a = 2;
            int b = P(a);
            Console.WriteLine("Number {0} is {1}", a, b);

        }

        static int P(int i)
        {
            if ((i % 2) == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }