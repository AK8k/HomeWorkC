/*
double numberA = 1;
double numberB = 3;
Console.WriteLine(numberA / numberB);
*/


/*
int numberA = new Random().Next(1, 10);
int numberB = new Random().Next(1, 10);
int result = numberA + numberB;
Console.WriteLine(numberA);
Console.WriteLine(numberB);
Console.WriteLine(result);
*/



Console.WriteLine("Enter user name: ");
string username = Console.ReadLine();
if (username.ToLower() == "maria")
{
    Console.WriteLine("Hi Maria! we find u");

}
else
{
    Console.WriteLine($"Hi, {username} ");
}
