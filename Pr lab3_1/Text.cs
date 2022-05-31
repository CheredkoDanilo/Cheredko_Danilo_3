using System;
using System.Collections.Generic;
using System.Text;

namespace Pr_lab3_1
{
    class Text : Sentence
    {
        public string t { get; set; }

        public Text()
        {
            this.t = t;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Text p = obj as Text;
            if (p == null) return false;
            else return p.t == this.t && p.s == this.s;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void TextInfo()
        {
            Console.WriteLine("Виводиться текст");
            Console.WriteLine(s);
        }

        public void TitleInfo()
        {
            Console.WriteLine("Виводиться заголовок");
            Console.WriteLine(t);
        }
    }
}
