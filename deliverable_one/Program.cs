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

            Console.WriteLine("Please input your second value in USD:");
            Double secondValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input your third value in USD:");
            Double thirdValue = Convert.ToDouble(Console.ReadLine());

            Double total = System.Math.Round(firstValue + secondValue + thirdValue, 2);
            Double average = System.Math.Round((firstValue + secondValue + thirdValue) / 3, 2);
            Console.WriteLine("The total of all of these values is ${0}.", total);
            Console.WriteLine("The average of the three value is ${0}.", average);

            Assignment(firstValue, secondValue, thirdValue);

            USDtoKrona(firstValue, secondValue, thirdValue);
            USDtoYen(firstValue, secondValue, thirdValue);
            USDtoBaht(firstValue, secondValue, thirdValue);
            
        }
        public static void USDtoKrona(Double firstValue, Double secondValue, Double thirdValue)
        {
            Double Krona1 = System.Math.Round(firstValue * 9.28, 2);
            Double Krona2 = System.Math.Round(secondValue * 9.28, 2);
            Double Krona3 = System.Math.Round(thirdValue * 9.28, 2);
            Double Kronat = System.Math.Round((firstValue + secondValue + thirdValue)* 9.28, 2);
            Console.WriteLine("Your first value converts to {0} kr (Krona).", Krona1);
            Console.WriteLine("Your second value converts to {0} kr (Krona).", Krona2);
            Console.WriteLine("Your third value converts to {0} kr (Krona).", Krona3);
            Console.WriteLine("Your total value converts to {0} kr (Krona).", Kronat);
        }
        public static void USDtoYen(Double firstValue, Double secondValue, Double thirdValue)
        {
            Double Yen1 = System.Math.Round(firstValue * 107.9, 0);
            Double Yen2 = System.Math.Round(secondValue * 107.9, 0);
            Double Yen3 = System.Math.Round(thirdValue * 107.9, 0);
            Double Yent = System.Math.Round((firstValue + secondValue + thirdValue) * 107.9, 0);
            Console.WriteLine("Your first value converts to ¥{0} (Yen).", Yen1);
            Console.WriteLine("Your second value converts to ¥{0} (Yen).", Yen2);
            Console.WriteLine("Your third value converts to ¥{0} (Yen).", Yen3);
            Console.WriteLine("Your total value converts to ¥{0} (Yen).", Yent);
        }
        public static void USDtoBaht(Double firstValue, Double secondValue, Double thirdValue)
        {
            Double Baht1 = System.Math.Round(firstValue * 30.63, 2);
            Double Baht2 = System.Math.Round(secondValue * 30.63, 2);
            Double Baht3 = System.Math.Round(thirdValue * 30.63, 2);
            Double bahtt = System.Math.Round((firstValue + secondValue + thirdValue) * 30.63, 2);
            Console.WriteLine("Your first value converts to {0} Baht.", Baht1);
            Console.WriteLine("Your second value converts to {0} Baht.", Baht2);
            Console.WriteLine("Your third value converts to {0} Baht.", Baht3);
            Console.WriteLine("Your total value converts to {0} Baht.", bahtt);
        }
        public static void Assignment(Double firstValue, Double secondValue, Double thirdValue)
        {
            Double first = System.Math.Round(firstValue, 2);
            Double second = System.Math.Round(secondValue, 2);
            Double third = System.Math.Round(thirdValue, 2);

            if (first > second && second > third)
            {
                Console.WriteLine("The largest value is ${0}.", first);
                Console.WriteLine("The smallest value is ${0}.", third);
            }
            else if (second > first && first > third)
            {
                Console.WriteLine("The largest value is ${0}.", second);
                Console.WriteLine("The smallest value is ${0}.", third);
            }
            else if (third > second && second > first)
            {
                Console.WriteLine("The largest value is ${0}.", third);
                Console.WriteLine("The smallest value is ${0}.", first);
            }
            else if (third > first && first > second)
            {
                Console.WriteLine("The largest value is ${0}.", third);
                Console.WriteLine("The smallest value is ${0}.", second);
            }
            else if (first > third && third > second)
            {
                Console.WriteLine("The largest value is ${0}.", first);
                Console.WriteLine("The smallest value is ${0}.", second);
            }
            else if (second > third && third > first)
            {
                Console.WriteLine("The largest value is ${0} USD.", second);
                Console.WriteLine("The smallest value is ${0}.", first);
            }
            else
            {
                Console.WriteLine("Some or all of the values are equal.");
            }
        }
    }
}
