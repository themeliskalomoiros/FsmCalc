namespace Calculator;

public static class AlphabetExtension
{
    /// <summary>
    /// Returns true if the instance is 0, 1, 2, 3, 4, 5, 6, 7, 8 or 9.
    /// </summary>
    /// <param name="item"></param>
    /// <returns>True only if instance is 0, 1, 2, 3, 4, 5, 6, 7, 8 or 9.</returns>
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

    /// <summary>
    /// Returns true if the instance is addition, subtraction, multiplication or division.
    /// </summary>
    /// <param name="item"></param>
    /// <returns>True only if instance +, -, *, or ÷.</returns>
    public static bool IsMainOperation(this Alphabet item)
	{
		return 
			item == Alphabet.Division ||
			item == Alphabet.Multiplication ||
			item == Alphabet.Addition ||
			item == Alphabet.Subtraction;
    }

    /// <summary>
    /// Returns true if the instance is an operation. Those are +, -, *, ÷, %, 1/x, x², or √.
    /// </summary>
    /// <param name="item"></param>
    /// <returns>True only if instance is +, -, *, ÷, %, 1/x, x², or √.</returns>
    public static bool IsOperation(this Alphabet item)
	{
		return 
			IsMainOperation(item) ||
			item == Alphabet.Percent || 
			item == Alphabet.OneOfTerm ||
			item == Alphabet.PowerOfTwo ||
			item == Alphabet.SquareRoot;
	}

	/// <summary>
	/// The string representation of an instance.
	/// </summary>
	/// <exception cref="ArgumentException">For an invalid value (for example (Alphabet) 99).</exception>
	public static string GetSymbol(this Alphabet item)
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
			case Alphabet.PowerOfTwo:
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
			case Alphabet.Sign:
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