namespace _4darsuyvaziyfasi
{
    internal class Program
    {
        //1-misol
        //static int natija(int a, int b)
        //{
        //    return a + b;
        //}

        //2-misol
        //static string natija (string text)
        //{
        //    var natija = text.Replace("x", "y" );
        //    var natija2 = natija.Replace("y", "z"); 
        //    return natija  ;

        //}

        //3-misol
        //static int summ( string text)
        //{
        //    var natija = 0;

        // for (int i = 0; i < text.Length; i++)
        //    {
        //        if(char.IsLower(text[i]))
        //        {
        //            natija++;
        //        }
        //    }
        //    return natija;
        //}

        //4-misol

        //static int toqson (int a, int b)
        //{
        //    var natija = 0;
        //    if(a < b)
        //    for(int i = a ; i < b; i++)
        //    {
        //          if(i % 2 != 0)
        //            {
        //                natija++;
        //            }
        //    }
        //    return natija; 
        //}

        //5-misol

        //static int son (int a)
        //{
        //    var summ = 0;
        //    var text = $"{a}";

        //    for(var i = 0; i < text.Length; i++)
        //    {
        //        summ++;
        //    }
        //    return summ; 
        //}

        //6-misol

        //static bool tekshir (string text)
        //{

        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        if (char.IsDigit(text[i]))
        //        {

        //            return true;
        //        }

        //    }
        //    return false;
        //}

        //7-misol

        //static string teskari(string text)
        //{
        //    var natija = string.Empty;

        //    for (int i = text.Length - 1; i >= 0; i--)
        //    {
        //        natija += text[i];
        //    }
        //    return natija;

        //}

        //8-misol

        //static int tekshir(string satr)
        //{
        //    int summ = 0;
        //    for (int i = 0; i < satr.Length; i++)
        //    {
        //        if (char.IsWhiteSpace(satr[i]))
        //        {
        //            summ++;
        //        }

        //    }
        //    return summ;
        //}

        //9-misol
        //static string otkaz(string text)
        //{
        //    var natija = string.Empty;

        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        natija = natija + char.ToUpper(text[i]); ;
        //    }
        //    return natija;
        //}

        //10-misol
        //static string text(string satr)
        //{
        //    string natija = string.Empty;

        //    for (int i = 0; i < satr.Length; i++)
        //    {
        //        if (char.IsLower(satr[i]))
        //        {


        //            natija = natija + "*";

        //        }
        //        else
        //        {
        //            natija = natija + satr[i];
        //        }


        //    }
        //    return natija;
        //}

        //11-misol
        //static string name(string text)
        //{
        //    var natija = "Hello " + text;
        //    return natija;
        //}

        //12-misol

        //static string text (string satr)
        //{
        //    var natija = satr.Substring(satr.Length - 2);

        //    return natija + natija + natija;

        //}

        //13-misol

        //static string text(string satr)
        //{
        //    var natija = satr.Substring(0, satr.Length / 2);
        //    return natija;
        //}

        //14-misol
        //static string text (string satr)
        //{
        //    var natija = satr.Substring(1, satr.Length - 2);
        //    return natija;
        //}

        //15-misol
        //static string text (string satr1, string satr2)
        //{
        //    var natija = string.Empty;
        //    if(satr1.Length > satr2.Length)
        //    {
        //        natija = satr2 + satr1 + satr2;
        //    } else
        //    {
        //        natija = satr1 + satr2 + satr1;
        //    }
        //    return natija;
        //}

        //16-misol
        //static string text (string satr)
        //{
        //    var oxir = satr [satr.Length - 1];
        //    var oldin = satr [satr.Length - 2];
        //    var matn = satr.Substring (0, satr.Length - 2);
        //    return matn + oxir + oldin;
        //}

        //17-misol
        //static string text(string satr)
        //{
        //    var sum = string.Empty;
        //    var blue = "blue";
        //    var red = "red";

        //    for (int i = 0; i < satr.Length; i++)
        //    {
        //        sum += satr[i];
        //        if (sum == blue || sum == red)
        //        {
        //            return sum;
        //        }

        //    }
        //    return sum;
        //}

        ////18-misol
        //static string dbtext (string text1, string text2)
        //{
        //    var natija = string.Empty; 
        //    if(text1.Length == text2.Length)
        //    {
        //        natija = text1 + text2;
        //    }
        //    else
        //    {
        //        var bir = text1.Remove(0, text1.Length - text2.Length);
        //        natija = bir + text2;
        //    }
        //    return natija;

        //}

        //static string text(string satr)
        //{
        //    var natija = string.Empty;
        //    for (int i = 0; i < satr.Length; i++)
        //    {
        //        if (char.IsLetter(satr[i]))
        //        {
        //            natija += satr[i];

        //        }
        //    }
        //    return natija;
        //}

        //19-misol
        //static string text (string s1 , string s2, int N1, int N2)
        //{
        //    var bir = s1.Substring(0, N1);
        //    var ikki = s2.Substring(s2.Length - N2);
        //    return bir + ikki;
        //}

        //20-misol
        //static string text(char C, string S)
        //{
        //    var newtext = string.Empty;
        //    for (int i = 0; i < S.Length; i++)
        //    {
        //        if (S[i] == C)
        //        {
        //            newtext = newtext + C + C;
        //        }
        //        else
        //        {
        //            newtext = newtext + S[i];
        //        }
        //    }
        //    return newtext;
        //}

        //21-misol
        //static string text(char C, string S1, string S2)
        //{
        //    var newtext = string.Empty;
        //    for (int i = 0; i < S1.Length; i++)
        //    {
        //        if (S1[i] == C)
        //        {
        //            newtext = newtext + S2;
        //        }
        //        else
        //        {
        //            newtext = newtext + S1[i];
        //        }
        //    }
        //    return newtext;
        //}

    





        static void Main(string[] args)
        {







            ////1-misol
            //Console.Write("n ni kiriting: ");
            //int n = int.Parse(Console.ReadLine());

            //int x = 1;

            //while(x < n)
            //{
            //    x = x * 3;
            //}

            //if (x == n)
            //{
            //    Console.WriteLine("ha");
            //}
            //else
            //{
            //    Console.WriteLine("yoq");
            //}

            //2-misol

            Console.Write("List lengthni kiriting : ");
            var n = int.Parse(Console.ReadLine());

            List<int> ints = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("List elementlarini kiriting :");
                var num = int.Parse(Console.ReadLine());
                ints.Add(num);
            }




        }
    }
}
