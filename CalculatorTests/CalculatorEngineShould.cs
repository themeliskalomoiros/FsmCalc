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
	[InlineData("0", A.Zero, A.Percent, A.OneOfTerm, A.Sign, A.ClearEntry, A.Clear, A.Backspace, A.Equation)]
	[InlineData("1453", A.One, A.Four, A.Five, A.Three)]
	[InlineData("-1234567890.3", A.One, A.Two, A.Three, A.Four, A.Five, A.Six, A.Seven, A.Eight, A.Nine, A.Zero, A.Decimal, A.Three, A.Sign)]
	[InlineData("-1234567890.", A.One, A.Two, A.Three, A.Four, A.Five, A.Six, A.Seven, A.Eight, A.Nine, A.Zero, A.Decimal, A.Three, A.Sign, A.Backspace)]
	[InlineData("-1234567", A.One, A.Two, A.Three, A.Four, A.Five, A.Six, A.Seven, A.Eight, A.Nine, A.Zero, A.Decimal, A.Three, A.Sign, A.Backspace, A.Backspace, A.Backspace, A.Backspace, A.Backspace)]
	[InlineData("0", A.One, A.Two, A.Three, A.Four, A.Five, A.Six, A.Seven, A.Eight, A.Nine, A.Zero, A.Decimal, A.Three, A.Sign, A.Backspace, A.Backspace, A.Backspace, A.Backspace, A.Backspace, A.Backspace, A.Backspace, A.Backspace, A.Backspace, A.Backspace, A.Backspace, A.Backspace, A.Backspace)]
	[InlineData("1453", A.One, A.Four, A.Five, A.Three, A.Sign, A.Decimal, A.Sign, A.Decimal)]
	[InlineData("4", A.Eight, A.Addition, A.Four)]
	[InlineData("452", A.One, A.Two, A.Four, A.Subtraction, A.Multiplication, A.Four, A.Five, A.Two)]
	[InlineData("56048", A.One, A.Two, A.Four, A.Subtraction, A.Multiplication, A.Four, A.Five, A.Two, A.Equation)]
	[InlineData("0", A.Eight, A.Five, A.Percent)]
	[InlineData("4", A.One, A.Six, A.SquareRoot)]
	[InlineData("256", A.Four, A.PowerOfTwo, A.PowerOfTwo, A.PowerOfTwo, A.SquareRoot)]
	[InlineData("0.769230769230769", A.One, A.Decimal, A.Three, A.SquareRoot, A.PowerOfTwo, A.OneOfTerm)]
	[InlineData("0.9523809523809523", A.One, A.Decimal, A.Zero, A.Five, A.OneOfTerm)]
	[InlineData("31", A.One, A.Addition, A.Three, A.Equation, A.Equation, A.Equation, A.Equation, A.Equation, A.Equation, A.Equation, A.Equation, A.Equation, A.Equation)]
	[InlineData("-29", A.One, A.Subtraction, A.Three, A.Equation, A.Equation, A.Equation, A.Equation, A.Equation, A.Equation, A.Equation, A.Equation, A.Equation, A.Equation)]
	[InlineData("118098", A.Two, A.Multiplication, A.Three, A.Equation, A.Equation, A.Equation, A.Equation, A.Equation, A.Equation, A.Equation, A.Equation, A.Equation, A.Equation)]
	[InlineData("0.0013717421124828531", A.One, A.Division, A.Three, A.Equation, A.Equation, A.Equation, A.Equation, A.Equation, A.Equation)]
	[InlineData("5", A.One, A.Zero, A.Addition, A.Five, A.Zero, A.Percent)]
	[InlineData("15", A.One, A.Zero, A.Addition, A.Five, A.Zero, A.Percent, A.Equation)]
	[InlineData("25", A.One, A.Zero, A.Addition, A.Five, A.Zero, A.Percent, A.Equation, A.Equation, A.Equation)]
	[InlineData("10.033333333333333", A.One, A.Zero, A.Addition, A.Three, A.Zero, A.OneOfTerm, A.Equation)]
	[InlineData("10.066666666666666", A.One, A.Zero, A.Addition, A.Three, A.Zero, A.OneOfTerm, A.Equation, A.Equation)]
	[InlineData("1.5", A.Six, A.Addition, A.Five, A.PowerOfTwo, A.Percent)]
	[InlineData("10", A.Six, A.Addition, A.Five, A.PowerOfTwo, A.Percent, A.ClearEntry, A.Addition, A.One, A.Zero)]
	[InlineData("16", A.Six, A.Addition, A.Five, A.PowerOfTwo, A.Percent, A.ClearEntry, A.Addition, A.One, A.Zero, A.Equation)]
	[InlineData("7.5", A.Six, A.Addition, A.Five, A.PowerOfTwo, A.Percent, A.Equation)]
	[InlineData("4", A.One, A.Zero, A.Addition, A.Three, A.Zero, A.OneOfTerm, A.Equation, A.Three, A.Addition , A.Four)]
	[InlineData("7", A.One, A.Zero, A.Addition, A.Three, A.Zero, A.OneOfTerm, A.Equation, A.Three, A.Addition , A.Four, A.Equation)]
	[InlineData("1", A.One, A.Addition, A.One, A.Equation, A.Addition , A.One)]
	[InlineData("3", A.One, A.Addition, A.One, A.Equation, A.Addition , A.One, A.Equation)]
	public void ReturnValidOutput(
		string expectedOutput,
		params Alphabet[] inputSequence)
	{
		foreach (var input in inputSequence)
			_sut.Process(input);

		Assert.Equal(expectedOutput, _sut.Output);
	}
}