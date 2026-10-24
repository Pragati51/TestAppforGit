// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Generate and print the first 10 Fibonacci numbers
int n = 50;
int a = 0, b = 1;

Console.WriteLine("Fibonacci Series:");
for (int i = 0; i < n; i++)
    //1,2,3,4,5,6,7,8,9,10//
{
    Console.Write(a + " ");
    int temp = a + b;
    a = b;
    b = temp;
    Console.WriteLine($"Fibonacci number {i + 1}: {a}");//console test at 12 pm
    //test
    //test2
    // test for git new branch
    //test stashes
}
Console.WriteLine();
