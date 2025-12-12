namespace _6chidarsuygavaziyfa
{
    internal class Program
    {
        //1-misol
        //static float Add(float a, float b)
        //{
        //    return a + b;
        //}

        //static float Add(float a, float b, float c)
        //{
        //    return a + b + c; 
        //}

        //static string Add(string a, string b)
        //{
        //    return a + b; 
        //}

        //2-misol
        //static void Repeat(int a, int b)
        //{
        //    for(int i = 0; i < b;  i++)
        //    {
        //        Console.WriteLine(a);
        //    }
        //}

        //static void Repeat(int a )
        //{
        //    for (int i = 0; i < a; i++)
        //    {
        //        Console.WriteLine(a);
        //    }
        //}

        //3-misol
        //static int Calculate(int a, int b)
        //{
        //    return a + b;
        //}

        //static int Calculate (int a, int b, int c)
        //{
        //    return a * b * c;
        //}


        //4-misol
        //static int getAmountDigit(int a)
        //{
        //    var help = $"{a}";
        //    var sum = 0;

        //    for(int i = 0; i < help.Count(); i++)
        //    {
        //        sum++;
        //    }
        //    return sum;
        //}

        //static int getAmountDigit(string a)
        //{
        //    var sum = 0;
        //    for(int i = 0; i < a.Count(); i++)
        //    {
        //        if (char.IsDigit(a[i]))
        //        {
        //            sum++;
        //        }
        //    }

        //    return sum;
        //}



        //5-misol

        //static int findMax(int a, int b, int c)
        //{
        //   return Math.Max(Math.Max(a, b), c);
        //}

        //static int findMax(int a, int b, int c, int d)
        //{
        //    return Math.Max(Math.Max(a, b), Math.Max(c, d));

        //}

        //static int findMax(int a, int b, int c, int d, int f)
        //{
        //    return Math.Max(Math.Max(a, b), Math.Max(Math.Max(c, d), f ));

        //}

        //6-misol
        //static int Summa(int a, int b)
        //{
        //    if(a == b)
        //    {
        //        return a;
        //    }
        //    return a + Summa( a + 1, b );
        //}








        static void Main(string[] args)
        {
            //Console.WriteLine(Add(1f, 3.5f)); 1-misol
            //Repeat(3); 2-misol
            //Console.WriteLine(Calculate(1, 2, 3)); 3-misol
            //Console.WriteLine(getAmountDigit("salo00m")); 4-misol
            //Console.WriteLine(findMax(1, 2, 3));
            //Console.WriteLine(Summa(2, 4)); 6-misol

            //Console.WriteLine(Max(2, 3)); 10-misol
            //Console.WriteLine(Abs(-4));11-misol
            //Console.WriteLine(Isuppper('A'));12-misol
            //Console.WriteLine(Isdigit('0')); 14-misol
            //Console.WriteLine(Islower('s')); 15-misol
            //Console.WriteLine(Pow(2, 3)); 16-misol

        }

        //10-misol

        //static int Max(int a, int b)
        //{
        //    var big = a;

        //    if(big < b)
        //    {
        //        big = b;
        //    }
        //    return big;
        //}

        //11-misol
        //static int Abs(int a)
        //{
        //    if(a < 0)
        //    {
        //        return a + a * (-2);
        //    } 
        //    return a;
        //}

        //12-misol
        //static bool Isuppper(char belgi)
        //{
        //    if (belgi >= 'A' && belgi <= 'Z')
        //    {
        //         return true;
        //    }
        //    return false;
        //}

        //14-misol

        //static bool Isdigit(char belgi)
        //{
        //    if(belgi >= '0' &&  belgi <='9')
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //15-misol

        //static bool Islower(char belgi)
        //{
        //    if (belgi >= 'a' && belgi <= 'z')
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //16-misol

        //static int Pow(int son, int daraja)
        //{
        //    var natija = 1;

        //    for(var i = 1; i <= daraja; i++)
        //    {
        //        natija = natija * son;
        //    }
        //    return natija;
            
        //}





    }
}
