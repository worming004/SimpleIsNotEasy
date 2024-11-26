using System;

namespace NestedIf
{
    public class UnreadableReader : IReader
    {
        public void Read(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                if (!input.Contains("NotExpectedString", StringComparison.InvariantCultureIgnoreCase))
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
}
