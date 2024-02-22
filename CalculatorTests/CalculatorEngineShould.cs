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
	public void RaisesWhenOutputChangesValue(params Alphabet[] seriesOfInputs)
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
}