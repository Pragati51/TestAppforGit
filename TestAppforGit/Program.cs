// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Generate and print the first 10 Fibonacci numbers
int n = 50;
int a = 0, b = 1;

Console.WriteLine("Fibonacci Series:");
for (int i = 0; i < n; i++)
{
    Console.Write(a + " ");
    int temp = a + b;
    a = b;
    b = temp;
    Console.WriteLine($"Fibonacci number {i + 1}: {a}");
    //test
}
Console.WriteLine();
