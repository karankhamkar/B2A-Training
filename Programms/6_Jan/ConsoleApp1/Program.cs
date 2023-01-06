// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the Number : ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("user enter number" + " "+n);
string hexValue = n.ToString("X");
Console.WriteLine("hexaDecimal Value" +" " +hexValue);


// Coverting hexa to Interger value:

Console.WriteLine("Enter the Hexa Number :");
string hex ="1F4";
Console.WriteLine("Hexa Value"+" "+ hex);
int k = Convert.ToInt32(hex, 16);
Console.WriteLine("Interger Value : "+" "+ k);
