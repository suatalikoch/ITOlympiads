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

        public Polynomial(params Monomial[] monomials)
        {
            Monomials = new List<Monomial>(monomials);
        }

        public void SortByExponent()
        {
            Monomials = Monomials.OrderByDescending(x => x.Variables.Max(y => y.Exponent)).ToList();
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

        public List<Monomial> Monomials
        {
            get { return _monomials; }
            private set { _monomials = value; }
        }
    }
}
