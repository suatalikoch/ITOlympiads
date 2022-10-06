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
            //- Monomials = Monomials.OrderByDescending(x => x.Variables.Max(y => y.Exponent)).ToList();
            Monomials = Monomials.OrderByDescending(x => x.Exponent).ToList();
        }

        public override string ToString()
        {
            string polynomial = string.Empty;

            foreach (Monomial monomial in Monomials)
            {
                if (monomial.Coefficient >= 0)
                {
                    polynomial += $"+{monomial}";
                }
                else
                {
                    polynomial += monomial;
                }
            }

            return polynomial;
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
