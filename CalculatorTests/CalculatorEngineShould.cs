using Calculator;

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
	[InlineData(Alphabet.One)]
	public void RaiseWhenOutputChanges(params Alphabet[] seriesOfInputs)
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
	[InlineData("1", Alphabet.One)]
	[InlineData("12", Alphabet.One, Alphabet.Two)]
	[InlineData("1453", Alphabet.One, Alphabet.Four, Alphabet.Five, Alphabet.Three)]
	public void ReturnValidOutput(
		string expectedOutput, 
		params Alphabet[] inputSequence)
	{
		foreach (var input in inputSequence)
			_sut.Process(input);

		Assert.Equal(expectedOutput, _sut.Output);
	}
}