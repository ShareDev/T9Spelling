using System;

namespace T9Spelling
{
    class Program
    {
        private readonly IUnitOfWork _unitOfWork;

        private Program()
        {
            _unitOfWork = new UnitOfWork();
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.ConvertStringToNumbers();
        }

        private void ConvertStringToNumbers()
        {
            Console.WriteLine("Please, write your cases count");
            var countOfCases = Console.ReadLine();

            for (int i = 1; i <= Convert.ToInt32(countOfCases); i++)
            {
                Console.WriteLine("Please, write your message");
                var inputString = Console.ReadLine();

                var result = _unitOfWork.Converter.Convert(inputString);

                Console.WriteLine($"Case #{i}: {result}");
            }

            Console.WriteLine("Please, press enter for exit...");
            Console.ReadKey();
        }
    }
}
