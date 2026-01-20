using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Anna" };
            Dictionary<int, string> dict = new Dictionary<int, string>
            {
                {1, "One"},
                {2, "Two"},
                {3, "Three"}
            };

            var evenNumbers = numbers.Where(n => n % 2 == 0);
            var firstThreeNumbers = numbers.Take(3);
            var namesStartingWithA = names.Where(n => n.StartsWith("A"));

            var reversedNumbers = numbers.AsEnumerable().Reverse();
            var namesDesc = names.OrderByDescending(n => n);
            var shuffledNumbers = numbers.OrderBy(n => Guid.NewGuid());

            var skippedNumbers = numbers.Skip(2);
            var distinctNumbers = numbers.Distinct();

            var sortedNames = names.OrderBy(n => n).ToList();

            Console.WriteLine("Числа, що діляться на 2:");
            foreach (var n in evenNumbers)
                Console.WriteLine(n);

            Console.WriteLine("\nПерші 3 числа:");
            foreach (var n in firstThreeNumbers)
                Console.WriteLine(n);

            Console.WriteLine("\nІмена, що починаються з A:");
            foreach (var name in namesStartingWithA)
                Console.WriteLine(name);

            Console.WriteLine("\nРозвернуті числа:");
            foreach (var n in reversedNumbers)
                Console.WriteLine(n);

            Console.WriteLine("\nІмена у зворотньому порядку:");
            foreach (var name in namesDesc)
                Console.WriteLine(name);

            Console.WriteLine("\nПеремішані числа:");
            foreach (var n in shuffledNumbers)
                Console.WriteLine(n);

            Console.WriteLine("\nПропустили перші 2 числа:");
            foreach (var n in skippedNumbers)
                Console.WriteLine(n);

            Console.WriteLine("\nУнікальні числа:");
            foreach (var n in distinctNumbers)
                Console.WriteLine(n);

            Console.WriteLine("\nВідсортовані імена:");
            foreach (var name in sortedNames)
                Console.WriteLine(name);

            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}