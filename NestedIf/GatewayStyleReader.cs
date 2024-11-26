using System;

namespace NestedIf
{
    public class ReadableReader : IReader
    {
        public void Read(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentNullException(input);

            if (input.Contains("NotExpectedString", StringComparison.InvariantCultureIgnoreCase))
                throw new ArgumentException($"Not well formatted argument: {input}");

            if (input.Length <= 3)
                throw new ArgumentException($"Argument too short: {input}");

            // Read the input here
        }
    }
}
