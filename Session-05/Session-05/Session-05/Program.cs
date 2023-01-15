//1.Write a C# program that reverses a given string (your name)
using Session_05;
using System.ComponentModel;

string Input = "Chrissanthi";
StringReversal c = new StringReversal();
string result = StringReversal.Reversion(Input);
Console.WriteLine(result);
Console.ReadLine();

//2. Write a C# program that asks the user for an integer (n) and
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

//3.Write a C# program that asks the user for an integer (n) and
//finds all the prime numbers from 1 to n.

Console.WriteLine("Give me a number.");
int num1 = Convert.ToInt32(Console.ReadLine());
int j;
for(j=2; j<= num1; j++)
{
    PrimeNumbers p = new PrimeNumbers();
    if (PrimeNumbers.IsPrime(j))
    {
        Console.WriteLine(j + " ");
    }
}
Console.ReadLine();

