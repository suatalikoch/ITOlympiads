using Polynoms.Libraries;
using Polynoms.Models;

namespace Polynomials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monomial a = new(-8, new List<Variable>()
            {
                new Variable('x', 1),
                new Variable('n', 9)
            });

            Monomial b = new(-2, new List<Variable>()
            {
                new Variable('m', 3),
                new Variable('y', 1)
            });

            Monomial c = new(4, new List<Variable>()
            {
                new Variable('n', 1),
                new Variable('x', 3)
            });

            Monomial d = new(-9, new List<Variable>()
            {
                new Variable('x', 1),
                new Variable('y', 1),
                new Variable('z', 10)
            });

            Monomial e = new(-1, new List<Variable>()
            {
                new Variable('y', 3),
                new Variable('n', 4)
            });

            Console.WriteLine(PolynomialMath.Add(new Polynomial(a), new Polynomial(b)));
            Console.WriteLine(PolynomialMath.Substract(new Polynomial(a), new Polynomial(b)));
            Console.WriteLine(PolynomialMath.Multiply(new Polynomial(a, b, e), new Polynomial(c, d)));
            Console.WriteLine(PolynomialMath.Divide(new Polynomial(a), new Polynomial(b)));
        }
    }
}