// See https://aka.ms/new-console-template for more information
Console.WriteLine("-----------Inverted Half Traingle Pattern----------");
//Console.WriteLine("Enter the Number");

//int n = int.Parse(Console.ReadLine());
//Console.WriteLine();
int n = 9;
for (int i = n; i >=1; --i)
{
    for(int j = 1; j <= i; ++j)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}
