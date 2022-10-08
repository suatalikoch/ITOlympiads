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
            Monomials = Monomials.OrderByDescending(x => x.TotalExponent).ToList();
        }

        public override string ToString()
        {
            return string.Join(" ", Monomials);
        }

        public List<Monomial> Monomials
        {
            get { return _monomials; }
            private set
            {
                _monomials = value;
            }
        }
    }
}
