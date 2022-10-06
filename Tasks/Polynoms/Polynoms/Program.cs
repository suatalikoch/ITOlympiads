using Polynoms.Libraries;
using Polynoms.Models;

namespace Polynomials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monomial a1 = new Monomial(2, new List<Variable>()
            {
                new Variable('x', 3),
                new Variable('y', 2)
            });

            Monomial a2 = new Monomial(3, new List<Variable>()
            {
                new Variable('x', 3),
                new Variable('y', 2)
            });

            Console.WriteLine(PolynomialMath.Add(new Polynomial(a1), new Polynomial(a2)));
            Console.WriteLine(PolynomialMath.Substract(new Polynomial(a1), new Polynomial(a2)));
            //- Console.WriteLine(PolynomialMath.Multiply(new Polynomial(a, b), new Polynomial(c, d)));
            //- Console.WriteLine(PolynomialMath.Divide(new Polynomial(a, b), new Polynomial(c, d)));
        }
    }
}