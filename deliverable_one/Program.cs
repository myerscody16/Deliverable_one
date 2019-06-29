using System;

namespace deliverable_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please prepare three U.S. dollar values for the program.");

            Console.WriteLine("Please input your first value in USD:");
            Double firstValue = Convert.ToDouble(Console.ReadLine());
            System.Math.Round(firstValue, 2);

            Console.WriteLine("Please input your second value in USD:");
            Double secondValue = Convert.ToDouble(Console.ReadLine());
            System.Math.Round(secondValue, 2);

            Console.WriteLine("Please input your third value in USD:");
            Double thirdValue = Convert.ToDouble(Console.ReadLine());
            System.Math.Round(thirdValue, 2);

            USDtoKrona(firstValue, secondValue, thirdValue);

            USDtoBaht(firstValue, secondValue, thirdValue);

            USDtoYen(firstValue, secondValue, thirdValue);

            Assignment(firstValue, secondValue, thirdValue);
        }
        public static void USDtoKrona(Double firstValue, Double secondValue, Double thirdValue)
        {
            Double Krona1 = System.Math.Round(firstValue * .033, 2);
            Double Krona2 = secondValue * .033;
            Double Krona3 = thirdValue * .033;
            Console.WriteLine("Your first value converts to {0} Krona", Krona1);
            Console.WriteLine("Your second value converts to {0} Krona.", Krona2);
            Console.WriteLine("Your third value converts to {0} Krona.", Krona3);
        }
        public static void USDtoYen(Double firstValue, Double secondValue, Double thirdValue)
        {
            Double Yen1 = System.Math.Round(firstValue * 107.9, 0);
            Double Yen2 = System.Math.Round(secondValue * 107.9, 0);
            Double Yen3 = System.Math.Round(thirdValue * 107.9, 0);
            Console.WriteLine("Your first value converts to {0} Yen.", Yen1);
            Console.WriteLine("Your second value converts to {0} Yen.", Yen2);
            Console.WriteLine("Your third value converts to {0} Yen.", Yen3);
        }
        public static void USDtoBaht(Double firstValue, Double secondValue, Double thirdValue)
        {
            Double Baht1 = System.Math.Round(firstValue * 30.63, 2);
            Double Baht2 = System.Math.Round(secondValue * 30.63, 2);
            Double Baht3 = System.Math.Round(thirdValue * 30.63, 2);
            Console.WriteLine("Your first value converts to {0} Baht", Baht1);
            Console.WriteLine("Your second value converts to {0} Baht", Baht2);
            Console.WriteLine("Your third value converts to {0} Baht", Baht3);
        }
        public static void Assignment(Double firstValue, Double secondValue, Double thirdValue)
        {
            Double total = System.Math.Round(firstValue + secondValue + thirdValue, 2);
            Double average = System.Math.Round((firstValue + secondValue + thirdValue) / 3, 2);
            Console.WriteLine("The total of all of these values in USD is {0}.", total);
            Console.WriteLine("The average of the three values in USD is {0}.", average);

            if (firstValue > secondValue && secondValue > thirdValue)
            {
                Console.WriteLine("The largest value is {0}.", firstValue);
                Console.WriteLine("The smallest value is {0}.", thirdValue);
            }
            else if (secondValue > firstValue && firstValue > thirdValue)
            {
                Console.WriteLine("The largest value is {0}.", secondValue);
                Console.WriteLine("The smallest value is {0}.", thirdValue);
            }
            else if (thirdValue > secondValue && secondValue > firstValue)
            {
                Console.WriteLine("The largest value is {0}.", thirdValue);
                Console.WriteLine("The smallest value is {0}.", firstValue);
            }
            else if (thirdValue > firstValue && firstValue > secondValue)
            {
                Console.WriteLine("The largest value is {0}.", thirdValue);
                Console.WriteLine("The smallest value is {0}.", secondValue);
            }
            else if (firstValue > thirdValue && thirdValue > secondValue)
            {
                Console.WriteLine("The largest value is {0}.", firstValue);
                Console.WriteLine("The smallest value is {0}.", secondValue);
            }
            else if (secondValue > thirdValue && thirdValue > firstValue)
            {
                Console.WriteLine("The largest value is {0}.", secondValue);
                Console.WriteLine("The smallest value is {0}.", firstValue);
            }
            else
            {
                Console.WriteLine("Some or all of the values are equal.");
            }
        }
    }
}
