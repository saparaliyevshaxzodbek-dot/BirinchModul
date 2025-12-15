namespace _8chidarsuygavaziyfa
{
    internal class Program
    {

        static List<string> Names = new List<string>();

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("1. Create");
                Console.WriteLine("2. Delet");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Read");

                Console.Write("Tanlang : ");

                int num = int.Parse(Console.ReadLine());

                if (num == 1)
                {
                    Console.Write("Ism kiriting :");
                    string yosh = Console.ReadLine();
                    CreateName(yosh);
                }
                else if (num == 2)
                {
                    Console.Write("Ismni ochirish :");
                    string yosh = Console.ReadLine();
                    DeleteName(yosh);
                }
                else if (num == 3)
                {
                    Console.Write("Eski Ismni kiriting :");
                    string yosh = Console.ReadLine();

                    Console.Write("Yangi Ismni kiriting :");
                    string yosh1 = Console.ReadLine();

                    UbdadeName(yosh, yosh1);

                }
                else if ((num == 4))
                {
                    ReadName();
                }
                Console.ReadKey();
                Console.Clear();
            }

        }

        static void CreateName(string name)
        {
            Names.Add(name);
        }

        static void DeleteName(string name)
        {
            Names.Remove(name);
        }

        static void UbdadeName(string name, string newname)
        {
            int index = Names.IndexOf(newname);
            if (index != -1)
            {
                Names[index] = newname;
            }

        }

        static void ReadName()
        {
            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
        }


    }
}