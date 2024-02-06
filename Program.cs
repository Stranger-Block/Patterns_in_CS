Console.WriteLine("1");
Console.WriteLine("");

for (int i = 0; i <= 5; i++)
{
    for (int j = i; j <= 5; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}

Console.WriteLine("");
Console.WriteLine("2");
Console.WriteLine("");

for (int i = 0; i <= 5; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}