namespace _3chidars;

internal class Program
{
    static void Main(string[] args)
    {
        //for (int i = 100; i < 999; i++)
        //{
        //    int bir = i % 10;
        //    int on1 = i % 100;
        //    int on = (int)Math.Floor(on1 / 10.0);
        //    int yuz = (int)Math.Floor(i / 100.0);

        //    if(on % 2 != 0 && bir % 2 != 0 && yuz % 2 != 0)
        //    {
        //        Console.Write($"{i}, ");
        //    }
        //}

        int a = 3;
        int b = 5;

        int sana1 = 0;
        int sana2 = 0;


        for(int i = 0; i <= a; i++)
        {
            if(a % i == 0)
            {
                sana1++;
            }
        }

        for (int i = 0; i <= b; i++)
        {
            if (b % i == 0)
            {
                sana2++;
            }
        }

        if (sana1 == 0 && sana2 == 2)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }
        else
        {
           int sum1 = a * b;
            Console.WriteLine(sum1);
        }

    }
}
