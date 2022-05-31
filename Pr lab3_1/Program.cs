using System;

namespace Pr_lab3_1
{
    class Program 
    {
        static void Main(string[] args)
        {
            Text t = new Text();
            Console.WriteLine("Введіть заголовок");
            t.t = Console.ReadLine();
            Console.WriteLine("Введіть текст");
            t.s = Console.ReadLine();
            t.TitleInfo();
            t.TextInfo();
            t.Supplement();
            t.TextInfo();
            Console.ReadKey();
        }
    }
}
