namespace HelloWorld
{
    class EnumExample
    {
        public static void Log()
        {
            // collections: https://learn.microsoft.com/en-us/dotnet/standard/collections

            var numbers = new List<int> { 3, 2, 1, 4, 5, 9, 8, 6 };
            numbers.Remove(5);

            foreach (var number in numbers)
            {
                Console.WriteLine($"Hello {number}!");
            }

            var index = numbers.IndexOf(9);
            Console.WriteLine($"index of 9: {index}");

            var notFound = numbers.IndexOf(999);
            Console.WriteLine($"not found: {notFound}");

        }
    }
}