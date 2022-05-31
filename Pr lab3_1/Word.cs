using System;
using System.Collections.Generic;
using System.Text;

namespace Pr_lab3_1
{
    class Word 
    {
        public string s { get; set; }

        public Word()
        {
            this.s = s;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Word p = obj as Word;
            if (p == null) return false;
            else return p.s == this.s;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public string Supplement()
        {
            Console.WriteLine("Доповнити текст");
            s += Console.ReadLine();
            return s;
        }
    }
}
