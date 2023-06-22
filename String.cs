class StringExample 
{
    public static void Log() 
    {
        string txt = "Hello World";
        Console.WriteLine("The length of the txt string is: " + txt.Length);
        
        Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
        Console.WriteLine(txt.ToLower());   // Outputs "hello world"

        string firstName = "John ";
        string lastName = "Doe";
        string fullName = firstName + lastName;
        string name = string.Concat(firstName, lastName);
        string name = $"My full name is: {firstName} {lastName}"; // $: string interpolation
        Console.WriteLine(name);
        
        Console.WriteLine(firstName[0]); // J
        Console.WriteLine(firstName.IndexOf("h")); // 2
        Console.WriteLine(fullName.Substring(2)); // Doe
    }
}