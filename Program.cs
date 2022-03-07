// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

short A = 182;
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

bool positiveNum = B > 0;
bool negativeNumber = B < 0;

Console.WriteLine($"{B} is positive : {positiveNum}");
Console.WriteLine($"{B} is negative : {negativeNumber}");

if (A < 100)
{
    Console.WriteLine($"The number {A} is less than 100");
}

if (B < 100)
{
    Console.WriteLine($"The number {B} is less than 100");
}

Console.WriteLine(Math.Round(Convert.ToDouble(A + B)));

Console.WriteLine(Math.Abs(Math.Round(Convert.ToDouble(A - B), 2)));

Console.WriteLine("Task2\n");

var time = 8;
var day = 4;
var month = 3;
var year = 2022;

if (time >=0 && time <=24)
    {
        if (time < 12)
        {
            Console.WriteLine("Good morning, Sunshine!");
        }
        if (time >= 13 && time <= 19)
        {
            Console.WriteLine("Good Afternoon. Work Hard!");
        }
        if (time >= 20 && time <= 24)
        {
            Console.WriteLine("Good Evening. Get some rest!");
        }
    }
    if (day >=1 && day <= 31 && month >=1 && month <=12 && year >=1)
    {
        Console.WriteLine($"{year.ToString("D4")}/{month.ToString("D2")}/{day.ToString("D2")}");
    }
    else
    {
        Console.WriteLine("The date is invalid! Please check again!");
    }


Console.WriteLine("\n\n\nExtra task");

Console.WriteLine("\nPlease insert date:");
var inputdate = Console.ReadLine();
int date2 = int.Parse(inputdate);
Console.WriteLine("\nPlease insert month:");
var inputmonth = Console.ReadLine();
int month2 = int.Parse(inputmonth);
Console.WriteLine("\nPlease insert year:");
var inputyear = Console.ReadLine();
int year2 = int.Parse(inputyear);

if (date2 >=1 && date2 <= 31 && month2 >=1 && month2 <=12 && year2 >=1)
{
    Console.WriteLine("\nChoose date format: \n 1: YYYY/MM/DD \n 2: DD.MM.YYYY");
    var inputformat = Console.ReadLine();
    int format = int.Parse(inputformat);

    if (format == 1)
    {
        Console.WriteLine($"{year2.ToString("D4")}/{month2.ToString("D2")}/{date2.ToString("D2")}");
    }
    if (format == 2)
    {
        Console.WriteLine($"{date2.ToString("D2")}.{month2.ToString("D2")}.{year2.ToString("D4")}");
    }
}
else
{
    Console.WriteLine("Invalid date! Check again!");
}