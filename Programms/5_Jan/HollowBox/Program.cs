// See https://aka.ms/new-console-template for more information
Console.WriteLine("-----------Hollow Rectangle Pattern----------");

int row=3;
int col =5;
int i;
int j;

for( i = 0; i < row; i++)
{
    for( j = 0; j < col; j++)
    {
        if(i == 0 || j == 0 || i == row - 1|| j == col - 1) 
        {
            Console.Write("*" +" ");
        }
        else
        {
            Console.Write(" " +" ");
        }
    }
    Console.WriteLine();
}
