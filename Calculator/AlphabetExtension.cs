namespace Calculator;

public static class AlphabetExtension
{
	public static bool IsNumeric(this Alphabet item)
	{
		return 
			item == Alphabet.Zero ||
			item == Alphabet.One ||
			item == Alphabet.Two ||
			item == Alphabet.Three ||
			item == Alphabet.Four ||
			item == Alphabet.Five ||
			item == Alphabet.Six ||
			item == Alphabet.Seven ||
			item == Alphabet.Eight ||
			item == Alphabet.Nine;
	}

	public static bool IsOperation(this Alphabet item)
	{
		return 
			item == Alphabet.Percent || 
			item == Alphabet.OneOfTerm ||
			item == Alphabet.TermSquared ||
			item == Alphabet.SquareRoot ||
			item == Alphabet.Division ||
			item == Alphabet.Multiplication ||
			item == Alphabet.Addition ||
			item == Alphabet.Subtraction;
	}

	public static string ToString(this Alphabet item)
	{
		switch(item)
		{
			case Alphabet.Zero:
				return "0";
			case Alphabet.One:
				return "1";
			case Alphabet.Two:
				return "2";
			case Alphabet.Three:
				return "3";
			case Alphabet.Four:
				return "4";
			case Alphabet.Five:
				return "5";
			case Alphabet.Six:
				return "6";
			case Alphabet.Seven:
				return "7";
			case Alphabet.Eight:
				return "8";
			case Alphabet.Nine:
				return "9";
			case Alphabet.Percent:
				return "%";
			case Alphabet.OneOfTerm:
				return "1/x";
			case Alphabet.TermSquared:
				return "x²";
			case Alphabet.SquareRoot:
				return "√";
			case Alphabet.Division:
				return "÷";
			case Alphabet.Multiplication:
				return "x";
			case Alphabet.Addition:
				return "+";
			case Alphabet.Subtraction:
				return "-";
			case Alphabet.PlusMinus:
				return "±";
			case Alphabet.Dot:
				return ".";
			case Alphabet.ClearEntry:
				return "CE";
			case Alphabet.Clear:
				return "C";
			case Alphabet.Backspace:
				return "←";
			case Alphabet.Equation:
				return "=";
			default:
				throw new ArgumentException($"{item} is not a valid Alphabet.");
		}
	}
}