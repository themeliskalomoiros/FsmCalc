using Calculator;

using A = Calculator.Alphabet;

namespace CalculatorTests;

public class CalculatorEngineShould
{
	private readonly CalculatorEngine _sut;

	public CalculatorEngineShould()
	{
		_sut = new CalculatorEngine();
	}

	[Fact]
	public void ThrowForInvalidInput()
	{
		var invalidInput = (Alphabet) 99;
		Action testCode = () => _sut.Process(invalidInput);
		Assert.Throws<ArgumentException>(testCode);
	}

	[Theory]
	[InlineData(A.One)]
	public void RaiseWhenOutputChanges(
		params Alphabet[] seriesOfInputs)
	{
		Action processInputs = () => {
			foreach (var input in seriesOfInputs) 
				_sut.Process(input);
		};

		Assert.Raises<CalculatorEngineEventArgs>(
			handler => _sut.OutputValueChanged += handler,
			handler => _sut.OutputValueChanged -= handler,
			processInputs);
	}

	[Theory]
	[InlineData("1", A.One)]
	[InlineData("12", A.One, A.Two)]
	[InlineData("1453", A.One, A.Four, A.Five, A.Three)]
	[InlineData("1453000", A.One, A.Four, A.Five, A.Three, A.Zero, A.Zero, A.Zero)]
	[InlineData("0", A.Subtraction)]
	[InlineData("-3", A.Three, A.Sign)]
	[InlineData("32", A.Three, A.Two, A.Sign, A.Sign)]
	[InlineData("0.", A.Decimal)]
	[InlineData("0", A.Decimal, A.Decimal)]
	[InlineData("0.", A.Decimal, A.Decimal, A.Decimal)]
	[InlineData("0", A.Decimal, A.Decimal, A.Decimal, A.Decimal)]
	[InlineData("0", A.Percent, A.OneOfTerm, A.Sign, A.Clear, A.ClearEntry, A.Backspace, A.Equation)]
	[InlineData("4", A.Eight, A.Addition, A.Four)]
	[InlineData("452", A.One, A.Two, A.Four, A.Subtraction, A.Multiplication, A.Four, A.Five, A.Two)]
	public void ReturnValidOutput(
		string expectedOutput,
		params Alphabet[] inputSequence)
	{
		foreach (var input in inputSequence)
			_sut.Process(input);

		Assert.Equal(expectedOutput, _sut.Output);
	}
}