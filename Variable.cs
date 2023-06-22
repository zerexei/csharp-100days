class VariableExample 
{
    public static void Log() 
    {
        // # Types
        int myNum = 5;               // Integer (whole number)
        double myNumDouble = 5.99D;  // Floating point number
        float myNumFloat = 5.75F;
        long myNumLong = 15000000000L;
        char myLetter = 'D';         // Character
        bool myBool = true;          // Boolean
        string myText = "Hello";     // String
        
        // # Variables
        var mutable = 15;
        mutable = 0

        // # Constants
        const int immutable = 15;
        // num = 0; // error

        string name = "John";
        Console.WriteLine("Hello " + name);
    
        int x = 5, y = 6, z = 50;
   
        // int x, y, z;
        // x = y = z = 50;
        Console.WriteLine(x + y + z);

        // cast int to double
        int myInt = 9;
        double myDouble = myInt;
        int castToInt = (int) myDouble;

        int myInt2 = 10;
        double myDouble2 = 5.25;
        bool myBool2 = true;

        Console.WriteLine(Convert.ToString(myInt2));    // convert int to string
        Console.WriteLine(Convert.ToDouble(myInt2));    // convert int to double
        Console.WriteLine(Convert.ToInt32(myDouble2));  // convert double to int
        Console.WriteLine(Convert.ToString(myBool2));   // convert bool to string

    }

}