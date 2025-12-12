namespace _6сршвфкы
{
    internal class Program
    {
        //1-misol
        //static float ADD(float x, float y)
        //{
        //    return x + y;
        //}

        //static float ADD(float x, float y, float z)
        //{
        //    return x + y + z;
        //}

        //static string ADD(string x, string y)
        //{
        //    return x + y;
        //}


        //2-misol

        //static int calculate(int x , int y)
        //   {
        //       return x + y; 
        //   }

        //   static int calculate(int x , int y, int z)
        //   {
        //       return x * y * z;
        //   }

        //3-misol
        static int multiplication(int x)
        {
            var sum = 1;
            for (int i = 1; i <= x; i++)
            {
                sum = sum * i;
            }
            return sum;
        }

        //static int multiplication(int x, int y)
        //{
        //    var sum = 1;
        //    for (int i = x; i <= y; i++)
        //    {
        //        sum = sum * i;
        //    }
        //    return sum;
        //}

        //static int multiplication(int x, int y, int z)
        //{
        //    var sum = y * x * z;
        //    return sum;

        //}



        static void Main(string[] args)
        {
            //Console.WriteLine(ADD("salom" ,  "salom" )); 1-misol

            //Console.WriteLine(calculate(1, 2, 3)); 2-misol

            //Console.WriteLine(multiplication(3, 5, 2)); 3-misol


        }


    }
}
