internal class Program
{
    private static void Main(string[] args)
    {
        int n = 5;
        Pattern1(n);
        Console.WriteLine();
        Pattern2(n);
        Console.WriteLine();
        Pattern3(n);
        Console.WriteLine();
        Pattern4(n);
        Console.WriteLine();
        Pattern5(n);
        Console.WriteLine();
        Pattern6(n);
        Console.WriteLine();
        Pattern7(n);
        Console.WriteLine();
        Pattern8(n);
        Console.WriteLine();
        Pattern9(n);
        Console.WriteLine();
        Pattern10(n);
        Console.WriteLine();
        Pattern11(n);
        Console.WriteLine();
        Pattern12(n);
        Console.WriteLine();
        Pattern13(n);
        Console.WriteLine();
        Pattern21(n);

        Console.ReadKey();
    }

    private static void Pattern21(int n)
    {
        /*
         * *****
         * *   *
         * *   *
         * *   *
         * *****
         */
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i > 0 && i < n - 1)
                {
                    if (j == 0 || j == n - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                else
                {
                    Console.Write("*");
                }

            }
            Console.WriteLine();
        }
    }
    private static void Pattern13(int n)
    {
        /*
         * 1
         * 2 3
         * 4 5 6
         * 7 8 9 10
         * 11 12 13 14 15
         */

        int k = 1;
        for (int i = 0; i < n; i++)
        {

            for (int j = 0; j <= i; j++)
            {
                Console.Write(k + " ");
                k++;
            }
            Console.WriteLine();
        }
    }

    private static void Pattern12(int n)
    {
        /*
         * 1      1
         * 12    21
         * 123  321
         * 12344321
         
         */

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(j + 1);
            }

            for (int k = 1; k <= 2 * (n - i - 1); k++)
            {
                Console.Write(" ");
            }

            for (int j = i; j >= 0; j--)
            {
                Console.Write(j + 1);
            }
            Console.WriteLine();
        }
    }
    private static void Pattern11(int n)
    {
        /*
                      1
                      0 1
                      1 0 1
                      0 1 0 1
                      1 0 1 0 1
                 */
        for (int i = 1; i <= n; i++)
        {
            int x = i;

            for (int j = 1; j <= i; j++)
            {
                if (x % 2 == 0)
                {
                    Console.Write(0);
                }
                else
                {
                    Console.Write(1);
                }
                x--;
            }
            Console.WriteLine();
        }
    }

    private static void Pattern10(int n)
    {

        /*
              *
              **
              ***
              ****
              *****
              ****
              ***
              **
              *
         */

        for (int i = 1; i <= 2 * n - 1; i++)
        {
            int stars = i;
            if (stars > n)
            {
                stars = 2 * n - i;
            }
            for (int j = 0; j < stars; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    private static void Pattern9(int n)
    {

        /*
              *
             *** 
            *****
           *******
          *********
          **********
           *******
            *****
             *** 
              *
         */

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < 2 * i + 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        for (int i = 4; i >= 0; i--)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < 2 * i + 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    private static void Pattern8(int n)
    {

        /*
          *********
           *******
            *****
             *** 
              *
         */

        for (int i = 4; i >= 0; i--)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < 2 * i + 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    private static void Pattern7(int n)
    {
        /*
              *
             *** 
            *****
           *******
          *********
         */
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < 2 * i + 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    private static void Pattern6(int n)
    {

        /*
              12345
              1234
              123
              12
              1
         */

        for (int i = n; i >= 1; i--)
        {
            for (int j = i; j >= 1; j--)
            {
                Console.Write((i - j) + 1);
            }
            Console.WriteLine();
        }
    }

    private static void Pattern5(int n)
    {

        /*
              *****
              ****
              ***
              **
              *
         */

        for (int i = n; i >= 1; i--)
        {
            for (int j = i; j >= 1; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    private static void Pattern4(int n)
    {
        /*
              1
              22
              333
              4444
              55555
         */

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(i + 1);
            }
            Console.WriteLine();
        }
    }

    private static void Pattern3(int n)
    {

        /*
              1
              12
              123
              1234
              12345
         */

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(j + 1);
            }
            Console.WriteLine();
        }
    }

    private static void Pattern2(int n)
    {
        /*
              *
              **
              ***
              ****
              *****
         */

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    private static void Pattern1(int n)
    {
        /*
             *****
             *****
             *****
             *****
             *****
        */
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
}