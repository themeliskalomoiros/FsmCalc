using System.Text;

namespace Calculator;

public class CalculatorEngine
{
	public event EventHandler<CalculatorEngineEventArgs>? OutputValueChanged;
	
	private string Output { get; set; }
	private State CurrentState { get; set; }

	public CalculatorEngine()
	{
		Output = "0";
		CurrentState = State.A;
	}

	public void Process(Alphabet input)
	{
		ThrowForInvalidInput(input);

		CurrentState = StateMachine.GetNextState(CurrentState, input);

		if (CurrentState == State.B && input.IsNumeric())
		{
			if (input == Alphabet.Zero && double.TryParse(Output, out var result))
			{
				if (result == 0.0)
					return;
			}
			else
			{
				Output += input.ToString();
				if (OutputValueChanged != null)
				{
					OutputValueChanged(this, new CalculatorEngineEventArgs(Output));	
				}
			}
		}
	}

	private void ThrowForInvalidInput(Alphabet input)
	{
		if (!Enum.IsDefined(typeof(Alphabet), input))
		{
			throw new ArgumentException(
				$"{input} is not a valid argument for this calculator.");
		}
	}
}
