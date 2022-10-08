using Polynoms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynoms.Libraries
{
    internal static class PolynomialMath
    {
        public static Polynomial Add(Polynomial a, Polynomial b)
        {
            Polynomial polynomial = new();

            polynomial.Monomials.AddRange(a.Monomials);
            polynomial.Monomials.AddRange(b.Monomials);

            for (int i = 0; i < polynomial.Monomials.Count; i++)
            {
                for (int j = i + 1; j < polynomial.Monomials.Count; j++)
                {
                    if (CanAddMonomial(polynomial.Monomials[i], polynomial.Monomials[j]))
                    {
                        polynomial.Monomials[i] = new Monomial(polynomial.Monomials[i].Coefficient + polynomial.Monomials[j].Coefficient, polynomial.Monomials[i].Variables);
                        polynomial.Monomials.RemoveAt(j);

                        j--;
                    }
                }
            }

            polynomial.SortByExponent();

            return polynomial;
        }

        public static Polynomial Substract(Polynomial a, Polynomial b)
        {
            Polynomial polynomial = new();

            polynomial.Monomials.AddRange(a.Monomials);
            polynomial.Monomials.AddRange(b.Monomials);

            for (int i = 0; i < polynomial.Monomials.Count; i++)
            {
                for (int j = i + 1; j < polynomial.Monomials.Count; j++)
                {
                    if (CanAddMonomial(polynomial.Monomials[i], polynomial.Monomials[j]))
                    {
                        polynomial.Monomials[i] = new Monomial(polynomial.Monomials[i].Coefficient - polynomial.Monomials[j].Coefficient, polynomial.Monomials[i].Variables);
                        polynomial.Monomials.RemoveAt(j);

                        j--;
                    }
                }
            }

            polynomial.SortByExponent();

            return polynomial;
        }

        public static Polynomial Multiply(Polynomial a, Polynomial b)
        {
            Polynomial polynomial = new();

            foreach (Monomial monomialA in a.Monomials)
            {
                foreach (Monomial monomialB in b.Monomials)
                {
                    List<Variable> variables = new();

                    foreach (Variable variableA in monomialA.Variables)
                    {
                        foreach (Variable variableB in monomialB.Variables)
                        {
                            if (variableA.Letter.Equals(variableB.Letter))
                            {
                                variables.Add(new Variable(variableA.Letter, variableA.Exponent + variableB.Exponent));  
                            }
                        }
                    }

                    polynomial.Monomials.Add(new Monomial(monomialA.Coefficient * monomialB.Coefficient, variables));
                }
            }

            polynomial.SortByExponent();

            return polynomial;
        }

        public static Polynomial Divide(Polynomial a, Polynomial b)
        {
            Polynomial polynomial = new();

            foreach (Monomial monomialA in a.Monomials)
            {
                foreach (Monomial monomialB in b.Monomials)
                {
                    List<Variable> variables = new();

                    foreach (Variable variableA in monomialA.Variables)
                    {
                        foreach (Variable variableB in monomialB.Variables)
                        {
                            if (variableA.Letter.Equals(variableB.Letter))
                            {
                                variables.Add(new Variable(variableA.Letter, variableA.Exponent - variableB.Exponent));
                            }
                        }
                    }

                    polynomial.Monomials.Add(new Monomial(Math.Round(monomialA.Coefficient / monomialB.Coefficient, 2), variables));
                }
            }

            polynomial.SortByExponent();

            return polynomial;
        }

        public static Polynomial Simplify(Polynomial a)
        {
            return new Polynomial();
        }

        public static Polynomial DefinitionSet(Polynomial a) //Definicionno mnojestvo
        {
            return new Polynomial();
        }

        public static int CompareMonomialExponent(Monomial a, Monomial b)
        {
            return a.TotalExponent.CompareTo(b.TotalExponent);
        }

        private static bool CanAddMonomial(Monomial a, Monomial b)
        {
            if (a.Variables.Count != b.Variables.Count)
            {
                return false;
            }

            foreach (Variable variable in a.Variables)
            {
                if (!b.Variables.Contains(variable))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool CanDivideMonomial(Monomial a, Monomial b)
        {
            return false;
        }
    }
}
