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
                    Console.Write(" Pasport seriya kiriting :");
                    string yosh = Console.ReadLine();
                    CreateName(yosh);
                }
                else if (num == 2)
                {
                    Console.Write("Pasport seriyani ochirish :");
                    string yosh = Console.ReadLine();
                    DeleteName(yosh);
                }
                else if (num == 3)
                {
                    Console.Write("Eski Pasport seriya kiriting :");
                    string yosh = Console.ReadLine();

                    Console.Write("Yangi Pasport seriya kiriting :");
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
            if (name.Length == 9 && char.IsUpper(name[0]) && char.IsUpper(name[1]))
            {
                Names.Add(name);
            }
            else
            {
                Console.Write("Xato kiritdingiz");
            }

        }

        static void DeleteName(string name)
        {
            Names.Remove(name);
        }

        static void UbdadeName(string name, string newname)
        {


            if (name.Length == 9 && newname.Length == 9 && char.IsUpper(name[0])
                && char.IsUpper(name[1]) && char.IsUpper(newname[0]) && char.IsUpper(newname[1]))
            {
                int index = Names.IndexOf(newname);
                if (index != -1)
                {
                    Names[index] = newname;
                } 
            }
            else
            {
                Console.Write("Xato kiritdingiz");
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
