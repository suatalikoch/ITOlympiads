using Polynoms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynoms.Comparers
{
    internal class LetterComparer : IComparer<Variable>
    {
        public int Compare(Variable? x, Variable? y)
        {
            return x.Letter.CompareTo(y.Letter);
        }
    }
}
