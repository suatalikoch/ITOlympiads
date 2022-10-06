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

        private int _exponent;

        public Monomial(List<Variable> variables)
            : this(1, variables)
        { }

        public Monomial(double coefficient, List<Variable> variables)
        {
            Coefficient = coefficient;
            Variables = variables;
        }

        public void TotalExponent()
        {
            Exponent = 0;

            foreach (Variable variable in Variables)
            {
                Exponent += variable.Exponent;
            }
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

        public int Exponent { get => _exponent; 
            private set => _exponent = value; }
    }
}
