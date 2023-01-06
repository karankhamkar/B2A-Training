Console.WriteLine("-----------Inverted Half Traingle Pattern----------");
//Console.WriteLine("Enter the Number");

//int n = int.Parse(Console.ReadLine());
//Console.WriteLine();
int n = 4;
for (int i = 9; i >= 1; i = i - 2)
{
    for (int j = 1; j <= i; ++j)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}
