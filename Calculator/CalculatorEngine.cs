namespace Calculator;

public class CalculatorEngine
{
	public string GetOutput(Alphabet input)
	{
		throw new ArgumentException($"{input} is not a valid argument for this calculator.");
	}
}
