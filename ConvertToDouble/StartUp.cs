using System;

namespace ConvertToDouble
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var number = ReadDouble();
            Console.WriteLine(number);
        }

        private static double ReadDouble()
        {
            try
            {
                string input = Console.ReadLine();
                var number = Convert.ToDouble(input);
                return number;

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
