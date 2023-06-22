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

            // # array
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            Console.WriteLine(cars[0]); // Volvo

            cars[0] = "Opel";
            Console.WriteLine(cars[0]); // Opel
            Console.WriteLine(cars.Length); // 4

            // Create an array of four elements and add values right away 
            string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

            // # sort array
            Array.Sort(cars);

            // using System.Linq;
            int[] myNumbers = {5, 1, 8, 9};
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

            // # 2d array
            int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
            Console.WriteLine(numbers[0, 1]);  // Outputs 4

            numbers[0, 0] = 5;  // Change value to 5
            Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1

            //? why???
            foreach (int i in numbers)
            {
              Console.WriteLine(i); // 1,4,2,3,6,8
            } 

            for (int i = 0; i < numbers.GetLength(0); i++) 
            { 
              for (int j = 0; j < numbers.GetLength(1); j++) 
              { 
                Console.WriteLine(numbers[i, j]); 
              } 
            }  
        }
    }
}