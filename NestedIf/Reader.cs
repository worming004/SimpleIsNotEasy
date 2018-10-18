using System;

namespace NestedIf
{

	public interface IReader
	{
		void Read(string input);
	}

	public class UnreadableReader : IReader
	{
		public void Read(string input)
		{
			if (!string.IsNullOrEmpty(input))
			{
				if (!input.Contains("NotExpectedString"))
				{
					if (input.Length > 3)
					{
						// Read the input here
					}
					else
					{
						throw new ArgumentException($"Argument too short: {input}");
					}
				}
				else
				{
					throw new ArgumentException($"Not well formatted argument: {input}");
				}
			}
			else
			{
				throw new ArgumentNullException(input);
			}
		}
	}

	public class ReadableReader : IReader
	{
		public void Read(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				throw new ArgumentNullException(input);
			}

			if (input.Contains("NotExpectedString"))
			{
				throw new ArgumentException($"Not well formatted argument: {input}");
			}

			if (input.Length <= 3)
			{
				throw new ArgumentException($"Argument too short: {input}");
			}
			// Read the input here
		}
	}
}