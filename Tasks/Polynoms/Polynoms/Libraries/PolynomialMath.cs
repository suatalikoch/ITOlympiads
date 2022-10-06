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
        /*
        public static Polynomial Add(Polynomial a, Polynomial b)
        {
            Polynomial polynomial = new Polynomial();

            polynomial.Monomials.AddRange(a.Monomials);
            polynomial.Monomials.AddRange(b.Monomials);

            for (int i = 0; i < polynomial.Monomials.Count; i++)
            {
                for (int j = 0; j < polynomial.Monomials.Count; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }

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
        */

        public static Polynomial Add(Polynomial a, Polynomial b) ///Sorted
        {
            Polynomial polynomial = new Polynomial();

            for (int i = 0; i < a.Monomials.Count; i++)
            {
                for (int j = 0; j < b.Monomials.Count; j++)
                {
                    if (CompareMonomialExponent(a.Monomials[i], b.Monomials[j] == 0))
                    {
                        if (CanAddMonomial(a.Monomials[i], b.Monomials[j]))
                        {
                            polynomial.Monomials.Add(new Monomial(a.Monomials[i].Coefficient + b.Monomials[j].Coefficient), a.Monomials[i].Variables);
                        }
                        else
                        {
                            if(a.Monomials[i].Variables.Length > b.Monomials[j].Variables.Length)
                            {
                                // b a
                                polynomial.Monomials.Add(b.Monomials[j]);
                                polynomial.Monomials.Add(a.Monomials[i]);
                                polynomial.Monomials.Add(new Monomial(a.Monomials[i].Coefficient + b.Monomials[j].Coefficient), a.Monomials[i].Variables);
                            }
                            else
                            {
                                // a b
                            }
                        }
                        
                    }
                    else if (CompareMonomialExponent(a.Monomials[i], b.Monomials[j] == 1))
                    {

                    }
                    else //=-1
                    {

                    }





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
            Polynomial polynomial = new Polynomial();

            polynomial.Monomials.AddRange(a.Monomials);
            polynomial.Monomials.AddRange(b.Monomials);

            for (int i = 0; i < polynomial.Monomials.Count; i++)
            {
                for (int j = 0; j < polynomial.Monomials.Count; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }

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
            Polynomial polynomial = new Polynomial();

            polynomial.Monomials.AddRange(a.Monomials);
            polynomial.Monomials.AddRange(b.Monomials);

            for (int i = 0; i < polynomial.Monomials.Count; i++)
            {
                for (int j = 0; j < polynomial.Monomials.Count; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }

                    if (polynomial.Monomials[i].Variables.Equals(polynomial.Monomials[j].Variables))
                    {
                        //- polynomial.Monomials[i] = new Monomial(polynomial.Monomials[i].Coefficient * polynomial.Monomials[j].Coefficient, polynomial.Monomials[i].Variables, polynomial.Monomials[i].Exponent + polynomial.Monomials[j].Exponent);
                    }
                    else
                    {
                        //- polynomial.Monomials[i] = new Monomial(polynomial.Monomials[i].Coefficient * polynomial.Monomials[j].Coefficient, polynomial.Monomials[i].Variables + polynomial.Monomials[j].Variable, polynomial.Monomials[i].Exponent + polynomial.Monomials[j].Exponent);
                    }

                    polynomial.Monomials.RemoveAt(j);

                    j--;
                }
            }

            polynomial.SortByExponent();

            return polynomial;
        }
        public static int CompareMonomialExponent(Monomial a, Monomial b)
        {
            return a.Exponent.CompareTo(b.Exponent);
        }
        public static Polynomial Divide(Polynomial a, Polynomial b)
        {
            return new Polynomial();
        }

        public static Polynomial Simplify(Polynomial a)
        {
            return new Polynomial();
        }

        public static Polynomial DefinitionSet(Polynomial a) //Definicionno mnojestvo
        {
            return new Polynomial();
        }

        private static bool CanAddMonomial(Monomial a, Monomial b)
        {
            if (a.Variables.Count != b.Variables.Count)
            {
                return false;
            }

            for (int i = 0; i < a.Variables.Count; i++)
            {
                if (!a.Variables[i].Equals(b.Variables[i]))
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
