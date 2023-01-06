// See https://aka.ms/new-console-template for more information
Console.WriteLine("-----------Inverted Half Traingle Pattern----------");
int n = 5;
for(int i = 5; i>=0; --i)
{
    for(int j = 0; j<=i; ++j)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
