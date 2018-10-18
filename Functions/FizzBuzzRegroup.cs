namespace Functions
{
	public class FizzBuzzRegroup : IPrintFizzBuzz
	{
		public void Execute()
		{
			for (int i = 1; i <= 100; i++)
			{
				string result;
				if (i % 5 == 0 && i % 3 == 0)
				{
					result = "fizzbuzz";
				}
				else if (i % 3 == 0)
				{
					result = "fizz";
				}
				else if (i % 5 == 0)
				{
					result = "buzz";
				}
				else
				{
					result = i.ToString();
				}
				System.Console.WriteLine(result);
			}
		}
	}
}