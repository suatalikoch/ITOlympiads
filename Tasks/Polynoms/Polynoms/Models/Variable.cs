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

        public Variable(char letter) 
            : this(letter, 1)
        { }

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
            return $"{Letter}^{Exponent}";
        }

        public char Letter
		{
			get { return _letter; }
			set { _letter = value; }
		}

        public int Exponent
        {
            get { return _exponent; }
            set { _exponent = value; }
        }
    }
}
