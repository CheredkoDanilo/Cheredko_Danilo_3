using System;
using System.Collections.Generic;
using System.Text;

namespace Pr_lab3_1
{
    class Sentence : Word
    {
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Sentence p = obj as Sentence;
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
    }
}
