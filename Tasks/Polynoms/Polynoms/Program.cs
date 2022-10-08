using Polynoms.Libraries;
using Polynoms.Models;

namespace Polynomials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monomial a1 = new(2, new List<Variable>()
            {
                new Variable('x', 3),
                new Variable('y', 2)
            });

            Monomial a2 = new(3, new List<Variable>()
            {
                new Variable('x', 3),
                new Variable('y', 2)
            });

            Monomial a3 = new(1, new List<Variable>()
            {
                new Variable('x', 1),
                new Variable('y', 1)
            });

            Monomial a4 = new(-6, new List<Variable>()
            {
                new Variable('x', 4),
                new Variable('y', 9)
            });

            Console.WriteLine(PolynomialMath.Add(new Polynomial(a1), new Polynomial(a2)));
            Console.WriteLine(PolynomialMath.Substract(new Polynomial(a1), new Polynomial(a2)));
            Console.WriteLine(PolynomialMath.Multiply(new Polynomial(a1, a3), new Polynomial(a2, a4)));
            Console.WriteLine(PolynomialMath.Divide(new Polynomial(a1), new Polynomial(a2)));
        }
    }
}