
namespace StringCalculator;

public class StringCalculator
{

	public int Add(string numbers)
	{
		if (numbers.Contains("\n"))
		{

			int total = 0;

			var endNumbers = numbers.Split(",", "\n");

			foreach (var number in endNumbers)
			{

				total += int.Parse(number);

			}
			return total;
		}
		if (numbers.Contains(","))
		{
			var allNumbers = numbers.Split(',');
			allNumbers.ToList();
			int total = 0;
			foreach (var number in allNumbers)
			{

				total += int.Parse(number);

			}
			return total;
		}

		if ((numbers == ""))
		{
			return 0;
		}
		else
		{
			return int.Parse(numbers);
		}

	}
}
