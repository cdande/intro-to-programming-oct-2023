
namespace StringCalculator;
public class StringCalculatorInterationTests
{
	private readonly StringCalculator _calculator;

	public StringCalculatorInterationTests(StringCalculator calculator)
	{
		_calculator = calculator;
	}

	[Theory]
	[InlineData("1")]
	public void WritesToLogger(string numbers)
	{
		// when 
		_calculator.Add(numbers);

		// then
		// Does "1" get written to the logger's write method?
	}

}
