using System;
using System.Collections.Generic;
using System.Text;

namespace Pr_lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Credit> c = new List<Credit>();
            List<Limit> l = new List<Limit>();
            c.Add(new Credit { bank = "Ощадбанк", loan = "Готивкою", rate = 1.5, sum = 1000000 });
            c.Add(new Credit { bank = "Приват", loan = "Готивкою", rate = 1.7, sum = 1000000 });
            c.Add(new Credit { bank = "Приват", loan = "Авто", rate = 1.7, sum = 1000000 });
            l.Add(new Limit { bank = "Приват", loan = "Готивкою", rate = 1.4, sum = 250000, limit = 100000 });
            l.Add(new Limit { bank = "Приват", loan = "Авто", rate = 1.6, sum = 500000, limit = 250000 });
            l.Add(new Limit { bank = "Ощадбанк", loan = "Авто", rate = 1.4, sum = 500000, limit = 250000 });
            Credit _c = new Credit();
            Limit _l = new Limit();
            Console.WriteLine("Введіть цільвий кредит");
            _c.loan = Console.ReadLine();
            Console.WriteLine("Введіть суму кредиту");
            _c.sum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть суму збільшення кредитної лінії");
            _l.limit = int.Parse(Console.ReadLine());
            Console.WriteLine(_c.Equals(c[0]));
            if (_l.limit == 0)
            {
                for (int i = 0; i < c.Count; i++)
                {
                    if (_c.Equals(c[i]) == true)
                    {
                        Console.WriteLine(c[i].ToString());
                    }
                }
            }
            for (int i = 0; i < l.Count; i++)
            {
                if (_l.Equals(l[i]) == true)
                {
                    Console.WriteLine(l[i].ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
