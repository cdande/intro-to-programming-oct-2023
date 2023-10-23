namespace LinkedOut.Tests;

public class UnitTest1
{
    [Fact] //Attribute
    public void CanAddTwoSpecificIntergers()
    {
        //Given
        int a = 10;
        int b = 20;
        int total;


        // WHen - "Act" Poke at it and see what happens.
        total = a + b; // "System Under Test ("SUT")

        Assert.Equal(30, total);
    }

    [Theory]
    [InlineData(10, 20, 30)]
    [InlineData(2, 2, 4)]
    [InlineData(10, 2, 12)]
    public void CanAddAnyTwoIntegers(int a, int b, int expected)
    {
        int total = a + b;

        Assert.Equal(expected, total);
    }
    [Theory]
    [InlineData("Han", "Solo", "Solo, Han")]
    [InlineData("Luke", "Skywalker", "Skywalker, Luke")]

    public void CanFormatNames(string firstName, string lastName, string result)
    {
        NameFormatter formatter = new NameFormatter();



        string fullName = formatter.FormatName(firstName, lastName);



        Assert.Equal(result, fullName);
    }
}

public class NameFormatter
{
    public string FormatName(string firstName, string lastName)
    {
        return lastName + ", " + firstName;
    }
}