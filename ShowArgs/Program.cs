using System;

namespace ShowArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length <= 0)
            {
                Console.WriteLine("<no arguments>");
                return;
            }

            int numberOfDigits(int value)
            {
                if (value < 0) throw new Exception("Nope, not doing it");

                var result = 1;
                while (value >= 10)
                {
                    result++;
                    value /= 10;
                }

                return result;
            }

            var alignment = numberOfDigits(args.Length - 1);
            var formatString = $"Arg {{0,{alignment}}}: {{1}}";
            for (var i = 0; i < args.Length; i++)
            {
                Console.WriteLine(formatString, i, args[i]);
            }
        }
    }
}
