namespace _2_darsuygavaziyfasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intvalu;
            Console.WriteLine("uch honali son kiriting");
            intvalu = int.Parse(Console.ReadLine());

            int bir = intvalu % 10;
            int on = intvalu % 100;
            int on1 = (int) Math.Floor(on / 10.0);
            int yuz = (int)Math.Floor(intvalu / 100.0);

            Console.WriteLine(bir+ "" + on1 + "" + yuz);
        }
    }
}
