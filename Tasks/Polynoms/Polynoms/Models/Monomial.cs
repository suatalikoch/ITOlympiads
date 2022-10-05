using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynoms.Models
{
    internal class Monomial
    {
        private double _coefficient;

        private List<Variable> _variables;

        public Monomial(List<Variable> variable)
            : this(1, variable)
        { }

        public Monomial(double coefficient, List<Variable> variable)
        {
            Coefficient = coefficient;
            Variables = variable;
        }

        public override string ToString()
        {
            return $"{Coefficient}{string.Join("", Variables)}";
        }

        public double Coefficient
        {
            get { return _coefficient; }
            set { _coefficient = value; }
        }

        public List<Variable> Variables
        {
            get { return _variables; }
            set { _variables = value; }
        }
    }
}
