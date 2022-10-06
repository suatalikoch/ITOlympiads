using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynoms.Models
{
    internal class Polynomial
    {
        private List<Monomial> _monomials;
        private int _remainder;

        public Polynomial(params Monomial[] monomials)
            : this(0, monomials)
        {
            Monomials = new List<Monomial>(monomials);
        }

        public Polynomial(int remainder, params Monomial[] monomials)
        {
            Remainder = remainder;
            Monomials = new List<Monomial>(monomials);
        }

        public void SortByExponent()
        {
            Monomials = Monomials.OrderByDescending(x => x.TotalExponent).ToList();
        }

        public override string ToString()
        {
            return string.Join("", Monomials);
        }

        public int Remainder
        {
            get => _remainder;
            set => _remainder = value;
        }

        public List<Monomial> Monomials
        {
            get { return _monomials; }
            private set { _monomials = value; }
        }
    }
}
