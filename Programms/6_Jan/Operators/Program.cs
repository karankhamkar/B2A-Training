// See https://aka.ms/new-console-template for more information
Console.WriteLine("------------------ Operators AND, OR, XOR, Complement --------------------- ");
Console.WriteLine("Enter the two Inputs :" );
int k = int.Parse( Console.ReadLine() );
int n = int.Parse( Console.ReadLine() );
Console.WriteLine(" First integer k ="+" "+k +"\n" +"Second Interger n = "+" "+ n);
int result = n | k;
Console.WriteLine("OR operator Implementation");
Console.WriteLine("n | k = " + result);
Console.WriteLine("AND operator Implementation");
int res = n & k;
Console.WriteLine("n & k = " +res);
Console.WriteLine("XOR operator Implementation");
int res1 = n ^ k;
Console.WriteLine("n ^ k = " +res1);
Console.WriteLine("Complement operator Implementation");
int res2 = ~n ;
Console.WriteLine("~n = " + res2);



