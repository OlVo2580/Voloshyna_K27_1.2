// See https://aka.ms/new-console-template for more information

Console.WriteLine("Input only int number:");
string input = Console.ReadLine();

if (int.TryParse(input, out int n))
{
    Console.WriteLine($"You entered: {n}");
}
else
{
    Console.WriteLine("Your number isnt integer!");
}

Console.ReadLine();