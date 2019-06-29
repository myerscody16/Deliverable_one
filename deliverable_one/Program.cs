using System;

namespace deliverable_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please prepare three monetary values to be sorted and converted from USD to other currencies.");

            Console.WriteLine("Please input your first value in USD:");
            Double firstValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input your second value in USD:");
            Double secondValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input your third value in USD:");
            Double thirdValue = Convert.ToDouble(Console.ReadLine());

            USDtoKrona(firstValue, secondValue, thirdValue);
            USDtoBaht(firstValue, secondValue, thirdValue);
            USDtoYen(firstValue, secondValue, thirdValue);
            Assignment(firstValue, secondValue, thirdValue);
        }
        public static void USDtoKrona(Double firstValue, Double secondValue, Double thirdValue)
        {
            Double Krona1 = firstValue * .033;
            Double Krona2 = secondValue * .033;
            Double Krona3 = thirdValue * .033;
            Console.WriteLine("Your first value converts to {0} Krona", Krona1);
            Console.WriteLine("Your second value converts to {0} Baht", Krona2);
            Console.WriteLine("Your third value converts to {0} Baht", Krona3);
        }
        public static void USDtoYen(Double firstValue, Double secondValue, Double thirdValue)
        {
            Double Yen1 = firstValue * .033;
            Double Yen2 = secondValue * .033;
            Double Yen3 = thirdValue * .033;
            Console.WriteLine("Your first value converts to {0} Baht", Yen1);
            Console.WriteLine("Your second value converts to {0} Baht", Yen2);
            Console.WriteLine("Your third value converts to {0} Baht", Yen3);
        }
        public static void USDtoBaht(Double firstValue, Double secondValue, Double thirdValue)
        {
            Double Baht1 = firstValue * .033;
            Double Baht2 = secondValue * .033;
            Double Baht3 = thirdValue * .033;
            Console.WriteLine("Your first value converts to {0} Baht", Baht1);
            Console.WriteLine("Your second value converts to {0} Baht", Baht2);
            Console.WriteLine("Your third value converts to {0} Baht", Baht3);
        }
        public static void Assignment(Double firstValue, Double secondValue, Double thirdValue)
        {

        }
    }
}
