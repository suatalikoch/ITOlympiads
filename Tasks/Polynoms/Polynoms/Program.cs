using Polynoms.Libraries;
using Polynoms.Models;

namespace Polynomials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monomial a = new Monomial(4, new List<Variable>()
            { 
                new Variable('x', 5),
                new Variable('y', 4)
            });

            Monomial b = new Monomial(6, new List<Variable>() 
            { 
                new Variable('z', 3) 
            });

            Monomial c = new Monomial(9, new List<Variable>() 
            {
                new Variable('q', 2) 
            });

            Monomial d = new Monomial(7, new List<Variable>()
            { 
                new Variable('r', 1) 
            });

            Console.WriteLine(PolynomialMath.Add(new Polynomial(a, b), new Polynomial(c, d)));
            Console.WriteLine(PolynomialMath.Substract(new Polynomial(a, b), new Polynomial(c, d)));
            //- Console.WriteLine(PolynomialMath.Multiply(new Polynomial(a, b), new Polynomial(c, d)));
            //- Console.WriteLine(PolynomialMath.Divide(new Polynomial(a, b), new Polynomial(c, d)));
        }
    }
}