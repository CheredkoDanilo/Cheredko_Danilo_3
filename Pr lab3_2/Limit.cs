using System;
using System.Collections.Generic;
using System.Text;

namespace Pr_lab3_2
{
    class Limit : Credit
    {
        public int limit { get; set; }

        public Limit()
        {
            this.limit = limit;
        }

        public override string ToString()
        {
            return $"Банк {bank}, цільовий кредит {loan}, сума {sum}, комісія за кредитом {rate}% на місяць, можливість збільшення кредитної лінії на {limit}.";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Limit p = obj as Limit;
            if (p == null) return false;
            else return p.loan == this.loan && p.sum == this.sum && p.limit == this.limit;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
