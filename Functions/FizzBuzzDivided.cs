namespace Functions
{
	public class FizzBuzzDivided : IPrintFizzBuzz
	{
		public void Execute()
		{
			for (int i = 1; i <= 100; i++)
			{
				string fizzBuzzText = getFizzBuzz(i);
				writeInConsole(fizzBuzzText);
			}
		}

		private string getFizzBuzz(int value)
		{
			if (value % 5 == 0 && value % 3 == 0)
			{
				return "fizzbuzz";
			}
			else if (value % 3 == 0)
			{
				return "fizz";
			}
			else if (value % 5 == 0)
			{
				return "buzz";
			}
			else
			{
				return value.ToString();
			}
		}

		private void writeInConsole(string text)
		{
			System.Console.WriteLine(text);
		}
	}
}