// class Car
// {
//     public string Model { get; set; } = "default Model";
//     public string Year { get; set; } = "default Year";
//     public string Color { get; set; } = "default Color";

//     public Car(string? model, string? year, string? color)
//     {
//         Model = model;
//         Year = year;
//         Color = color;
//     }

//     public void Make()
//     {
//         Console.WriteLine("static called");
//         Console.WriteLine($"{this.Model} - {this.Year} - {this.Color}");
//     }

//     internal void foo() { }
//     public void foo() { }
//     protected void bar() { }
//     private void baz() { }
// }

//         Car car = new Car(
//         model: "model --",
//         year: "year --",
//         color: "color --"
//         );

//         // car.Make = "-- make";
//         // car.Make();
//         // Car.Make();

//         // car = null;

//         Console.WriteLine($"{car.Make} - {car.Model} - {car.Year} - {car.Color}");
//         // Console.WriteLine($"{car.GetType()}");


// DateTime date = DateTime.Now;

// Console.WriteLine(date.AddDays(3));
// Console.WriteLine(date.AddDays(-3));
// Console.WriteLine(date.AddHours(3));
// Console.WriteLine(date.ToShortTimeString());
// Console.WriteLine(date.ToLongTimeString());
// Console.WriteLine(date.ToLongDateString());
// Console.WriteLine(date.ToShortDateString());

// DateTime birthDay = new DateTime(1912, 12, 12);

// DateTime birthDay = DateTime.Parse("12/12/1912");
// TimeSpan age = DateTime.Now.Subtract(birthDay);

// Console.WriteLine(age.TotalDays);


// Console.WriteLine(string.Format("Phone {0:C}", 1234523473));
// Car car = new Car();
// Console.WriteLine(Car::GetModel());
// class Car
// {
//     private string Model = "Foo";
//     // public string Color { get; set; }

//     public static string GetModel()
//     {
//         return this.Model;
//     }
// }

// StringBuilder str = new StringBuilder();

// for (int i = 0; i < 100; i++)
// {
//     str.Append("--");
//     str.Append(i);
// }

// Console.WriteLine(str);

// string str = "";
// Console.ReadLine();
// Console.WriteLine(string.Format("Phone {0: (###) ###-####}", 1234523473));

// private static bool MainMenu()
// {
//     Console.WriteLine("Choose an option: ");
//     Console.WriteLine("(1) Option 1");
//     Console.WriteLine("(2) Option 2");
//     Console.WriteLine("(3) Exit");

//     string result = Console.ReadLine();

//     if (result == "1")
//     {
//         PrintNumbers();
//         return true;
//     }
//     else if (result == "2")
//     {
//         GuessingGame();
//         return true;
//     }
//     else if (result == "3")
//     {
//         return false;
//     }

//     return false;
// }

// private static void PrintNumbers()
// {
//     Console.Clear();
//     Console.WriteLine("Print numbers: ");
//     Console.Write("Type a number: ");
//     int result = int.Parse(Console.ReadLine());
//     int counter = 1;

//     while (counter < result + 1)
//     {
//         Console.Write(counter);
//         Console.Write("-");
//         counter++;
//     }
//     Console.ReadLine();
// }

// private static void GuessingGame()
// {
//     Console.Clear();
//     Console.WriteLine("guess game");

//     Random rand = new Random();

//     int randNumber = rand.Next(1, 10);
//     int guess = 0;

//     int input;

//     do
//     {
//         input = int.Parse(Console.ReadLine() ?? "0");
//         if (guess > 5) break;
//         guess++;
//         Console.WriteLine("Wrong");

//     } while (input != randNumber);

//     if (guess > 5)
//     {
//         Console.WriteLine("Oops. You failed.");
//         return;
//     }


//     Console.WriteLine("You won");
// }

// ++++++++++++> array <++++++++++++++++

// int[] numbers = new int[5];
// numbers[0] = 11;
// numbers[1] = 12;
// numbers[2] = 13;
// numbers[3] = 14;
// numbers[4] = 15;

// numbers.ToList().ForEach(index,i => Console.WriteLine($"{i.ToString()} - {index}"));

// string[] words = { "a", "b", "c", "d" };
// char[] letters = new char[4] { 'a', 'b', 'c', 'd' };

// string letters = "abcdefghijkl";
// char[] char_letters = letters.ToCharArray();

// char_letters.ToList().ForEach(i => Console.WriteLine(i.ToString()));

// foreach (char item in char_letters)
// {
//     Console.WriteLine(item);
// }
// int[] numbers = { 1, 3, 5, 7, 9 };
// string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

// numbers.ToList().ForEach(i => Console.WriteLine(i.ToString()));
// weekDays.ToList().ForEach(i => Console.WriteLine(i));

// ++++++++++++> loop <++++++++++++++++
// int i = 0;
// do
// {
//     Console.Write("Input: ");
//     string? name;
//     name = Console.ReadLine();
//     Console.WriteLine($"{i}: {name}");
//     if (i == 10) break;
//     i++;
// } while (true);

// int i = 0;
// while (i < 10)
// {
//     Console.Write("Input: ");
//     string? name;
//     name = Console.ReadLine();
//     Console.WriteLine($"{i}: {name}");
//     i++;
// }

// for (int i = 0; i < 10; i++)
// {

//     Console.Write("Input: ");
//     string? name;
//     name = Console.ReadLine();
//     Console.WriteLine($"{i}: {name}");
// }

// ++++++++++++> if statement <++++++++++++++++
// int age = 15;
// string status;

// if (age < 13)
//     status = "Child";
// else if (age < 20)
//     status = "Teen";
// else if (age < 60)
//     status = "Adult";
// else
//     status = "Old";

// char message = status == "Teen" ? '1' : '0';

// Console.WriteLine("status: {0} | message: {1}", status, message);

// ++++++++++++> I/O <++++++++++++++++
// Console.WriteLine("What is your name?");
// Console.Write("Type you first name: ");
// string? first_name;
// first_name = Console.ReadLine();

// Console.Write("Type you last name: ");
// string? last_name = Console.ReadLine();

// Console.WriteLine($"Hello, {first_name} {last_name}");
// Console.ReadLine();

// int x = 1;
// int y = x + 31;
// Console.WriteLine(y + "123");


// ++++++++++++>  <++++++++++++++++
// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World\nEnter your name: ");

// string? test = Console.ReadLine();
// Console.WriteLine($"[{test}]");

// string str = "Hello";
// Console.WriteLine($"[{str}]");