class ConditionExample 
{
    public static void Log() 
    {
        // # if...else if...else statement
        int time = 22;
        if (time < 10) 
        {
          Console.WriteLine("Good morning.");
        } 
        else if (time < 20) 
        {
          Console.WriteLine("Good day.");
        } 
        else 
        {
          Console.WriteLine("Good evening.");
        }
        // Outputs "Good evening."

        // # ternary operator
        string result = (time < 18) ? "Good day." : "Good evening.";
        
    
        // # switch statement
        switch(expression) 
        {
          case x:
            // code block
            break;
          case y:
            // code block
            break;
          default:
            // code block
            break;
        }

        // # While loop
        while (condition) 
        {
          // code block to be executed
        }

        // # do while loop
        do 
        {
          // code block to be executed
        }
        while (condition);

        // # for loop
        for (statement 1; statement 2; statement 3) 
        {
          // code block to be executed
        }

        // # foreach loop
        foreach (type variableName in arrayName) 
        {
          // code block to be executed
        }

        continue; // skip to next iteration
        break; // stop loop
    }
}