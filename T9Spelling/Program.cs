using System;

namespace T9Spelling
{
    class Program
    {
        static void Main(string[] args)
        {
            IConverter converter = new StringConverter();

            Console.WriteLine("Please, write your cases count");
            var countOfCases = Console.ReadLine();

            for (int i = 1; i <= Convert.ToInt32(countOfCases); i++)
            {
                Console.WriteLine("Please, write your message");
                var inputString = Console.ReadLine();

                var result = converter.Convert(inputString);

                Console.WriteLine($"Case #{i}: {result}");
            }

            Console.WriteLine("Please, press enter for exit...");
            Console.ReadKey();
        }
    }
}
