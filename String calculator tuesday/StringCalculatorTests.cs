namespace StringCalculator;

public class StringCalculatorTests
{
	[Fact]
	public void EmptyStringReturnsZero()
	{
		var calculator = new StringCalculator();

		var result = calculator.Add("");

		Assert.Equal(0, result);
	}

	[Theory]
	[InlineData("1", 1)]
	[InlineData("2", 2)]
	[InlineData("110", 110)]
	[InlineData("1,2", 3)]
	[InlineData("1,2,3,4,5,6,7,8,9", 45)]
	[InlineData("1,2,3,4,5,6,7,8,9,10,11,12,13,14,15", 120)]
	[InlineData("1\n2,3,4,5\n6,7,8,9,10,11,12,13\n14,15", 120)]


	public void SingleDigit(string input, int expected)
	{
		var calculator = new StringCalculator();
		var result = calculator.Add(input);
		Assert.Equal(expected, result);
	}
}
