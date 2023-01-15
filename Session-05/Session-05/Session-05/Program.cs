//1.Write a C# program that reverses a given string (your name)
using Session_05;

string Input = "Chrissanthi";
StringReversal c = new StringReversal();
string result = StringReversal.Reversion(Input);
Console.WriteLine(result);
Console.ReadLine();

// Write a C# program that asks the user for an integer (n) and
// gives them the possibility to choose between computing the sum
// and computing the product of 1,…,n.

Console.WriteLine("Give me a number.");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Choose between");
Console.WriteLine("true. Sum");
Console.WriteLine("false. Factoral");
bool s = Convert.ToBoolean(Console.ReadLine());
int res = 0;
if(s)
{
    Addition d = new Addition();
    res = Addition.Add(number);
}
else
{
    Factorial e = new Factorial();
    res = Factorial.Fact(number);
}
Console.WriteLine("The result is:" + res);
Console.ReadLine();

