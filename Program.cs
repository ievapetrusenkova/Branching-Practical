// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

short A = 82;
short B = 21;
Console.WriteLine(Math.Max(A, B));
Console.WriteLine(Math.Min(A, B));

if (A == B)
{
    Console.WriteLine("They are equal");
}
else
{
    Console.WriteLine("They are not equal");
}
if (A % 2 == 0) 
{
    Console.WriteLine($"The number {A} is even");
}
else
{
    Console.WriteLine($"The number {A} is odd");
}
if (B % 2 == 0)
{
    Console.WriteLine($"The number {B} is even");
}
else
{
    Console.WriteLine($"The number {B} is odd");
}
if (A < 0)
{
    Console.WriteLine($"The number {A} is negative");
}
else
{
    Console.WriteLine($"The number {A} is positive");
}