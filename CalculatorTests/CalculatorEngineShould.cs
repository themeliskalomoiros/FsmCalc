using Calculator;

namespace CalculatorTests;

public class CalculatorEngineShould
{
	[Fact]
	public void ThrowForInvalidInput()
	{
		var sut = new CalculatorEngine();
		var invalidInput = (Alphabet) 99;

		Assert.Throws<ArgumentException>(() => sut.GetOutput(invalidInput));
	}
}