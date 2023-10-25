using DemoAPi.Services;

namespace DemoApi.UnitTests;
public class TemperatureConvertServiceTests
{



	[Fact]
	public void UsesTheFeeCalculator()
	{
		// Given
		var fakeFeeCalculator = Substitute.For<ICalculateFees>();
		fakeFeeCalculator.getCurrentFee().Returns(42.23M);
		var service = new TemperatureConverterService(fakeFeeCalculator);

		// When
		ConversionWithFeeResponse response = service.ConvertFtoC(100F);

		// Then
		Assert.Equal(42.23M, response.Fee);
	}



	//[Fact]
	//public void FeeOnOtherDays()
	//{
	//	var service = new TemperatureConverterService(new StubbedFeeThing());



	//	ConversionWithFeeResponse response = service.ConvertFtoC(100F);



	//	Assert.Equal(.03M, response.Fee);
	//}
}



// Test Double
public class StubbedFeeThing : ICalculateFees
{
	public decimal getCurrentFee()
	{
		return 42.23M;
	}
}