// using System.Timers;

// namespace EventExample
// {
//     class EventFoo
//     {
//         private static System.Timers.Timer aTimer;
//         public static void Log()
//         {
//             // Create a timer and set a two second interval.
//             aTimer = new System.Timers.Timer(2000);
//             // aTimer.Interval = 2000;

//             // Hook up the Elapsed event for the timer. 
//             aTimer.Elapsed += OnTimedEvent;

//             // Have the timer fire repeated events (true is the default)
//             // aTimer.AutoReset = true;

//             // Start the timer
//             // aTimer.Enabled = true;

//             aTimer.Start();

//             Console.WriteLine("Press the Enter key to exit the program at any time... ");
//             Console.ReadLine();
//         }

//         private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
//         {
//             Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
//         }
//     }
// }