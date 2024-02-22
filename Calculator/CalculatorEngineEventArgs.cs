namespace Calculator;

public class CalculatorEngineEventArgs : EventArgs
{
	public CalculatorEngineEventArgs(string output)
	{
		Output = output;
	}

	public string Output { get; }
}