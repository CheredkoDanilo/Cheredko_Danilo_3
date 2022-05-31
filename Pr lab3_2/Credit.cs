using System;
using System.Collections.Generic;
using System.Text;

namespace Pr_lab3_2
{
    class Credit 
    {
        public string bank { get; set; }
        public string loan { get; set; }
        public int sum { get; set; }
        public double rate { get; set; }

        public Credit()
        {
            this.bank = bank;
            this.loan = loan;
            this.sum = sum;
            this.rate = rate;
        }

        public override string ToString()
        {
            return $"Банк {bank} цільовий кредит {loan} сума {sum} комісія за кредитом {rate}% на місяць.";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Credit p = obj as Credit;
            if (p == null) return false;
            else return p.loan == this.loan && p.sum == this.sum;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
