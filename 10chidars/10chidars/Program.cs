using System.Drawing;
using System.Numerics;
using System.Runtime.Intrinsics;

namespace _10chidars
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Car car2 = new Car();
            car2.color = "red";
            car2.weight = 900;
            car2.Brend = "Chevrolet";
            car2.speed = 160;

            Console.WriteLine(car2.color);



            Car car1 = new Car()
            {
                model = "Damas",
                Brend = "Chevroletr",
                color = "blue",
                speed = 160,
                weight = 800
            };

            Console.WriteLine(car1.Brend);
             
        }


    }
}

