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

        private int _totalExponent;

        public Monomial(double coefficient)
            : this(coefficient, null)
        { }

        public Monomial(List<Variable> variables)
            : this(1, variables)
        { }

        public Monomial(double coefficient, List<Variable> variables)
        {
            Coefficient = coefficient;
            Variables = variables;

            CTotalExponent();
        }

        public void CTotalExponent()
        {
            TotalExponent = 0;

            foreach (Variable variable in Variables)
            {
                TotalExponent += variable.Exponent;
            }
        } 

        public override string ToString()
        {
            if (Coefficient == 0)
            {
                return string.Empty;
            }
            else if (Coefficient > 0)
            {
                return $"+{Coefficient}{string.Join("", Variables)}";
            }

            return $"-{Coefficient}{string.Join("", Variables)}";
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

        public int TotalExponent
        {
            get => _totalExponent; 
            private set => _totalExponent = value; 
        }
    }
}
