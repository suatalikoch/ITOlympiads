using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynoms.Models
{
    internal class Variable
    {
		private char _letter;

		private int _exponent;

        /// <summary>
        /// Exponent is 1
        /// </summary>
        /// <param name="letter"></param>
        public Variable(char letter) 
            : this(letter, 1)
        { }

        /// <summary>
        /// Full Variable
        /// </summary>
        /// <param name="letter"></param>
        /// <param name="exponent"></param>
        public Variable(char letter, int exponent)
        {
            Letter = letter;
            Exponent = exponent;
        }

        public override bool Equals(object? obj)
        {
            if (Letter.Equals((obj as Variable)?.Letter)
                && Exponent.Equals((obj as Variable)?.Exponent))
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            if (Exponent == 0)
            {
                return string.Empty;
            }

            return $"{Letter}^{Exponent}";
        }

        public char Letter
		{
			get { return _letter; }
			private set { _letter = value; }
		}

        public int Exponent
        {
            get { return _exponent; }
            private set { _exponent = value; }
        }
    }
}
