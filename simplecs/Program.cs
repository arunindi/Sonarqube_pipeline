// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
while (true)
        {
            Console.WriteLine("Inside the loop. Press Ctrl+C to exit.");
            // Add some logic here
            
            // Optional: Add a delay to prevent high CPU usage
            // System.Threading.Thread.Sleep(1000); // Sleep for 1 second
        }
    private static void UnusedMethod() 
    {
        Console.WriteLine("Unused method.");
    }

    // Duplicate code
    private static void PrintMessage() 
    {
        Console.WriteLine("Duplicate line.");
        Console.WriteLine("Duplicate line.");
    }
