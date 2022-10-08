using Polynoms.Comparers;
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

        /// <summary>
        /// Only Coefficient
        /// </summary>
        /// <param name="coefficient"></param>
        public Monomial(double coefficient)
            : this(coefficient, new List<Variable>())
        { }

        /// <summary>
        /// Only Variables
        /// </summary>
        /// <param name="variables"></param>
        public Monomial(List<Variable> variables)
            : this(1, variables)
        { }

        /// <summary>
        /// Full Monomial
        /// </summary>
        /// <param name="coefficient"></param>
        /// <param name="variables"></param>
        public Monomial(double coefficient, List<Variable> variables)
        {
            Coefficient = coefficient;
            Variables = variables;

            CalculateTotalExponent();
            SortByLetter();
        }

        private void CalculateTotalExponent()
        {
            TotalExponent = 0;

            foreach (Variable variable in Variables)
            {
                TotalExponent += variable.Exponent;
            }
        }

        private void SortByLetter()
        {
            Variables.Sort(new LetterComparer());
        }

        public override bool Equals(object? obj)
        {
            if (Coefficient != (obj as Monomial).Coefficient)
            {
                return false;
            }

            if (Variables.Count != (obj as Monomial).Variables.Count)
            {
                return false;
            }

            for (int i = 0; i < (obj as Monomial).Variables.Count; i++)
            {
                if (!Variables.Contains((obj as Monomial).Variables[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public override string ToString()
        {
            switch (Coefficient)
            {
                case 0:
                    return string.Empty;
                case 1:
                    return $"+ {string.Join("", Variables)}";
                case -1:
                    return $"- {string.Join("", Variables)}";
                case > 1:
                    return $"+ {Coefficient}{string.Join("", Variables)}";
                default:
                    return $"- {Math.Abs(Coefficient)}{string.Join("", Variables)}";
            }
        }

        public double Coefficient
        {
            get { return _coefficient; }
            private set { _coefficient = value; }
        }

        public List<Variable> Variables
        {
            get { return _variables; }
            set { _variables = value; }
        }

        public int TotalExponent
        {
            get { return _totalExponent; } 
            private set { _totalExponent = value; }
        }
    }
}
